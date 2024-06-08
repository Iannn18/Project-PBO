using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_akhir_PBO.view
{
    public partial class Form_siswa_edit : Form
    {
        private FormSiswa formSiswa;
        public Form_siswa_edit()
        {
            InitializeComponent();
        }

        private void Form_siswa_edit_Load(object sender, EventArgs e)
        {

        }

        private void tBoxNamaSw_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBoxNISN_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBoxTglLahir_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBoxNoTelp_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBoxTmptLahir_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBoxAlamat_TextChanged(object sender, EventArgs e)
        {

        }

        private void cBoxKelas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            //jika tombol ini di klik , maka akan kembali ke form pegawai
            Button button = sender as Button;
            if (button != null)
            {
                string dataToShow = button.Text;

                if (formSiswa == null)
                {
                    formSiswa = new FormSiswa();
                    formSiswa.FormClosed += FormSiswa_FormClosed;
                    formSiswa.MdiParent = this.MdiParent; // Set MdiParent to the parent of FormKelas1
                    formSiswa.Dock = DockStyle.Fill;
                    formSiswa.Show();
                }
                else
                {
                    formSiswa.Activate();
                }

                this.Close();
            }
        }
        private void FormSiswa_FormClosed(object? sender, FormClosedEventArgs e)
        {
            formSiswa = null;
        }
    }
}
