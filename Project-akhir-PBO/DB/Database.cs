using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_akhir_PBO.DB
{
	using Npgsql;
	using System;
	using System.Data;

	internal class Database
	{
		private static string connString = "Host=masfana-masfana.b.aivencloud.com;Port=109;Username=masfana;Password=AVNS_NqeUU18_unSmW9kkatm;DB=masfana;SSL Mode=Require;";
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


