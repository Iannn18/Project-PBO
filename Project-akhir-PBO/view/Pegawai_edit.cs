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
    public partial class Pegawai_edit : Form
    {
        private FormPegawai formPegawai;
        public Pegawai_edit()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pegawai_edit_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //jika tombol ini di klik , maka akan kembali ke form pegawai
            Button button = sender as Button;
            if (button != null)
            {
                string dataToShow = button.Text;

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

        private void FormPegawai_FormClosed(object? sender, FormClosedEventArgs e)
        {
            formPegawai = null;
        }
    }
}
