using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using IskoLendModel;
using System.Xml.Linq;

namespace IskoLendDataManagement
{
    public class FacilitatorsDataService
    {
        private string _connectionString = "Server=localhost\\SQLEXPRESS;Database=IskoLendDB;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
        private SqlConnection _connection;
        public FacilitatorsDataService()
        {
            _connection = new SqlConnection(_connectionString);
        }
        public DataTable GetAllFacilitatorRecord()
        {
            var statement = "Select FacilitatorID ,D.Position ,FirstName ,LastName ,isActive From Facilitator AS F JOIN Designation AS D ON D.DesignationID = F.DesignationID;";
            SqlDataAdapter adapter = new SqlDataAdapter(statement, _connection);
            _connection.Open();
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            _connection.Close();
            return dataTable;
        }

        public void UpdateFacilitator(Facilitator faci)
        {
            var statement = @"UPDATE Facilitator SET DesignationID = @DesignationID, FirstName = @FirstName, LastName = @LastName, IsActive = @IsActive WHERE FacilitatorID = @FacilitatorID";

            SqlCommand cmd = new SqlCommand(statement, _connection);

            cmd.Parameters.AddWithValue("@DesignationID", faci.DesignationID);
            cmd.Parameters.AddWithValue("@FirstName", faci.FirstName);
            cmd.Parameters.AddWithValue("@LastName", faci.LastName);
            cmd.Parameters.Add("@IsActive", SqlDbType.Bit).Value = faci.IsActive;
            cmd.Parameters.AddWithValue("@FacilitatorID", faci.FacilitatorID);

            _connection.Open();
            cmd.ExecuteNonQuery();
            _connection.Close();
        }

        public Facilitator getFacilitator(string faciID)
        {
            const string sql = "SELECT * FROM Facilitator  WHERE FacilitatorID = @faciID;";

            using var cmd = new SqlCommand(sql, _connection);
            cmd.Parameters.AddWithValue("@faciID", faciID);

            _connection.Open();

            using var reader = cmd.ExecuteReader();

            Facilitator faci = null;

            if (reader.Read())
            {
                faci = new Facilitator
                {
                    FacilitatorID = reader["FacilitatorID"].ToString(),
                    DesignationID = reader["DesignationID"].ToString(),
                    FirstName = reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    IsActive = Convert.ToBoolean(reader["IsActive"])
                };
            }

            _connection.Close();

            return faci;
        }

        public string getDesignation(string designationID)
        {
            const string sql = "SELECT Position FROM Designation WHERE DesignationID = @designationID;";

            using var cmd = new SqlCommand(sql, _connection);
            cmd.Parameters.AddWithValue("@designationID", designationID);

            _connection.Open();
            object result = cmd.ExecuteScalar();
            _connection.Close();

            return result?.ToString();
        }

        public string getDesignationID(string position)
        {
            const string sql = "SELECT DesignationID FROM Designation WHERE Position = @position;";

            using var cmd = new SqlCommand(sql, _connection);
            cmd.Parameters.AddWithValue("@position", position);

            _connection.Open();
            object result = cmd.ExecuteScalar();
            _connection.Close();

            return result?.ToString();
        }

        public DataTable GetPositionsAvailable()
        {
            var statement = "SELECT * FROM Designation;";
            SqlDataAdapter adapter = new SqlDataAdapter(statement, _connection);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;
        }

        public string GenerateFaciID()
        {
            string? lastID = GetLastFaciID();

            if (string.IsNullOrWhiteSpace(lastID))
                return "F001";

            int numericPart = int.Parse(lastID[1..]);
            int next = numericPart + 1;

            return "F" + (next < 1000 ? next.ToString("D3") : next.ToString());
        }

        public string GetLastFaciID()
        {
            var statement = "SELECT TOP 1 FacilitatorID FROM Facilitator ORDER BY FacilitatorID DESC;";
            SqlCommand command = new SqlCommand(statement, _connection);
            _connection.Open();
            var result = command.ExecuteScalar();
            _connection.Close();
            return result?.ToString() ?? string.Empty;
        }

        public void AddFacilitator(Facilitator faci)
        {
            const string sql = @" INSERT INTO Facilitator (FacilitatorID, DesignationID, FirstName, LastName, IsActive) VALUES (@FaciID, @DesiID, @FName, @LName, @IsActive);";

            using var cmd = new SqlCommand(sql, _connection);

            cmd.Parameters.Add("@FaciID", SqlDbType.VarChar).Value = faci.FacilitatorID;
            cmd.Parameters.Add("@DesiID", SqlDbType.VarChar).Value = faci.DesignationID;
            cmd.Parameters.Add("@FName", SqlDbType.VarChar).Value = faci.FirstName;
            cmd.Parameters.Add("@LName", SqlDbType.VarChar).Value = faci.LastName;
            cmd.Parameters.Add("@IsActive", SqlDbType.Bit).Value = faci.IsActive;
            _connection.Open();
            cmd.ExecuteNonQuery();
            _connection.Close();
        }
        public void RemoveFacilitator(string facilitatorID)
        {
            var statement = $"DELETE FROM Facilitator WHERE FacilitatorID = '{facilitatorID}';";

            SqlCommand cmd = new SqlCommand(statement, _connection);

            _connection.Open();
            cmd.ExecuteNonQuery();
            _connection.Close();
        }

        public DataTable GetActiveFacilitators()
        {
            var statement = "Select CONCAT (FirstName,' ',LastName)as FacilitatorName from Facilitator WHERE IsActive = 1;";
            SqlDataAdapter adapter = new SqlDataAdapter(statement, _connection);
            _connection.Open();
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            _connection.Close();
            return dataTable;
        }
    }
}
