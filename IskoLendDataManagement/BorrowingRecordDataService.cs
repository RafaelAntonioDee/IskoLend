using IskoLendModel;
using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var statement = "Select BorrowID\r\n      ,B_FaciID as FacilitatorID\r\n      ,StudentID\r\n      ,BorrowDate\r\n      ,StatusID\r\n      ,DateCompleted From BorrowingRecord;";
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
        public void SaveBorrowItems(DataTable dt, string borrowID)
        {
            _connection.Open();
            using var tx = _connection.BeginTransaction();

            try
            {
                foreach (DataRow row in dt.Rows)
                {
                    string supplyId = row["SupplyID"].ToString();
                    int qty = Convert.ToInt32(row["Qty"]);

                    using (var insertCmd = new SqlCommand(@"INSERT INTO BorrowingDetails (BorrowID, SupplyID, BorrowedQty, ItemStatusID) VALUES (@BorrowID, @SupplyID, @Qty, 'S001');", _connection, tx))
                    {
                        insertCmd.Parameters.AddWithValue("@BorrowID", borrowID);
                        insertCmd.Parameters.AddWithValue("@SupplyID", supplyId);
                        insertCmd.Parameters.AddWithValue("@Qty", qty);
                        insertCmd.ExecuteNonQuery();
                    }

                    UpdateQuantityBorrow(row, tx);
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

            using var cmd = new SqlCommand(sql, _connection, tx);
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
    }
}