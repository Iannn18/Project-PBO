using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Project_akhir_PBO.Model;
using Project_akhir_PBO.DB;
using System.Windows.Forms;

namespace Project_akhir_PBO.Context
{
    public class siswaContext
    {
        public List<Siswa>? daftarSiswa;

        public void loadSiswa()
        {
            this.daftarSiswa = new List<Siswa>();

            // Corrected SQL query to include 'id_kelas'
            string query = @"
                SELECT s.nisn, s.nama_siswa, k.id_kelas
                FROM siswa s
                JOIN kelas k ON s.id_kelas = k.id_kelas";

            DataTable dt = Database.queryExecutor(query);

            // Checking the DataTable content
            foreach (DataColumn column in dt.Columns)
            {
                Console.WriteLine(column.ColumnName);  // This will help confirm the actual columns returned
            }

            foreach (DataRow row in dt.Rows)
            {
                try
                {
                    // Parse the 'id_kelas' as an integer
                    int idKelas = int.Parse(row["id_kelas"].ToString());
                    daftarSiswa.Add(new Siswa(row["nisn"].ToString(), row["nama_siswa"].ToString(), idKelas));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error processing row: " + ex.Message);
                    // Handle exception, e.g., log the error or notify the user
                }
            }
        }
    }
}
