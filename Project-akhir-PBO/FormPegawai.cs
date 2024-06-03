using Project_akhir_PBO.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public FormPegawai()
        {
            InitializeComponent();



        }

        private void FormPegawai_Load(object sender, EventArgs e)
        {

        }

        private void tambahDataPegawai_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string dataToShow = clickedButton.Text;

                if (pegawai_tambah == null)
                {
                    pegawai_tambah = new Pegawai_tambah();
                    pegawai_tambah.FormClosed += Pegawai_tambah_FormClosed;
                    pegawai_tambah.MdiParent = this.MdiParent; // Set MdiParent to the parent of FormKelas1
                    pegawai_tambah.Dock = DockStyle.Fill;
                    pegawai_tambah.Show();
                }
                else
                {
                    pegawai_tambah.Activate();
                }

                this.Close();
            }
        }

        private void Pegawai_tambah_FormClosed(object sender, FormClosedEventArgs e)
        {
            pegawai_tambah = null;
        }

        private void dataGridPegawai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
