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
    public partial class Pegawai_tambah : Form
    {
        private FormPegawai formPegawai;
        public Pegawai_tambah()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Pegawai_tambah_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string dataToShow = clickedButton.Text;

                if (formPegawai == null)
                {
                    formPegawai = new FormPegawai();
                    formPegawai.FormClosed += FormPegawai_FormClosed;
                    formPegawai.MdiParent = this.MdiParent; // Set MdiParent to the parent of FormKelas1
                    formPegawai.Dock = DockStyle.Fill;
                    formPegawai.Show();
                }
                else
                {
                    formPegawai.Activate();
                }

                this.Close();
            }
        }

        private void FormPegawai_FormClosed(object sender, FormClosedEventArgs e)
        {
            formPegawai = null;
        }
    }
}
