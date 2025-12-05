using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using Microsoft.Extensions.Configuration; // Optional if we use config file, but for now hardcoded or simple string

namespace TorneoManager.Entity
{
    public class DBContext
    {
        // Connection string should be configured properly. 
        // For this example, I'll put a placeholder or a common local XE string.
        // The user might need to change this.
        private static string _connectionString = "User Id=system;Password=oracle;Data Source=localhost:1521/xepdb1;";

        public static void SetConnectionString(string connectionString)
        {
            _connectionString = connectionString;
        }

        public static OracleConnection GetConnection()
        {
            var connection = new OracleConnection(_connectionString);
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            return connection;
        }
    }
}
