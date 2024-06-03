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

        private void FormSiswaTambah_FormClosed(object? sender, FormClosedEventArgs e)
        {
            formSiswaTambah = null;
        }

        private void FormSiswa_Load(object sender, EventArgs e)
        {

        }
    }
}