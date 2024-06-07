using Project_akhir_PBO.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_akhir_PBO
{
    public partial class FormPegawai : Form
    {
        private Pegawai_tambah pegawai_tambah;
        private Pegawai_edit formPegawai_edit;

        public FormPegawai()
        {
            InitializeComponent();
        }

        private void FormPegawai_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            string query = "SELECT nama_staff AS \"Nama Pegawai\", nuptk AS NUPTK, jabatan AS Jabatan FROM staff INNER JOIN jabatan ON staff.id_jabatan = jabatan.id_jabatan";
            DataTable dt = Database.queryExecutor(query);

            dataGridPegawai.Rows.Clear(); // Clear existing rows

            foreach (DataRow row in dt.Rows)
            {
                dataGridPegawai.Rows.Add(row["Nama Pegawai"], row["NUPTK"], row["Jabatan"]);
            }
        }

        private void tambahDataPegawai_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                if (pegawai_tambah == null)
                {
                    pegawai_tambah = new Pegawai_tambah(this);
                    pegawai_tambah.FormClosed += Pegawai_tambah_FormClosed;
                    pegawai_tambah.MdiParent = this.MdiParent; // Set MdiParent to the parent of FormPegawai
                    pegawai_tambah.Dock = DockStyle.Fill;
                    pegawai_tambah.Show();
                }
                else
                {
                    pegawai_tambah.Activate();
                }

                this.Hide(); // Hide the current form
            }
        }

        private void Pegawai_tambah_FormClosed(object sender, FormClosedEventArgs e)
        {
            pegawai_tambah = null;
            this.Show(); // Show the current form when Pegawai_tambah is closed
            LoadData(); // Reload the data to refresh the DataGridView
        }

        private void dataGridPegawai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void editPegawai_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                if (formPegawai_edit == null)
                {
                    formPegawai_edit = new Pegawai_edit();
                    formPegawai_edit.FormClosed += Pegawai_edit_FormClosed;
                    formPegawai_edit.MdiParent = this.MdiParent; // Set MdiParent to the parent of FormPegawai
                    formPegawai_edit.Dock = DockStyle.Fill;
                    formPegawai_edit.Show();
                }
                else
                {
                    formPegawai_edit.Activate();
                }

                this.Hide(); // Hide the current form
            }
        }

        private void Pegawai_edit_FormClosed(object sender, FormClosedEventArgs e)
        {
            formPegawai_edit = null;
            this.Show(); // Show the current form when Pegawai_edit is closed
            LoadData(); // Reload the data to refresh the DataGridView
        }
    }
}
