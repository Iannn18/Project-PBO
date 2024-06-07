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
    internal class JabatanContext
    {
        private static string table = "jabatan";

        public static DataTable all()
        {
            string query = $"SELECT * FROM {table}";
            DataTable dataJabatan = Database.queryExecutor(query);
            return dataJabatan;
        }

        public static DataTable show(int id)
        {
            string query = $"SELECT * FROM {table} WHERE id_jabatan = @id";
            NpgsqlParameter[] parameters =
            {
            new NpgsqlParameter("@id", NpgsqlDbType.Integer){Value = id},
        };
            DataTable dataJabatan = Database.queryExecutor(query, parameters);
            return dataJabatan;
        }

        public static void store(Jabatan jabatanBaru)
        {
            string query = $"INSERT INTO {table}(jabatan, deskripsi) VALUES(@jabatan, @deskripsi)";
            NpgsqlParameter[] parameters =
            {
            new NpgsqlParameter("@jabatan", NpgsqlDbType.Varchar){Value = jabatanBaru.jabatan},
            new NpgsqlParameter("@deskripsi", NpgsqlDbType.Varchar){Value = jabatanBaru.Deskripsi},
        };
            Database.commandExecutor(query, parameters);
        }

        public static void destroy(int id)
        {
            string query = $"DELETE FROM {table} WHERE id_jabatan = @id";
            NpgsqlParameter[] parameters =
            {
            new NpgsqlParameter("@id", NpgsqlDbType.Integer){Value = id},
        };
            Database.commandExecutor(query, parameters);
        }

        public static void update(Jabatan jabatanEdit)
        {
            string query = $"UPDATE {table} SET jabatan = @jabatan, deskripsi = @deskripsi WHERE id_jabatan = @id";
            NpgsqlParameter[] parameters =
            {
            new NpgsqlParameter("@jabatan", NpgsqlDbType.Varchar){Value = jabatanEdit.jabatan},
            new NpgsqlParameter("@deskripsi", NpgsqlDbType.Varchar){Value = jabatanEdit.Deskripsi},
            new NpgsqlParameter("@id", NpgsqlDbType.Integer){Value = jabatanEdit.Id_Jabatan},
        };
            Database.commandExecutor(query, parameters);
        }
    }

}
