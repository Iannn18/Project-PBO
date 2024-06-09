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
            string query = $"select DISTINCT s.nama_staff from mapel m join staff s on s.nuptk = m.nuptk where m.nama_mapel = @mapel";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@mapel", NpgsqlDbType.Varchar){Value = mapel},
                };
            DataTable dataGuru = Database.queryExecutor(query, parameters);
            if (dataGuru.Rows.Count > 0)
            {
                return dataGuru.Rows[0]["nama_staff"].ToString();
            }
            else
            {
                return null; // or an appropriate default value
            }
        }
        public static DataTable getTugasByMapel()
        {
            string query = $"SELECT p.id_tugas, p.nama_tugas, p.deskripsi_tugas, p.kode_mapel, p.id_status FROM penugasan p JOIN mapel m ON m.kode_mapel = p.kode_mapel JOIN kelas k ON k.id_kelas = m.id_kelas WHERE m.nama_mapel = @mapel AND k.nama_kelas = @kelas ORDER BY p.nama_tugas;";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@mapel", NpgsqlDbType.Varchar){Value = MapelContext.cmapel},
                new NpgsqlParameter("@kelas", NpgsqlDbType.Varchar){Value = KelasContext.ckelas}
            };
            DataTable dataTugas = Database.queryExecutor(query,parameters); 
/*            DataTable kosoong = new DataTable();
*/            if (dataTugas.Rows.Count > 0)
            {
                return dataTugas;
            }
            else
            {
                return null;
            }
        }

    }

}
