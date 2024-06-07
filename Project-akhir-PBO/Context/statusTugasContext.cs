using Npgsql;
using NpgsqlTypes;
using Project_akhir_PBO.DB;
using Project_akhir_PBO.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_akhir_PBO.Context
{
    internal class StatusTugasContext
    {
        private static string table = "status_tugas";

        public static DataTable all()
        {
            string query = $"SELECT * FROM {table}";
            DataTable dataStatusTugas = Database.queryExecutor(query);
            return dataStatusTugas;
        }

        public static DataTable show(int id)
        {
            string query = $"SELECT * FROM {table} WHERE id_status = @id";
            NpgsqlParameter[] parameters =
            {
            new NpgsqlParameter("@id", NpgsqlDbType.Integer){Value = id},
        };
            DataTable dataStatusTugas = Database.queryExecutor(query, parameters);
            return dataStatusTugas;
        }

        public static void store(Status_Tugas statusTugasBaru)
        {
            string query = $"INSERT INTO {table}(status_tugas) VALUES(@status_tugas)";
            NpgsqlParameter[] parameters =
            {
            new NpgsqlParameter("@status_tugas", NpgsqlDbType.Varchar){Value = statusTugasBaru.Status},
        };
            Database.commandExecutor(query, parameters);
        }

        public static void destroy(int id)
        {
            string query = $"DELETE FROM {table} WHERE id_status = @id";
            NpgsqlParameter[] parameters =
            {
            new NpgsqlParameter("@id", NpgsqlDbType.Integer){Value = id},
        };
            Database.commandExecutor(query, parameters);
        }

        public static void update(Status_Tugas statusTugasEdit)
        {
            string query = $"UPDATE {table} SET status_tugas = @status_tugas WHERE id_status = @id";
            NpgsqlParameter[] parameters =
            {
            new NpgsqlParameter("@status_tugas", NpgsqlDbType.Varchar){Value = statusTugasEdit.Status},
            new NpgsqlParameter("@id", NpgsqlDbType.Integer){Value = statusTugasEdit.Id_Status},
        };
            Database.commandExecutor(query, parameters);
        }
    }

}
