using System;
using System.Data;
using System.Windows.Forms;
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
    }
}
