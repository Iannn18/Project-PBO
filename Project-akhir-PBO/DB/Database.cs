using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;

namespace Project_akhir_PBO.DB
{
    internal class Database
    {
        private static readonly string DB_HOST = "pgfana-fanaiven.e.aivencloud.com";
        private static readonly string DB_DATABASE = "pbo";
        private static readonly string DB_USERNAME = "pgfana";
        private static readonly string DB_PASSWORD = "AVNS_LYMvQ33jMqpNeXW4Dhq";
        private static readonly string DB_PORT = "18704";
        
        private static string connString = $"Host={DB_HOST};Username={DB_USERNAME};Password={DB_PASSWORD};Database={DB_DATABASE};Port={DB_PORT};SSL Mode=Require;";
        private static NpgsqlConnection connection;
        private static NpgsqlCommand command;

        // Method open dan close Koneksi
        public static void openConnection()
        {
            connection = new NpgsqlConnection($"{connString}");
            connection.Open();
            command = new NpgsqlCommand();
            command.Connection = connection;
        }

        public static void closeConnection()
        {
            connection.Close();
            command.Parameters.Clear();
        }

        // Method Query dan Command Wrapper
        public static DataTable queryExecutor(string query, NpgsqlParameter[] parameters = null)
        {
            try
            {
                openConnection();
                DataTable dataTable = new DataTable();
                command.CommandText = query;
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                    command.Prepare();
                }
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(command);
                dataAdapter.Fill(dataTable);
                closeConnection();
                return dataTable;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static void commandExecutor(string query, NpgsqlParameter[] parameters = null)
        {
            try
            {
                openConnection();
                command.CommandText = query;
                command.Parameters.AddRange(parameters);
                command.Prepare();
                command.Parameters.Clear();
                command.ExecuteNonQuery();
                closeConnection();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
