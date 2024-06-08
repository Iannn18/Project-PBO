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
    internal class PenugasanContext
    {
        private static string table = "penugasan";

        public static DataTable all()
        {
            string query = $"SELECT * FROM {table}";
            DataTable dataPenugasan = Database.queryExecutor(query);
            return dataPenugasan;
        }

        public static DataTable show(int id)
        {
            string query = $"SELECT * FROM {table} WHERE id_tugas = @id";
            NpgsqlParameter[] parameters =
            {
            new NpgsqlParameter("@id", NpgsqlDbType.Integer){Value = id},
        };
            DataTable dataPenugasan = Database.queryExecutor(query, parameters);
            return dataPenugasan;
        }

        public static void store(Penugasan penugasanBaru)
        {
            string query = $"INSERT INTO {table}(nama_tugas, deskripsi_tugas, kode_mapel, id_status) VALUES(@nama_tugas, @deskripsi_tugas, @kode_mapel, @id_status)";
            NpgsqlParameter[] parameters =
            {
            new NpgsqlParameter("@nama_tugas", NpgsqlDbType.Varchar){Value = penugasanBaru.Nama_Tugas},
            new NpgsqlParameter("@deskripsi_tugas", NpgsqlDbType.Varchar){Value = penugasanBaru.Deskripsi_Tugas},
            new NpgsqlParameter("@kode_mapel", NpgsqlDbType.Integer){Value = penugasanBaru.Kode_Mapel},
            new NpgsqlParameter("@id_status", NpgsqlDbType.Integer){Value = penugasanBaru.Id_Status},
        };
            Database.commandExecutor(query, parameters);
        }

        public static void destroy(int id)
        {
            string query = $"DELETE FROM {table} WHERE id_tugas = @id";
            NpgsqlParameter[] parameters =
            {
            new NpgsqlParameter("@id", NpgsqlDbType.Integer){Value = id},
        };
            Database.commandExecutor(query, parameters);
        }

        public static void update(Penugasan penugasanEdit)
        {
            string query = $"UPDATE {table} SET nama_tugas = @nama_tugas, deskripsi_tugas = @deskripsi_tugas, kode_mapel = @kode_mapel, id_status = @id_status WHERE id_tugas = @id";
            NpgsqlParameter[] parameters =
            {
            new NpgsqlParameter("@nama_tugas", NpgsqlDbType.Varchar){Value = penugasanEdit.Nama_Tugas},
            new NpgsqlParameter("@deskripsi_tugas", NpgsqlDbType.Varchar){Value = penugasanEdit.Deskripsi_Tugas},
            new NpgsqlParameter("@kode_mapel", NpgsqlDbType.Integer){Value = penugasanEdit.Kode_Mapel},
            new NpgsqlParameter("@id_status", NpgsqlDbType.Integer){Value = penugasanEdit.Id_Status},
            new NpgsqlParameter("@id", NpgsqlDbType.Integer){Value = penugasanEdit.Id_Tugas},
        };
            Database.commandExecutor(query, parameters);
        }

        public static string getGuru(string mapel)
        {
            string query = $"select staff.nama_staff from penugasan join mapel on mapel.kode_mapel = penugasan.kode_mapel join staff on staff.nuptk = mapel.nuptk where mapel.nama_mapel = @mapel";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@mapel", NpgsqlDbType.Varchar){Value = mapel},
                };
            DataTable dataGuru = Database.queryExecutor(query, parameters);
            return dataGuru.Rows[0]["nama_staff"].ToString();
        }

    }

}
