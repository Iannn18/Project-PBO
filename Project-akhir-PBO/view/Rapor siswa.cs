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
    public partial class Rapor_siswa : Form
    {
        EditRaporSiswa editRaporSiswa;
        public Rapor_siswa()
        {
            InitializeComponent();
        }

        private void Rapor_siswa_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                if (editRaporSiswa == null)
                {
                    editRaporSiswa = new EditRaporSiswa(this);
                    editRaporSiswa.FormClosed += EditRaporSiswa_FormClosed;
                    editRaporSiswa.MdiParent = this.MdiParent;
                    editRaporSiswa.Dock = DockStyle.Fill;
                    editRaporSiswa.Show();
                }
                else
                {
                    editRaporSiswa.Activate();
                }

                this.Hide();
            }
            //bahasa.Text = textBoxbahasa.Text;
        }

        private void EditRaporSiswa_FormClosed(object? sender, FormClosedEventArgs e)
        {
            editRaporSiswa = null;
        }

        private void textBoxbahasa_TextChanged(object sender, EventArgs e)
        {

        }

        private void bahasa_Click(object sender, EventArgs e)
        {

        }

        private void BIG_Click(object sender, EventArgs e)
        {

        }

        private void matMin_Click(object sender, EventArgs e)
        {

        }
    }
}
