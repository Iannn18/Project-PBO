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
    internal class KelasContext
    {
        private static string table = "kelas";

        public static DataTable all()
        {
            string query = $"SELECT * FROM {table}";
            DataTable dataKelas = Database.queryExecutor(query);
            return dataKelas;
        }

        public static DataTable show(int id)
        {
            string query = $"SELECT * FROM {table} WHERE id_kelas = @id";
            NpgsqlParameter[] parameters =
            {
            new NpgsqlParameter("@id", NpgsqlDbType.Integer){Value = id},
        };
            DataTable dataKelas = Database.queryExecutor(query, parameters);
            return dataKelas;
        }

        public static void store(Kelas kelasBaru)
        {
            string query = $"INSERT INTO {table}(nama_kelas, nuptk) VALUES(@nama_kelas, @nuptk)";
            NpgsqlParameter[] parameters =
            {
            new NpgsqlParameter("@nama_kelas", NpgsqlDbType.Varchar){Value = kelasBaru.Nama_Kelas},
            new NpgsqlParameter("@nuptk", NpgsqlDbType.Varchar){Value = kelasBaru.NUPTK},
        };
            Database.commandExecutor(query, parameters);
        }

        public static void destroy(int id)
          {
            string query = $"DELETE FROM {table} WHERE id_kelas = @id";
            NpgsqlParameter[] parameters =
            {
            new NpgsqlParameter("@id", NpgsqlDbType.Integer){Value = id},
        };
            Database.commandExecutor(query, parameters);
        }

        public static void update(Kelas kelasEdit)
        {
            string query = $"UPDATE {table} SET nama_kelas = @nama_kelas, nuptk = @nuptk WHERE id_kelas = @id";
            NpgsqlParameter[] parameters =
            {
            new NpgsqlParameter("@nama_kelas", NpgsqlDbType.Varchar){Value = kelasEdit.Nama_Kelas},
            new NpgsqlParameter("@nuptk", NpgsqlDbType.Varchar){Value = kelasEdit.NUPTK},
            new NpgsqlParameter("@id", NpgsqlDbType.Integer){Value = kelasEdit.Id_Kelas},
        };
            Database.commandExecutor(query, parameters);
        }
    }

}
