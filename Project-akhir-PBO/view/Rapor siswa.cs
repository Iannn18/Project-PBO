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
            bahasa.Text = textBoxbahasa.Text;
            BIG.Text = textBoxBIG.Text;
            matWa.Text = textBoxmatWa.Text;
            matMin.Text = textBoxmatMin.Text;
            fisika.Text = textBoxfisika.Text;
            kimia.Text = textBoxkimia.Text;
            biologi.Text = textBoxbiologi.Text;
            pkn.Text = textBoxpkn.Text;
            pkwu.Text = textBoxpkwu.Text;
            seni.Text = textBoxseni.Text;
            penjas.Text = textBoxpenjas.Text;
            agama.Text = textBoxagama.Text;

            hadir.Text = textBoxhadir.Text;
            izin.Text = textBoxizin.Text;
            sakit.Text = textBoxsakit.Text;
            alpa.Text = textBoxAlpa.Text;
        }
    }
}
