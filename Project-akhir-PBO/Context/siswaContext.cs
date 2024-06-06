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

            string query = @"
                SELECT *
                FROM siswa s
                JOIN kelas k ON s.id_kelas = k.id_kelas";

            DataTable dt = Database.queryExecutor(query);

            foreach (DataRow row in dt.Rows)
            {
                // dataGridView1.Rows.Add(row["NISN"], row["Nama"], row["Kelas"]);

                // daftarSiswa.Add(new Siswa(NISN: row["nisn"].ToString(), nama: row["nama_siswa"].ToString(), nama_kelas: row["nama_kelas"].ToString(), tanggal_lahir: new DateOnly(2015,03,05), tempat_lahir: row["tmpt"].ToString(), alamat: row["alamat"].ToString(), nomor_telepon: row["telepon"].ToString()));
                // daftarSiswa.Add(new Siswa(NISN: "3087", nama: "Edo Supardi", nama_kelas: "X-A", tanggal_lahir: new DateOnly(2015,03,05), tempat_lahir: "Jember", alamat: "Rambi", nomor_telepon: "08921321543"));
                daftarSiswa.Add(new Siswa(NISN: row["nisn"].ToString(), nama: row["nama_siswa"].ToString(), nama_kelas: row["nama_kelas"].ToString(), tanggal_lahir: new DateOnly(2015,03,05), tempat_lahir: row["tempat_lahir"].ToString(), alamat: row["alamat"].ToString(), nomor_telepon: row["nomor_telepon_siswa"].ToString()));

            }
        }
    }
}
