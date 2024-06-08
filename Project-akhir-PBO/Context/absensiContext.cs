using Npgsql;
using NpgsqlTypes;
using Project_akhir_PBO.DB;
using Project_akhir_PBO.Model;
using System.Data;

namespace Project_akhir_PBO.Context
{
    // Interface for AbsensiContext
    public interface IAbsensiContext
    {
        DataTable All();
        DataTable Show(int id);
        void Store(Absensi absensiBaru);
        void Destroy(int id);
        void Update(Absensi absensiEdit);
    }

    // Implementation of the IAbsensiContext interface
    internal class AbsensiContext : IAbsensiContext
    {
        private static string table = "absensi";

        public DataTable All()
        {
            string query = $"SELECT * FROM {table}";
            DataTable dataAbsensi = Database.queryExecutor(query);
            return dataAbsensi;
        }

        public DataTable Show(int id)
        {
            string query = $"SELECT * FROM {table} WHERE id_absensi = @id";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", NpgsqlDbType.Integer) { Value = id },
            };
            DataTable dataAbsensi = Database.queryExecutor(query, parameters);
            return dataAbsensi;
        }

        public void Store(Absensi absensiBaru)
        {
            string query = $"INSERT INTO {table}(waktu_hadir, nisn, id_status_absen) VALUES(@waktu_hadir, @nisn, @id_status_absen)";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@waktu_hadir", NpgsqlDbType.Date) { Value = absensiBaru.Waktu_Hadir },
                new NpgsqlParameter("@nisn", NpgsqlDbType.Varchar) { Value = absensiBaru.NISN },
                new NpgsqlParameter("@id_status_absen", NpgsqlDbType.Integer) { Value = absensiBaru.Id_Status_Absen },
            };
            Database.commandExecutor(query, parameters);
        }

        public void Destroy(int id)
        {
            string query = $"DELETE FROM {table} WHERE id_absensi = @id";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", NpgsqlDbType.Integer) { Value = id },
            };
            Database.commandExecutor(query, parameters);
        }

        public void Update(Absensi absensiEdit)
        {
            string query = $"UPDATE {table} SET waktu_hadir = @waktu_hadir, nisn = @nisn, id_status_absen = @id_status_absen WHERE id_absensi = @id";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@waktu_hadir", NpgsqlDbType.Date) { Value = absensiEdit.Waktu_Hadir },
                new NpgsqlParameter("@nisn", NpgsqlDbType.Varchar) { Value = absensiEdit.NISN },
                new NpgsqlParameter("@id_status_absen", NpgsqlDbType.Integer) { Value = absensiEdit.Id_Status_Absen },
                new NpgsqlParameter("@id", NpgsqlDbType.Integer) { Value = absensiEdit.Id_Absensi },
            };
            Database.commandExecutor(query, parameters);
        }
    }
}
