using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace ITSupport.Data
{
    public static class DatabaseHelper
    {
        private static readonly string ConnectionString;

        static DatabaseHelper()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        public static void TestConnection()
        {
            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception($"Ошибка подключения к БД: {ex.Message}");
                }
            }
        }

        public static int ExecuteNonQuery(string sql, object parameters = null)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                return connection.Execute(sql, parameters);
            }
        }

        public static T ExecuteScalar<T>(string sql, object parameters = null)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                return connection.ExecuteScalar<T>(sql, parameters);
            }
        }
    }
}