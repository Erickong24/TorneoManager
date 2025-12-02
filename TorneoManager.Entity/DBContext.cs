using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;


namespace TorneoManager.Entity
{
    public class DBContext
    {
       
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
