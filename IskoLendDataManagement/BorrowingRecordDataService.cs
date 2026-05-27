using IskoLendModel;
using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IskoLendDataManagement
{
    public class BorrowingRecordDataService
    {
        private string _connectionString = "Server=localhost\\SQLEXPRESS;Database=IskoLendDB;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
        private SqlConnection _connection;
        public BorrowingRecordDataService()
        {
            _connection = new SqlConnection(_connectionString);
        }

        public DataTable GetAllBorrowingRecord()
        {
            var statement = "Select BorrowID\r\n      ,CONCAT(F.FirstName, ' ', F.LastName) As Facilitator\r\n      ,StudentID\r\n      ,BorrowDate\r\n      ,S.StatusName AS Status\r\n      ,DateCompleted From BorrowingRecord AS BR JOIN Facilitator AS F ON F.FacilitatorID = BR.B_FaciID JOIN StatusCode AS S ON S.StatusID = BR.StatusID;";
            SqlDataAdapter adapter = new SqlDataAdapter(statement, _connection);
            _connection.Open();
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            _connection.Close();
            return dataTable;
        }

        public DataTable? GetSelectedBorrowDetail(string BorrowID)
        {
            var statement = $"Select SI.ItemName as Supply,\r\nBorrowedQty,\r\nSC.StatusName as ReturnStatus\r\nFrom BorrowingDetails as BD \r\njoin SupplyInventory as SI \r\n    on BD.SupplyID = SI.SupplyID\r\njoin StatusCode as SC\r\n    on SC.StatusID = BD.ItemStatusID\r\n    Where BorrowID = '{BorrowID.Trim()}';";
            SqlDataAdapter adapter = new SqlDataAdapter(statement, _connection);
            _connection.Open();
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            _connection.Close();
            return dataTable;
        }
        public DataTable? GetSelectedReturnDetail(string BorrowID, string ItemName)
        {
            var statement = $"Select ReturnDetailID,\r\n    SI.ItemName as Supply,\r\n    R_FaciID,\r\n    ReturnedQty,\r\n    ReturnDate\r\nfrom ReturnDetails as RD \r\njoin SupplyInventory as SI \r\n    on SI.SupplyID = RD.R_SupplyID\r\n    Where RD.R_BorrowID = '{BorrowID}' \r\n    AND SI.ItemName = '{ItemName}';";
            SqlDataAdapter adapter = new SqlDataAdapter(statement, _connection);
            _connection.Open();
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            _connection.Close();
            return dataTable;
        }
        public bool isStudent(string StudentID)
        {
            var statement = $"Select StudentID from dbo.Borrower where StudentID = '{StudentID}';";
            SqlCommand command = new SqlCommand(statement, _connection);
            _connection.Open();
            var result = command.ExecuteScalar();
            _connection.Close();
            return result != null;
        }

        public string GetLastBorrowID()
        {
            var statement = "SELECT TOP 1 BorrowID FROM BorrowingRecord ORDER BY BorrowID DESC;";
            SqlCommand command = new SqlCommand(statement, _connection);
            _connection.Open();
            var result = command.ExecuteScalar();
            _connection.Close();
            return result?.ToString() ?? string.Empty;
        }
        public string GenerateBorrowID()
        {
            string? lastID = GetLastBorrowID();

            if (string.IsNullOrWhiteSpace(lastID))
                return "B001";

            int numericPart = int.Parse(lastID[1..]);
            int next = numericPart + 1;

            return "B" + (next < 1000 ? next.ToString("D3") : next.ToString());
        }

        public string GetLastReturnID()
        {
            var statement = "SELECT TOP 1 ReturnDetailID FROM ReturnDetails ORDER BY ReturnDetailID DESC;";
            SqlCommand command = new SqlCommand(statement, _connection);
            _connection.Open();
            var result = command.ExecuteScalar();
            _connection.Close();
            return result?.ToString() ?? string.Empty;
        }
        public string GenerateReturnID()
        {
            string? lastID = GetLastReturnID();

            if (string.IsNullOrWhiteSpace(lastID))
                return "R001";

            int numericPart = int.Parse(lastID[1..]);
            int next = numericPart + 1;

            return "R" + (next < 1000 ? next.ToString("D3") : next.ToString());
        }
        public void AddBorrowingRecord(BorrowingRecord record)
        {
            const string sql = @" INSERT INTO BorrowingRecord (BorrowID, B_FaciID, StudentID, BorrowDate, StatusID, DateCompleted) VALUES (@BorrowID, @FaciID, @StudentID, @BorrowDate, @StatusID, NULL);";

            using var cmd = new SqlCommand(sql, _connection);

            cmd.Parameters.Add("@BorrowID", SqlDbType.VarChar).Value = record.BorrowID;
            cmd.Parameters.Add("@FaciID", SqlDbType.VarChar).Value = record.FacilitatorID;
            cmd.Parameters.Add("@StudentID", SqlDbType.VarChar).Value = record.StudentID;
            cmd.Parameters.Add("@BorrowDate", SqlDbType.DateTime).Value = record.BorrowedDate;
            cmd.Parameters.Add("@StatusID", SqlDbType.VarChar).Value = record.StatusID;
            _connection.Open();
            cmd.ExecuteNonQuery();
            _connection.Close();
        }
        public void SaveBorrowItems(DataTable dt, BorrowingRecord record)
        {
            Supply curr;
            var service = new SupplyDataService();
            _connection.Open();
            using var tx = _connection.BeginTransaction();

            try
            {
                foreach (DataRow row in dt.Rows)
                {
                    Logs logs;
                    string supplyId = row["SupplyID"].ToString();
                    int qty = Convert.ToInt32(row["Qty"]);
                     curr = service.getSupplyByID(supplyId,tx);


                    using (var insertCmd = new SqlCommand(@"INSERT INTO BorrowingDetails (BorrowID, SupplyID, BorrowedQty, ItemStatusID) VALUES (@BorrowID, @SupplyID, @Qty, 'S001');", _connection, tx))
                    {
                        insertCmd.Parameters.AddWithValue("@BorrowID", record.BorrowID);
                        insertCmd.Parameters.AddWithValue("@SupplyID", supplyId);
                        insertCmd.Parameters.AddWithValue("@Qty", qty);
                        insertCmd.ExecuteNonQuery();
                    }
                    logs = new Logs { 
                        LogID = service.GenerateLogID(tx),
                        SupplyID = supplyId,
                        FacilitatorID = record.FacilitatorID,
                        ActionType = "Borrow",
                        ActionID = record.BorrowID,
                        InitialQty = curr.Quantity,
                        FinalQty = curr.Quantity - qty,
                        LogDate = DateTime.Now
                    };
                    service.AddSupLog(logs, tx);
                    UpdateQuantityBorrow(row,tx);
                    
                }

                tx.Commit();
            }
            catch
            {
                tx.Rollback();
                throw;
            }
            finally
            {
                _connection.Close();
            }
        }

        private void UpdateQuantityBorrow(DataRow row, SqlTransaction tx)
        {
            string supplyId = row["SupplyID"].ToString();
            int qty = Convert.ToInt32(row["Qty"]);

            const string sql = @"UPDATE SupplyInventory SET Quantity = Quantity - @qty WHERE SupplyID = @supplyId;";

            using var cmd = new SqlCommand(sql, tx.Connection, tx);
            cmd.Parameters.AddWithValue("@qty", qty);
            cmd.Parameters.AddWithValue("@supplyId", supplyId);
            cmd.ExecuteNonQuery();
        }

        public DataTable GetItemsAvailable()
        {
            var statement = $"Select ItemName from SupplyInventory where Quantity>0;";
            SqlDataAdapter adapter = new SqlDataAdapter(statement, _connection);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;

        }
        public DataTable GetItemsAvailableByCategory(string CategoryName)
        {
            var statement = $"Select ItemName from SupplyInventory as SI join Category as C on SI.CategoryID = C.CategoryID  Where CategoryName = '{CategoryName}' AND Quantity>0;";
            SqlDataAdapter adapter = new SqlDataAdapter(statement, _connection);


            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;

        }
        public DataTable GetItems()
        {
            var statement = $"Select ItemName from SupplyInventory;";
            SqlDataAdapter adapter = new SqlDataAdapter(statement, _connection);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;

        }
        public DataTable GetItemsByCategory(string CategoryName)
        {
            var statement = $"Select ItemName from SupplyInventory as SI join Category as C on SI.CategoryID = C.CategoryID  Where CategoryName = '{CategoryName}';";
            SqlDataAdapter adapter = new SqlDataAdapter(statement, _connection);


            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;

        }
        public DataTable GetCategories()
        {
            var statement = $"Select CategoryName from Category ORDER BY CategoryID;";
            SqlDataAdapter adapter = new SqlDataAdapter(statement, _connection);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;

        }
        public DataRow? AddItem(DataTable dt, string itemName, int qty)
        {
            if (!IsCapable(itemName, qty))
                return null;

            var supplyId = GetSupplyID(itemName);

            DataRow r = dt.NewRow();
            r["SupplyID"] = supplyId;
            r["Item"] = itemName;
            r["Qty"] = qty;

            dt.Rows.Add(r);
            return r;
        }

        public bool IsCapable(string ItemName, int Qty)
        {
            const string sql = "SELECT Quantity FROM SupplyInventory WHERE ItemName = @name;";

            using var query = new SqlCommand(sql, _connection);
            query.Parameters.AddWithValue("@name", ItemName);

            _connection.Open();
            object result = query.ExecuteScalar();
            _connection.Close();

            int itemQty = Convert.ToInt32(result);
            return itemQty >= Qty;
        }
        public string? GetSupplyID(string name)
        {
            const string sql = "SELECT SupplyID FROM SupplyInventory WHERE ItemName = @name;";

            using var cmd = new SqlCommand(sql, _connection);
            cmd.Parameters.AddWithValue("@name", name);

            _connection.Open();
            object result = cmd.ExecuteScalar();
            _connection.Close();

            return (result == null || result == DBNull.Value) ? null : result.ToString();
        }
        public string? GetStatusID(string status)
        {
            const string sql = "SELECT StatusID FROM StatusCode WHERE StatusName = @StatusName;";

            using var cmd = new SqlCommand(sql, _connection);
            cmd.Parameters.AddWithValue("@StatusName", status);

            _connection.Open();
            object result = cmd.ExecuteScalar();
            _connection.Close();

            return (result == null || result == DBNull.Value) ? null : result.ToString();
        }
        public string? GetSupplyName(string ID)
        {
            const string sql = "SELECT ItemName FROM SupplyInventory WHERE SupplyID = @id;";

            using var cmd = new SqlCommand(sql, _connection);
            cmd.Parameters.AddWithValue("@id", ID);

            _connection.Open();
            object result = cmd.ExecuteScalar();
            _connection.Close();

            return (result == null || result == DBNull.Value) ? null : result.ToString();
        }
        public int GetRemaining(string BorrowID, string SupplyID)
        {
            const string sql = @"SELECT BD.BorrowedQty - COALESCE(RD.TotalReturned, 0) AS Remaining FROM BorrowingDetails BD
                                LEFT JOIN ( SELECT R_BorrowID, R_SupplyID, SUM(ReturnedQty) AS TotalReturned
                                FROM ReturnDetails GROUP BY R_BorrowID, R_SupplyID ) RD ON RD.R_BorrowID = BD.BorrowID
                                AND RD.R_SupplyID = BD.SupplyID WHERE BD.BorrowID = @BorrowID AND BD.SupplyID = @SupplyID;";

            using var query = new SqlCommand(sql, _connection);
            query.Parameters.AddWithValue("@BorrowID", BorrowID);
            query.Parameters.AddWithValue("@SupplyID", SupplyID);
            _connection.Open();
            object result = query.ExecuteScalar();
            _connection.Close();

            int itemQty = Convert.ToInt32(result);
            return itemQty;
        }
        public int GetRemaining(string borrowID, string supplyID, SqlTransaction tx)
        {
            const string sql = @"SELECT BD.BorrowedQty - COALESCE(RD.TotalReturned, 0) AS Remaining FROM BorrowingDetails BD
                                LEFT JOIN ( SELECT R_BorrowID, R_SupplyID, SUM(ReturnedQty) AS TotalReturned
                                FROM ReturnDetails GROUP BY R_BorrowID, R_SupplyID ) RD ON RD.R_BorrowID = BD.BorrowID
                                AND RD.R_SupplyID = BD.SupplyID WHERE BD.BorrowID = @BorrowID AND BD.SupplyID = @SupplyID;";

            using var cmd = new SqlCommand(sql, _connection, tx);
            cmd.Parameters.AddWithValue("@BorrowID", borrowID);
            cmd.Parameters.AddWithValue("@SupplyID", supplyID);

            return Convert.ToInt32(cmd.ExecuteScalar());
        }
        public void AddReturnDetail(ReturnDetail returnDetail)
        {
            var service = new SupplyDataService();
            Logs log;
            Supply curr;
            const string insertSql = @"
                INSERT INTO ReturnDetails (ReturnDetailID, R_BorrowID, R_SupplyID, R_FaciID, ReturnedQty, ReturnDate)
                VALUES (@ReturnID, @BorrowID, @SupplyID, @FaciID, @ReturnedQty, @ReturnDate);";

            _connection.Open();
            using var tx = _connection.BeginTransaction();
            int remaining = GetRemaining(returnDetail.R_BorrowID, returnDetail.R_SupplyID, tx);
            curr = service.getSupplyByID(returnDetail.R_SupplyID, tx);
            try
            {
                using (var cmd = new SqlCommand(insertSql, _connection, tx))
                {
                    cmd.Parameters.Add("@ReturnID", SqlDbType.VarChar).Value = returnDetail.ReturnDetailID;
                    cmd.Parameters.Add("@BorrowID", SqlDbType.VarChar).Value = returnDetail.R_BorrowID;
                    cmd.Parameters.Add("@SupplyID", SqlDbType.VarChar).Value = returnDetail.R_SupplyID;
                    cmd.Parameters.Add("@FaciID", SqlDbType.VarChar).Value = returnDetail.R_FaciID;
                    cmd.Parameters.Add("@ReturnedQty", SqlDbType.Int).Value = returnDetail.ReturnedQty;
                    cmd.Parameters.Add("@ReturnDate", SqlDbType.DateTime).Value = returnDetail.ReturnDate;
                    cmd.ExecuteNonQuery();
                }
                log = new Logs
                {
                    LogID = service.GenerateLogID(tx),
                    SupplyID = returnDetail.R_SupplyID,
                    FacilitatorID = returnDetail.R_FaciID,
                    ActionType = "Return",
                    ActionID = returnDetail.ReturnDetailID,
                    InitialQty = curr.Quantity,
                    FinalQty = curr.Quantity + returnDetail.ReturnedQty,
                    LogDate = DateTime.Now
                };
                UpdateQuantityReturn(returnDetail, tx);
                //UpdateRemainingBorrowed(returnDetail, tx);
                UpdateBorrowDetailStatus(returnDetail, log,tx);
                UpdateBorrowStatus(returnDetail, tx);
                UpdateDateCompleted(returnDetail, tx);
                service.AddSupLog(log, tx)
                ;tx.Commit();
            }
            catch
            {
                tx.Rollback();
                throw;
            }
            finally
            {
                _connection.Close();
            }
        }
        private void UpdateQuantityReturn(ReturnDetail returnDetail, SqlTransaction tx)
        {
            const string sql = @"UPDATE SupplyInventory
                         SET Quantity = Quantity + @qty
                         WHERE SupplyID = @supplyId;";

            using var cmd = new SqlCommand(sql, _connection, tx);
            cmd.Parameters.AddWithValue("@qty", returnDetail.ReturnedQty);
            cmd.Parameters.AddWithValue("@supplyId", returnDetail.R_SupplyID);
            cmd.ExecuteNonQuery();
        }
        //private void UpdateRemainingBorrowed(ReturnDetail returnDetail, SqlTransaction tx)
        //{
        //    const string sql = @"UPDATE BorrowingDetail
        //                 SET BorrowedQty = BorrowedQty - @qty
        //                 WHERE SupplyID = @supplyId;";

        //    using var cmd = new SqlCommand(sql, _connection, tx);
        //    cmd.Parameters.AddWithValue("@qty", returnDetail.ReturnedQty);
        //    cmd.Parameters.AddWithValue("@supplyId", returnDetail.R_SupplyID);
        //    cmd.ExecuteNonQuery();
        //}
        public void UpdateBorrowDetailStatus(ReturnDetail ret, Logs log, SqlTransaction tx)
        {
            int remaining = GetRemaining(ret.R_BorrowID, ret.R_SupplyID, tx);

            string? status = ret.ReturnedQty == 0 ? "S004"
                           : remaining == 0 ? "S003"
                           : remaining > 0 ? "S002"
                           : null;
            if (status.Equals("S004")) log.ActionType = "Return (Lost)";

            if (status == null)
                throw new InvalidOperationException($"Remaining is negative for BorrowID={ret.R_BorrowID}, SupplyID={ret.R_SupplyID}.");

            using var cmd = new SqlCommand(@"UPDATE BorrowingDetails
                                            SET ItemStatusID = @Status
                                            WHERE BorrowID = @BorrowID AND SupplyID = @SupplyID;", _connection, tx);

            cmd.Parameters.AddWithValue("@Status", status);
            cmd.Parameters.AddWithValue("@BorrowID", ret.R_BorrowID);
            cmd.Parameters.AddWithValue("@SupplyID", ret.R_SupplyID);
            cmd.ExecuteNonQuery();
        }

        private void UpdateBorrowStatus(ReturnDetail ret, SqlTransaction tx)
        {
            const string sql = @"UPDATE br SET br.StatusID = CASE WHEN EXISTS (
                    SELECT 1 FROM BorrowingDetails bd
                    WHERE bd.BorrowID = br.BorrowID
                    AND bd.ItemStatusID NOT IN ('S003', 'S004')) 
                    THEN 'S002'
                    ELSE 'S003' 
                    END
                    FROM BorrowingRecord br
                    WHERE br.BorrowID = @BorrowID;";
            using var cmd = new SqlCommand(sql, _connection, tx);
            cmd.Parameters.AddWithValue("@BorrowID", ret.R_BorrowID);
            cmd.ExecuteNonQuery();
        }
        private void UpdateDateCompleted(ReturnDetail ret, SqlTransaction tx)
        {
            using var cmd = new SqlCommand(@"UPDATE BorrowingRecord
                                            SET DateCompleted = @DateCompleted
                                            WHERE BorrowID = @BorrowID
                                              AND StatusID = 'S003'
                                              AND DateCompleted IS NULL;", _connection, tx);

            cmd.Parameters.AddWithValue("@DateCompleted", DateTime.Now);
            cmd.Parameters.AddWithValue("@BorrowID", ret.R_BorrowID);
            cmd.ExecuteNonQuery();
        }
        public DataTable FilteredBorrowingRecord(string search, string cmbDate, string statusID)
        {
            // null = ALL
            if (string.Equals(cmbDate, "Date", StringComparison.OrdinalIgnoreCase))
                cmbDate = null;

            if (string.Equals(statusID, "Status", StringComparison.OrdinalIgnoreCase))
                statusID = null;

            DateTime? fromDate = null;
            DateTime? toDateExclusive = null;

            if (cmbDate == "Today")
            {
                fromDate = DateTime.Today;
                toDateExclusive = DateTime.Today.AddDays(1);
            }
            else if (cmbDate == "Yesterday")
            {
                fromDate = DateTime.Today.AddDays(-1);
                toDateExclusive = DateTime.Today;
            }
            else if (cmbDate == "Last 7 Days")
            {
                fromDate = DateTime.Today.AddDays(-7);
                toDateExclusive = DateTime.Today.AddDays(1);
            }
            else if (cmbDate == "This Month")
            {
                fromDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                toDateExclusive = fromDate.Value.AddMonths(1);
            }
            // else: null => all dates

            const string sql = @"
SELECT 
    BorrowID,
    CONCAT(F.FirstName, ' ', F.LastName) AS Facilitator,
    StudentID,
    BorrowDate,
    S.StatusName AS Status,
    DateCompleted
FROM BorrowingRecord AS BR
JOIN Facilitator AS F 
    ON F.FacilitatorID = BR.B_FaciID
JOIN StatusCode AS S 
    ON S.StatusID = BR.StatusID
WHERE
(
    @SearchBar IS NULL
    OR StudentID LIKE '%' + @SearchBar + '%'
    OR CONCAT(F.FirstName, ' ', F.LastName) LIKE '%' + @SearchBar + '%'
    OR BorrowID LIKE '%' + @SearchBar + '%'
)
AND
(
    @status IS NULL 
    OR BR.StatusID = @status
)
AND
(
    @fromDate IS NULL 
    OR BorrowDate >= @fromDate
)
AND
(
    @toDate IS NULL 
    OR BorrowDate <= @toDate
);";

            using var cmd = new SqlCommand(sql, _connection);

            cmd.Parameters.Add("@SearchBar", SqlDbType.VarChar).Value =
                string.IsNullOrWhiteSpace(search) ? (object)DBNull.Value : search;

            cmd.Parameters.Add("@status", SqlDbType.VarChar).Value =
                string.IsNullOrWhiteSpace(statusID) ? (object)DBNull.Value : statusID;

            cmd.Parameters.Add("@fromDate", SqlDbType.DateTime).Value =
                fromDate.HasValue ? fromDate.Value : (object)DBNull.Value;

            cmd.Parameters.Add("@toDate", SqlDbType.DateTime).Value =
                toDateExclusive.HasValue ? toDateExclusive.Value : (object)DBNull.Value;

            using var adapter = new SqlDataAdapter(cmd);
            var dt = new DataTable();

            _connection.Open();
            adapter.Fill(dt);
            _connection.Close();

            return dt;
        }

        public DataTable GetAllStatus()
        {
            var statement = $"Select StatusName from StatusCode;";
            SqlDataAdapter adapter = new SqlDataAdapter(statement, _connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
    }
}