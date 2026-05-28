using IskoLendModel;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IskoLendDataManagement
{

    public class SupplyDataService
    {
        List<Supply> supplies = new List<Supply>();
        private string _connectionString = "Server=localhost\\SQLEXPRESS;Database=IskoLendDB;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
        private SqlConnection _connection;
        public SupplyDataService()
        {
            _connection = new SqlConnection(_connectionString);
        }


        public Supply getSupplyByID(string supID)
        {
            const string sql = "SELECT * FROM SupplyInventory  WHERE SupplyID = @SupplyID;";

            using var cmd = new SqlCommand(sql, _connection);
            cmd.Parameters.AddWithValue("@SupplyID", supID);

            _connection.Open();

            using var reader = cmd.ExecuteReader();

            Supply sup = null;

            if (reader.Read())
            {
                sup = new Supply
                {
                    SupplyID = reader["SupplyID"].ToString(),
                    CategoryID = reader["CategoryID"].ToString(),
                    SupplyName = reader["ItemName"].ToString(),
                    Quantity = int.Parse(reader["Quantity"].ToString())
                };
            }

            _connection.Close();

            return sup;
        }
        public Supply getSupplyByID(string supID,SqlTransaction tx)
        {
            const string sql = "SELECT * FROM SupplyInventory  WHERE SupplyID = @SupplyID;";

            using var cmd = new SqlCommand(sql, tx.Connection,tx);
            cmd.Parameters.AddWithValue("@SupplyID", supID);

           

            using var reader = cmd.ExecuteReader();

            Supply sup = null;

            if (reader.Read())
            {
                sup = new Supply
                {
                    SupplyID = reader["SupplyID"].ToString(),
                    CategoryID = reader["CategoryID"].ToString(),
                    SupplyName = reader["ItemName"].ToString(),
                    Quantity = int.Parse(reader["Quantity"].ToString())
                };
            }

           

            return sup;
        }

        
        public DataTable GetSupplyLogs()
        {
            var statement = "Select LogID, S.ItemName As Supply, CONCAT(F.FirstName, ' ', F.LastName) As Facilitator, ActionType, ActionID, InitialQty, FinalQty As NewQty, LogDate As Date  From SupplyLogs AS SL JOIN SupplyInventory AS S ON S.SupplyID = SL.SupplyID JOIN Facilitator AS F ON F.FacilitatorID = SL.FacilitatorID;";
            SqlDataAdapter adapter = new SqlDataAdapter(statement, _connection);
            _connection.Open();
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            _connection.Close();
            return dataTable;
        }
        public DataTable GetAllSupplies()
        {
            var statement = "Select SupplyID ,C.CategoryName AS Category,ItemName ,Quantity From SupplyInventory AS SI JOIN Category AS C ON C.CategoryID = SI.CategoryID;";
            SqlDataAdapter adapter = new SqlDataAdapter(statement, _connection);
            _connection.Open();
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            _connection.Close();
            return dataTable;
        }

        public DataTable FilteredSupplies(string search, string category)
        {
            // null = ALL

            string catID = "";

            if (string.Equals(category, "Categories", StringComparison.OrdinalIgnoreCase))
                category = null;
            else
            {
                catID = getCategoryID(category);

            }

            DateTime? fromDate = null;
            DateTime? toDateExclusive = null;



            const string sql = @"
SELECT 
    SupplyID,
    C.CategoryName AS Category,
    ItemName,
    Quantity
FROM SupplyInventory AS SI
JOIN Category AS C 
    ON C.CategoryID = SI.CategoryID
WHERE
    (
        @SearchBar IS NULL 
        OR SupplyID LIKE '%' + @SearchBar + '%'
        OR ItemName LIKE '%' + @SearchBar + '%'
    )
    AND
    (
        @category IS NULL 
        OR C.CategoryID = @category
    );";

            using var cmd = new SqlCommand(sql, _connection);

            cmd.Parameters.Add("@SearchBar", SqlDbType.VarChar).Value =
                string.IsNullOrWhiteSpace(search) ? (object)DBNull.Value : search;

            cmd.Parameters.Add("@category", SqlDbType.VarChar).Value =
                string.IsNullOrWhiteSpace(catID) ? (object)DBNull.Value : catID;

            using var adapter = new SqlDataAdapter(cmd);
            var dt = new DataTable();

            _connection.Open();
            adapter.Fill(dt);
            _connection.Close();

            return dt;
        }
        public DataTable GetAllCategories()
        {
            var statement = "SELECT * FROM Category;";
            SqlDataAdapter adapter = new SqlDataAdapter(statement, _connection);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;
        }
        public string GenerateSupplyID()
        {
            string? lastID = GetLastSupplyID();

            if (string.IsNullOrWhiteSpace(lastID))
                return "SUP001";

            int numericPart = int.Parse(lastID[3..]);
            int next = numericPart + 1;

            return "SUP" + (next < 1000 ? next.ToString("D3") : next.ToString());
        }
        public string GetLastSupplyID()
        {
            var statement = "SELECT TOP 1 SupplyID FROM SupplyInventory ORDER BY SupplyID DESC;";
            SqlCommand command = new SqlCommand(statement, _connection);
            _connection.Open();
            var result = command.ExecuteScalar();
            _connection.Close();
            return result?.ToString() ?? string.Empty;
        }

        public void AddSupply(Supply sup, String faci)
        {
            const string sql = @" INSERT INTO SupplyInventory (SupplyID, CategoryID, ItemName, Quantity) VALUES (@SupID, @CatID, @ItemName, @Quantity);";

            using var cmd = new SqlCommand(sql, _connection);

            cmd.Parameters.Add("@SupID", SqlDbType.VarChar).Value = sup.SupplyID;
            cmd.Parameters.Add("@CatID", SqlDbType.VarChar).Value = sup.CategoryID;
            cmd.Parameters.Add("@ItemName", SqlDbType.VarChar).Value = sup.SupplyName;
            cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = sup.Quantity;


            _connection.Open();
            cmd.ExecuteNonQuery();

            using var tx = _connection.BeginTransaction();

            Supply curr = getSupplyByID(sup.SupplyID, tx);
            string newID = GenerateLogID(tx);
            Logs log = new Logs
            {
                LogID = newID,
                SupplyID = sup.SupplyID,
                FacilitatorID = faci,
                ActionType = "Add",
                ActionID = newID,
                InitialQty = curr.Quantity,
                FinalQty = curr.Quantity,
                LogDate = DateTime.Now
            };
            AddSupLog(log, tx);
            tx.Commit();

            _connection.Close();

        }
        public string getCategoryID(string category)
        {
            const string sql = "SELECT CategoryID FROM Category WHERE CategoryName = @CategoryName;";

            using var cmd = new SqlCommand(sql, _connection);
            cmd.Parameters.AddWithValue("@CategoryName", category);

            _connection.Open();
            object result = cmd.ExecuteScalar();
            _connection.Close();

            return result?.ToString();
        }

        public void UpdateSupply(Supply sup, String faci)
        {
            _connection.Open();

            using var tx = _connection.BeginTransaction();

            Supply curr = getSupplyByID(sup.SupplyID, tx);
            string newID = GenerateLogID(tx);
            Logs log = new Logs
            {
                LogID = newID,
                SupplyID = sup.SupplyID,
                FacilitatorID = faci,
                ActionType = "Edit",
                ActionID = newID,
                InitialQty = curr.Quantity,
                FinalQty = sup.Quantity,
                LogDate = DateTime.Now
            };
            AddSupLog(log, tx);
            tx.Commit();

            var statement = @"UPDATE SupplyInventory SET CategoryID = @CategoryID, ItemName = @ItemName, Quantity = @Quantity WHERE SupplyID = @SupplyID";

            SqlCommand cmd = new SqlCommand(statement, _connection);

            cmd.Parameters.AddWithValue("@SupplyID", sup.SupplyID);
            cmd.Parameters.AddWithValue("@CategoryID", sup.CategoryID);
            cmd.Parameters.AddWithValue("@ItemName", sup.SupplyName);
            cmd.Parameters.AddWithValue("@Quantity", sup.Quantity);
            cmd.ExecuteNonQuery();

            

            _connection.Close();
        }

        public string getCategory(string catID)
        {
            const string sql = "SELECT CategoryName FROM Category WHERE CategoryID = @CategoryID;";

            using var cmd = new SqlCommand(sql, _connection);
            cmd.Parameters.AddWithValue("@CategoryID", catID);

            _connection.Open();
            object result = cmd.ExecuteScalar();
            _connection.Close();

            return result?.ToString();
        }
        public void RemoveSupply(string supID, string faci)
        {
            _connection.Open();

            using var tx = _connection.BeginTransaction();

            Supply curr = getSupplyByID(supID, tx);
            string newID = GenerateLogID(tx);
            Logs log = new Logs
            {
                LogID = newID,
                SupplyID = supID,
                FacilitatorID = faci,
                ActionType = "Delete",
                ActionID = newID,
                InitialQty = curr.Quantity,
                FinalQty = 0,
                LogDate = DateTime.Now
            };
            AddSupLog(log, tx);
            tx.Commit();

            _connection.Close();

            var statement = $"DELETE FROM SupplyInventory WHERE SupplyID = '{supID}';";

            SqlCommand cmd = new SqlCommand(statement, _connection);


            _connection.Open();
            cmd.ExecuteNonQuery();

            _connection.Close();

        }

        public void AddSupLog(Logs log, SqlTransaction tx)
        {
            const string sql = @" INSERT INTO SupplyLogs (LogID, SupplyID, FacilitatorID, ActionType, ActionID, InitialQty, FinalQty, LogDate) VALUES (@LogID, @SupplyID, @FacilitatorID, @ActionType, @ActionID, @InitialQty, @FinalQty, @LogDate);";

            using var cmd = new SqlCommand(sql, tx.Connection,tx);
            cmd.Parameters.Add("@LogID", SqlDbType.VarChar).Value = log.LogID;
            cmd.Parameters.Add("@SupplyID", SqlDbType.VarChar).Value = log.SupplyID;
            cmd.Parameters.Add("@FacilitatorID", SqlDbType.VarChar).Value = log.FacilitatorID;
            cmd.Parameters.Add("@ActionType", SqlDbType.VarChar).Value = log.ActionType;
            cmd.Parameters.Add("@ActionID", SqlDbType.VarChar).Value = log.ActionID;
            cmd.Parameters.Add("@InitialQty", SqlDbType.Int).Value = log.InitialQty;
            cmd.Parameters.Add("@FinalQty", SqlDbType.Int).Value = log.FinalQty;
            cmd.Parameters.Add("@LogDate", SqlDbType.DateTime).Value = log.LogDate;
            
            cmd.ExecuteNonQuery();
            
        }
        public string GenerateLogID(SqlTransaction tx)
        {
            string? lastID = GetLastLogID(tx);

            if (string.IsNullOrWhiteSpace(lastID))
                return "L001";

            int numericPart = int.Parse(lastID[1..]);
            int next = numericPart + 1;

            return "L" + (next < 1000 ? next.ToString("D3") : next.ToString());
        }

        public string GetLastLogID(SqlTransaction tx)
        {
            var statement = "SELECT TOP 1 LogID FROM SupplyLogs ORDER BY LogID DESC;";
            SqlCommand command = new SqlCommand(statement, tx.Connection, tx);
            
            var result = command.ExecuteScalar();
            
            return result?.ToString() ?? string.Empty;
        }

        public DataTable FilterSupplyLogs(string search, string actionType, string date)
        {
            // null = ALL
            if (string.Equals(date, "Date", StringComparison.OrdinalIgnoreCase))
                date = null;

            if (string.Equals(actionType, "Type", StringComparison.OrdinalIgnoreCase))
                actionType = null;

            DateTime? fromDate = null;
            DateTime? toDateExclusive = null;

            if (date == "Today")
            {
                fromDate = DateTime.Today;
                toDateExclusive = DateTime.Today.AddDays(1);
            }
            else if (date == "Yesterday")
            {
                fromDate = DateTime.Today.AddDays(-1);
                toDateExclusive = DateTime.Today;
            }
            else if (date == "Last 7 Days")
            {
                fromDate = DateTime.Today.AddDays(-7);
                toDateExclusive = DateTime.Today.AddDays(1);
            }
            else if (date == "This Month")
            {
                fromDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                toDateExclusive = fromDate.Value.AddMonths(1);
            }
            // else: null => all dates

            const string sql = @"
SELECT 
    LogID,
    S.ItemName AS Supply,
    CONCAT(F.FirstName, ' ', F.LastName) AS Facilitator,
    ActionType,
    ActionID,
    InitialQty,
    FinalQty AS NewQty,
    LogDate AS Date
FROM SupplyLogs AS SL
JOIN SupplyInventory AS S 
    ON S.SupplyID = SL.SupplyID
JOIN Facilitator AS F 
    ON F.FacilitatorID = SL.FacilitatorID
WHERE
(
    @SearchBar IS NULL
    OR LogID LIKE '%' + @SearchBar + '%'
    OR S.ItemName LIKE '%' + @SearchBar + '%'
    OR CONCAT(F.FirstName, ' ', F.LastName) LIKE '%' + @SearchBar + '%'
    OR ActionID LIKE '%' + @SearchBar + '%'
)
AND
(
    @actionType IS NULL
    OR SL.ActionType = @actionType
)
AND
(
    @fromDate IS NULL
    OR SL.LogDate >= @fromDate
)
AND
(
    @toDate IS NULL
    OR SL.LogDate <= @toDate
);";

            using var cmd = new SqlCommand(sql, _connection);

            cmd.Parameters.Add("@SearchBar", SqlDbType.VarChar).Value =
                string.IsNullOrWhiteSpace(search) ? (object)DBNull.Value : search;

            cmd.Parameters.Add("@actionType", SqlDbType.VarChar).Value =
                string.IsNullOrWhiteSpace(actionType) ? (object)DBNull.Value : actionType;

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

    }
}
