using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using Project_akhir_PBO.DB;

namespace Project_akhir_PBO
{
    public partial class FormSiswa : Form
    {
        siswa_tambah formSiswaTambah;

        public FormSiswa()
        {
            InitializeComponent();
        }

        private void buttontambahsiswa_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                if (formSiswaTambah == null)
                {
                    formSiswaTambah = new siswa_tambah();
                    formSiswaTambah.FormClosed += FormSiswaTambah_FormClosed;
                    formSiswaTambah.MdiParent = this.MdiParent; // Set MdiParent to the parent of FormSiswaTambah
                    formSiswaTambah.Dock = DockStyle.Fill;
                    formSiswaTambah.Show();
                }
                else
                {
                    formSiswaTambah.Activate();
                }
                this.Close();
            }
        }

        private void FormSiswaTambah_FormClosed(object sender, FormClosedEventArgs e)
        {
            formSiswaTambah = null;
        }

        private void FormSiswa_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string query = @"
                SELECT s.nisn AS NISN, s.nama_siswa AS Nama, k.nama_kelas AS Kelas
                FROM siswa s
                JOIN kelas k ON s.id_kelas = k.id_kelas";

            DataTable dt = Database.queryExecutor(query);

            dataGridView1.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                dataGridView1.Rows.Add(row["NISN"], row["Nama"], row["Kelas"]);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string nisn = selectedRow.Cells["clmNISNSiswa"].Value.ToString();
                string nama = selectedRow.Cells["clmNamaSiswa"].Value.ToString();
                string kelas = selectedRow.Cells["clmKelas"].Value.ToString();

                DialogResult result = MessageBox.Show($"Apakah Anda yakin ingin menghapus siswa berikut?\n\nNISN: {nisn}\nNama: {nama}\nKelas: {kelas}", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string deleteQuery = "DELETE FROM siswa WHERE nisn = @nisn";
                    NpgsqlParameter[] parameters = new NpgsqlParameter[]
                    {
                        new NpgsqlParameter("@nisn", nisn)
                    };

                    try
                    {
                        Database.commandExecutor(deleteQuery, parameters);
                        MessageBox.Show("Data siswa berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Terjadi kesalahan saat menghapus data siswa: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Silakan pilih siswa yang ingin dihapus, Pastikan menekan bagian paling kiri dari baris data untuk MEMILIH.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
