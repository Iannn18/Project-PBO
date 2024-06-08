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
    internal class StaffContext : Database
    {
        private static string table = "staff";

        public static DataTable all()
        {
            string query = $"SELECT * FROM {table}";
            DataTable dataStaff = Database.queryExecutor(query);
            return dataStaff;
        }

        public static DataTable show(string nuptk)
        {
            string query = $"SELECT * FROM {table} WHERE nuptk = @nuptk";
            NpgsqlParameter[] parameters =
            {
            new NpgsqlParameter("@nuptk", NpgsqlDbType.Varchar){Value = nuptk},
        };
            DataTable dataStaff = Database.queryExecutor(query, parameters);
            return dataStaff;
        }

        public static void store(Staff staffBaru)
        {
            string query = $"INSERT INTO {table}(nuptk, nama_staff, tanggal_lahir, nomor_telepon_staff, tempat_lahir, alamat, id_jabatan) VALUES(@nuptk, @nama_staff, @tanggal_lahir, @nomor_telepon_staff, @tempat_lahir, @alamat, @id_jabatan)";
            NpgsqlParameter[] parameters =
            {
            new NpgsqlParameter("@nuptk", NpgsqlDbType.Varchar){Value = staffBaru.NUPTK},
            new NpgsqlParameter("@nama_staff", NpgsqlDbType.Varchar){Value = staffBaru.Nama_Staff},
            new NpgsqlParameter("@tanggal_lahir", NpgsqlDbType.Date){Value = staffBaru.Tanggal_Lahir},
            new NpgsqlParameter("@nomor_telepon_staff", NpgsqlDbType.Varchar){Value = staffBaru.Nomor_Telepon_Staff},
            new NpgsqlParameter("@tempat_lahir", NpgsqlDbType.Varchar){Value = staffBaru.Tempat_Lahir},
            new NpgsqlParameter("@alamat", NpgsqlDbType.Varchar){Value = staffBaru.Alamat},
            new NpgsqlParameter("@id_jabatan", NpgsqlDbType.Integer){Value = staffBaru.Id_Jabatan},
        };
            Database.commandExecutor(query, parameters);
        }

        public static void destroy(string nuptk)
        {
            string query = $"DELETE FROM {table} WHERE nuptk = @nuptk";
            NpgsqlParameter[] parameters =
            {
            new NpgsqlParameter("@nuptk", NpgsqlDbType.Varchar){Value = nuptk},
        };
            Database.commandExecutor(query, parameters);
        }

        public static void update(Staff staffEdit)
        {
            string query = $"UPDATE {table} SET nama_staff = @nama_staff, tanggal_lahir = @tanggal_lahir, nomor_telepon_staff = @nomor_telepon_staff, tempat_lahir = @tempat_lahir, alamat = @alamat, id_jabatan = @id_jabatan WHERE nuptk = @nuptk";
            NpgsqlParameter[] parameters =
            {
            new NpgsqlParameter("@nama_staff", NpgsqlDbType.Varchar){Value = staffEdit.Nama_Staff},
            new NpgsqlParameter("@tanggal_lahir", NpgsqlDbType.Date){Value = staffEdit.Tanggal_Lahir},
            new NpgsqlParameter("@nomor_telepon_staff", NpgsqlDbType.Varchar){Value = staffEdit.Nomor_Telepon_Staff},
            new NpgsqlParameter("@tempat_lahir", NpgsqlDbType.Varchar){Value = staffEdit.Tempat_Lahir},
            new NpgsqlParameter("@alamat", NpgsqlDbType.Varchar){Value = staffEdit.Alamat},
            new NpgsqlParameter("@id_jabatan", NpgsqlDbType.Integer){Value = staffEdit.Id_Jabatan},
            new NpgsqlParameter("@nuptk", NpgsqlDbType.Varchar){Value = staffEdit.NUPTK},
        };
            Database.commandExecutor(query, parameters);
        }
        public static List<Jabatan> GetJabatanList()
        {
            List<Jabatan> jabatanList = new List<Jabatan>();

            try
            {
                string query = "SELECT * FROM jabatan";
                DataTable dataTable = Database.queryExecutor(query);

                foreach (DataRow row in dataTable.Rows)
                {
                    Jabatan jabatan = new Jabatan
                    {
                        Id_Jabatan = Convert.ToInt32(row["id_jabatan"]),
                        jabatan = row["nama_jabatan"].ToString(),
                        Deskripsi = row["deskripsi"].ToString()
                    };

                    jabatanList.Add(jabatan);
                }
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the fetch operation
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return jabatanList;
        }

    }

}
