using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_akhir_PBO.DB;
using Project_akhir_PBO.view;

namespace Project_akhir_PBO
{
    public partial class Formkelasguru : Form
    {
        private Rapor_siswa formRaporSiswa;
        public Formkelasguru()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewkelasguru_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Formkelasguru_Load(object sender, EventArgs e)
        {
            LoadSiswaData();
        }

        private void LoadSiswaData()
        {
            string query = "SELECT nama_siswa FROM siswa where id_kelas = 1";
            DataTable dt = Database.queryExecutor(query);
            // Mengatur DataSource dari DataGridView
            dataGridViewkelasguru.DataSource = dt;

            // Mengatur kolom nama siswa sesuai dengan DataPropertyName
            dataGridViewkelasguru.Columns["NamaLengkap"].DataPropertyName = "nama_siswa";

            // Menghapus kolom yang otomatis ditambahkan
            if (dataGridViewkelasguru.Columns.Contains("nama_siswa"))
            {
                dataGridViewkelasguru.Columns.Remove("nama_siswa");
            }
        }

        private void dataGridViewkelasguru_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Periksa jika kolom yang diklik adalah kolom yang diinginkan
                if (dataGridViewkelasguru.Columns[e.ColumnIndex].Name == "NamaLengkap")
                {
                    if (formRaporSiswa == null || formRaporSiswa.IsDisposed)
                    {
                        formRaporSiswa = new Rapor_siswa();
                        formRaporSiswa.FormClosed += Rapor_siswa_FormClosed;
                        formRaporSiswa.MdiParent = this.MdiParent; // Set MDI parent
                        formRaporSiswa.Dock = DockStyle.Fill;
                        formRaporSiswa.Show();
                    }
                    else
                    {
                        formRaporSiswa.Activate();
                    }
                }
            }
        }

        private void Rapor_siswa_FormClosed(object sender, FormClosedEventArgs e)
        {
     
            formRaporSiswa = null;
        }

    }
}
