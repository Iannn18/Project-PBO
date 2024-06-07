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
    internal class MapelContext
    {
        private static string table = "mapel";

        public static DataTable all()
        {
            string query = $"SELECT * FROM {table}";
            DataTable dataMapel = Database.queryExecutor(query);
            return dataMapel;
        }

        public static DataTable show(int kodeMapel)
        {
            string query = $"SELECT * FROM {table} WHERE kode_mapel = @kode_mapel";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@kode_mapel", NpgsqlDbType.Integer){Value = kodeMapel},
            };
            DataTable dataMapel = Database.queryExecutor(query, parameters);
            return dataMapel;
        }

        public static void store(Mapel mapelBaru)
        {
            string query = $"INSERT INTO {table}(nama_mapel, deskripsi_mapel, id_kelas, nuptk) VALUES(@nama_mapel, @deskripsi_mapel, @id_kelas, @nuptk)";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nama_mapel", NpgsqlDbType.Varchar){Value = mapelBaru.Nama_Mapel},
                new NpgsqlParameter("@deskripsi_mapel", NpgsqlDbType.Varchar){Value = mapelBaru.Deskripsi_Mapel},
                new NpgsqlParameter("@id_kelas", NpgsqlDbType.Integer){Value = mapelBaru.Id_Kelas},
                new NpgsqlParameter("@nuptk", NpgsqlDbType.Varchar){Value = mapelBaru.NUPTK},
            };
            Database.commandExecutor(query, parameters);
        }

        public static void destroy(int kodeMapel)
        {
            string query = $"DELETE FROM {table} WHERE kode_mapel = @kode_mapel";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@kode_mapel", NpgsqlDbType.Integer){Value = kodeMapel},
            };
            Database.commandExecutor(query, parameters);
        }

        public static void update(Mapel mapelEdit)
        {
            string query = $"UPDATE {table} SET nama_mapel = @nama_mapel, deskripsi_mapel = @deskripsi_mapel, id_kelas = @id_kelas, nuptk = @nuptk WHERE kode_mapel = @kode_mapel";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nama_mapel", NpgsqlDbType.Varchar){Value = mapelEdit.Nama_Mapel},
                new NpgsqlParameter("@deskripsi_mapel", NpgsqlDbType.Varchar){Value = mapelEdit.Deskripsi_Mapel},
                new NpgsqlParameter("@id_kelas", NpgsqlDbType.Integer){Value = mapelEdit.Id_Kelas},
                new NpgsqlParameter("@nuptk", NpgsqlDbType.Varchar){Value = mapelEdit.NUPTK},
                new NpgsqlParameter("@kode_mapel", NpgsqlDbType.Integer){Value = mapelEdit.Kode_Mapel},
            };
            Database.commandExecutor(query, parameters);
        }
    }
}
