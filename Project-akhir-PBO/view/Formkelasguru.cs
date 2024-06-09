using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using Project_akhir_PBO.DB;
using Project_akhir_PBO.view;

namespace Project_akhir_PBO
{
    public partial class Formkelasguru : Form
    {
        Rapor_siswa rapor_siswa;
        private string kelas;
        private int idKelas;

        public Formkelasguru(string kelas, int idKelas)
        {
            InitializeComponent();
            this.kelas = kelas;
            this.idKelas = idKelas;
            label1.Text = kelas;
        }

        private void Formkelasguru_Load(object sender, EventArgs e)
        {
            LoadSiswaData();
        }

        private void LoadSiswaData()
        {
            string query = @"
                SELECT s.nama_siswa AS NamaLengkap, sa.nama_status AS Status, s.nisn AS NISN
                FROM siswa s
                JOIN absensi a ON s.nisn = a.nisn
                JOIN status_absensi sa ON a.id_status_absen = sa.id_status_absen
                WHERE s.id_kelas = @idKelas";

            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@idKelas", idKelas)
            };

            DataTable dt = Database.queryExecutor(query, parameters);
            dataGridViewkelasguru.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                int index = dataGridViewkelasguru.Rows.Add();
                dataGridViewkelasguru.Rows[index].Cells["NamaLengkap"].Value = row["NamaLengkap"];
                dataGridViewkelasguru.Rows[index].Cells["Column1"].Value = row["Status"];
                dataGridViewkelasguru.Rows[index].Cells["ColumnNISN"].Value = row["NISN"]; // Add this line
            }

        }

        private void dataGridViewkelasguru_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional: add code to handle clicks on specific cells if needed
        }

        private void dataGridViewkelasguru_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewkelasguru.Columns["Column1"].Index)
            {
                string namaSiswa = dataGridViewkelasguru.Rows[e.RowIndex].Cells["NamaLengkap"].Value.ToString();
                string statusBaru = dataGridViewkelasguru.Rows[e.RowIndex].Cells["Column1"].Value.ToString();

                string query = @"
                    UPDATE absensi a
                    SET id_status_absen = sa.id_status_absen
                    FROM siswa s
                    JOIN status_absensi sa ON sa.nama_status = @statusBaru
                    WHERE s.nisn = a.nisn AND s.nama_siswa = @namaSiswa AND s.id_kelas = @idKelas";

                NpgsqlParameter[] parameters = new NpgsqlParameter[]
                {
                    new NpgsqlParameter("@statusBaru", statusBaru),
                    new NpgsqlParameter("@namaSiswa", namaSiswa),
                    new NpgsqlParameter("@idKelas", idKelas)
                };

                Database.commandExecutor(query, parameters);
            }
        }

        private void dataGridViewkelasguru_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Handle the data error
            e.ThrowException = false;
        }

        private void dataGridViewkelasguru_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pastikan klik bukan pada header atau kolom yang tidak valid
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Logika untuk menampilkan form Rapor_siswa
                if (rapor_siswa == null || rapor_siswa.IsDisposed)
                {
                    rapor_siswa = new Rapor_siswa();
                    rapor_siswa.FormClosed += Rapor_siswa_FormClosed;
                    rapor_siswa.MdiParent = this.MdiParent; // Set MdiParent to the parent of Formkelasguru
                    rapor_siswa.Dock = DockStyle.Fill;
                    rapor_siswa.Show();
                }
                else
                {
                    rapor_siswa.Activate();
                }
            }
        }

        private void Rapor_siswa_FormClosed(object sender, FormClosedEventArgs e)
        {
            rapor_siswa = null;
        }


    }
}
