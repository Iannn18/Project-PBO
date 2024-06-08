using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Project_akhir_PBO.Model;
using Project_akhir_PBO.DB;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;

namespace Project_akhir_PBO.Context
{
    public class siswaContext
    {
        public List<Siswa>? daftarSiswa;

        public void loadSiswa()
        {
            this.daftarSiswa = new List<Siswa>();

            string query = @"
        SELECT s.nisn, s.nama_siswa, k.id_kelas, k.nama_kelas
        FROM siswa s
        JOIN kelas k ON s.id_kelas = k.id_kelas";

            DataTable dt = Database.queryExecutor(query);

            foreach (DataRow row in dt.Rows)
            {
                try
                {
                    int idKelas = int.Parse(row["id_kelas"].ToString());
                    string namaKelas = row["nama_kelas"].ToString();

                    Siswa siswa = new Siswa(row["nisn"].ToString(), row["nama_siswa"].ToString(), idKelas);
                    siswa.Kelas = new Kelas { Id_Kelas = idKelas, Nama_Kelas = namaKelas };

                    daftarSiswa.Add(siswa);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error processing row: " + ex.Message);
                }
            }
        }



        private static string table = "siswa";

        public static DataTable all()
        {
            string query = $"SELECT * FROM {table}";
            DataTable dataSiswa = Database.queryExecutor(query);
            return dataSiswa;
        }

        public static DataTable show(string nisn)
        {
            string query = $"SELECT * FROM {table} WHERE nisn = @nisn";
            NpgsqlParameter[] parameters =
            {
            new NpgsqlParameter("@nisn", NpgsqlDbType.Varchar){Value = nisn},
        };
            DataTable dataSiswa = Database.queryExecutor(query, parameters);
            return dataSiswa;
        }

        public static void store(Siswa siswaBaru)
        {
            string query = $"INSERT INTO {table}(nisn, nama_siswa, tanggal_lahir, nomor_telepon_siswa, tempat_lahir, alamat, id_kelas) VALUES(@nisn, @nama_siswa, @tanggal_lahir, @nomor_telepon_siswa, @tempat_lahir, @alamat, @id_kelas)";
            NpgsqlParameter[] parameters =
            {
            new NpgsqlParameter("@nisn", NpgsqlDbType.Varchar){Value = siswaBaru.NISN},
            new NpgsqlParameter("@nama_siswa", NpgsqlDbType.Varchar){Value = siswaBaru.Nama_Siswa},
            new NpgsqlParameter("@tanggal_lahir", NpgsqlDbType.Date){Value = siswaBaru.Tanggal_Lahir},
            new NpgsqlParameter("@nomor_telepon_siswa", NpgsqlDbType.Varchar){Value = siswaBaru.Nomor_Telepon_Siswa},
            new NpgsqlParameter("@tempat_lahir", NpgsqlDbType.Varchar){Value = siswaBaru.Tempat_Lahir},
            new NpgsqlParameter("@alamat", NpgsqlDbType.Varchar){Value = siswaBaru.Alamat},
            new NpgsqlParameter("@id_kelas", NpgsqlDbType.Integer){Value = siswaBaru.Id_Kelas},
        };
            Database.commandExecutor(query, parameters);
        }

        public static void destroy(string nisn)
        {
            string query = $"DELETE FROM {table} WHERE nisn = @nisn";
            NpgsqlParameter[] parameters =
            {
            new NpgsqlParameter("@nisn", NpgsqlDbType.Varchar){Value = nisn},
        };
            Database.commandExecutor(query, parameters);
        }

        public static void update(Siswa siswaEdit)
        {
            string query = $"UPDATE {table} SET nama_siswa = @nama_siswa, tanggal_lahir = @tanggal_lahir, nomor_telepon_siswa = @nomor_telepon_siswa, tempat_lahir = @tempat_lahir, alamat = @alamat, id_kelas = @id_kelas WHERE nisn = @nisn";
            NpgsqlParameter[] parameters =
            {
            new NpgsqlParameter("@nama_siswa", NpgsqlDbType.Varchar){Value = siswaEdit.Nama_Siswa},
            new NpgsqlParameter("@tanggal_lahir", NpgsqlDbType.Date){Value = siswaEdit.Tanggal_Lahir},
            new NpgsqlParameter("@nomor_telepon_siswa", NpgsqlDbType.Varchar){Value = siswaEdit.Nomor_Telepon_Siswa},
            new NpgsqlParameter("@tempat_lahir", NpgsqlDbType.Varchar){Value = siswaEdit.Tempat_Lahir},
            new NpgsqlParameter("@alamat", NpgsqlDbType.Varchar){Value = siswaEdit.Alamat},
            new NpgsqlParameter("@id_kelas", NpgsqlDbType.Integer){Value = siswaEdit.Id_Kelas},
            new NpgsqlParameter("@nisn", NpgsqlDbType.Varchar){Value = siswaEdit.NISN},
        };
            Database.commandExecutor(query, parameters);
        }
    }
}
