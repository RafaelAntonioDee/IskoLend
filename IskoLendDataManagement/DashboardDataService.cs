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
    public class DashboardDataService
    {
        List<BorrowingRecord> supplies = new List<BorrowingRecord>();
        private string _connectionString = "Server=localhost\\SQLEXPRESS;Database=IskoLendDB;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
        private SqlConnection _connection;
        public DashboardDataService()
        {
            _connection = new SqlConnection(_connectionString);
        }

        public DataTable GetAllSummary()
        {
            var statement = "SELECT TOP(10)\r\n    BR.BorrowDate,\r\n    CONCAT(B.FirstName, ' ', B.LastName) AS BorrowerName,\r\n    SI.ItemName AS Item,\r\n    BD.BorrowedQty,\r\n    SC.StatusName AS StatusName\r\nFROM BorrowingRecord AS BR\r\nJOIN BorrowingDetails AS BD\r\n    ON BD.BorrowID = BR.BorrowID\r\nJOIN Borrower AS B\r\n    ON B.StudentID = BR.StudentID\r\nJOIN SupplyInventory AS SI\r\n    ON SI.SupplyID = BD.SupplyID\r\nLEFT JOIN StatusCode AS SC\r\n    ON SC.StatusID = BD.ItemStatusID;";
            SqlDataAdapter adapter = new SqlDataAdapter(statement, _connection);
            _connection.Open();
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            _connection.Close();
            return dataTable;
        }
    }
}
