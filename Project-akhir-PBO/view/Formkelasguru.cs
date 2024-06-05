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

namespace Project_akhir_PBO
{
    public partial class Formkelasguru : Form
    {
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
    }
}
