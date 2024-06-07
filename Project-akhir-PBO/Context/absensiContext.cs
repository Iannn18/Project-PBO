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
    internal class AbsensiContext
    {
        private static string table = "absensi";

        public static DataTable all()
        {
            string query = $"SELECT * FROM {table}";
            DataTable dataAbsensi = Database.queryExecutor(query);
            return dataAbsensi;
        }

        public static DataTable show(int id)
        {
            string query = $"SELECT * FROM {table} WHERE id_absensi = @id";
            NpgsqlParameter[] parameters =
            {
            new NpgsqlParameter("@id", NpgsqlDbType.Integer){Value = id},
        };
            DataTable dataAbsensi = Database.queryExecutor(query, parameters);
            return dataAbsensi;
        }

        public static void store(Absensi absensiBaru)
        {
            string query = $"INSERT INTO {table}(waktu_hadir, nisn, id_status_absen) VALUES(@waktu_hadir, @nisn, @id_status_absen)";
            NpgsqlParameter[] parameters =
            {
            new NpgsqlParameter("@waktu_hadir", NpgsqlDbType.Date){Value = absensiBaru.Waktu_Hadir},
            new NpgsqlParameter("@nisn", NpgsqlDbType.Varchar){Value = absensiBaru.NISN},
            new NpgsqlParameter("@id_status_absen", NpgsqlDbType.Integer){Value = absensiBaru.Id_Status_Absen},
        };
            Database.commandExecutor(query, parameters);
        }

        public static void destroy(int id)
        {
            string query = $"DELETE FROM {table} WHERE id_absensi = @id";
            NpgsqlParameter[] parameters =
            {
            new NpgsqlParameter("@id", NpgsqlDbType.Integer){Value = id},
        };
            Database.commandExecutor(query, parameters);
        }

        public static void update(Absensi absensiEdit)
        {
            string query = $"UPDATE {table} SET waktu_hadir = @waktu_hadir, nisn = @nisn, id_status_absen = @id_status_absen WHERE id_absensi = @id";
            NpgsqlParameter[] parameters =
            {
            new NpgsqlParameter("@waktu_hadir", NpgsqlDbType.Date){Value = absensiEdit.Waktu_Hadir},
            new NpgsqlParameter("@nisn", NpgsqlDbType.Varchar){Value = absensiEdit.NISN},
            new NpgsqlParameter("@id_status_absen", NpgsqlDbType.Integer){Value = absensiEdit.Id_Status_Absen},
            new NpgsqlParameter("@id", NpgsqlDbType.Integer){Value = absensiEdit.Id_Absensi},
        };
            Database.commandExecutor(query, parameters);
        }
    }

}
