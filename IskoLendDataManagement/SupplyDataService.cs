using IskoLendModels;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
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
        public void Add(Supply supply)
        {
            supplies.Add(supply);
        }
        public List<Supply> RetrieveSupplies()
        {
            var statement = "Select * From dbo.SupplyInventory";
            SqlCommand selectCommand = new SqlCommand(statement, _connection);
            _connection.Open();
            SqlDataReader reader = selectCommand.ExecuteReader();
            var supplies = new List<Supply>();
            while (reader.Read())
            {
                Supply supply = new Supply
                {
                    SupplyID = reader.GetString(0),
                    SupplyName = reader.GetString(1),
                    CategoryID = reader.GetString(2),
                    Quantity = reader.GetInt32(3)
                };
                supplies.Add(supply);
            }
            _connection.Close();
            return supplies;
        }
        public Supply? GetSupplyByID(string supplyID)
        {
            return supplies.FirstOrDefault(s => s.SupplyID == supplyID);
        }
        public List<Supply> GetSuppliesByCategory(string categoryID)
        {
            return supplies.Where(s => s.CategoryID == categoryID).ToList();
        }

    }
}
