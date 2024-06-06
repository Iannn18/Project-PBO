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
    public partial class Mapeltugas : Form
    {
        private TambahTugas formTambahTugas;
        public Mapeltugas()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Mapeltugas_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonTambahTugas_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string dataToShow = clickedButton.Text;

                if (formTambahTugas == null)
                {
                    formTambahTugas = new TambahTugas();
                    formTambahTugas.FormClosed += TambahTugas_FormClosed;
                    formTambahTugas.MdiParent = this.MdiParent; // Set MdiParent to the parent of FormKelas1
                    formTambahTugas.Dock = DockStyle.Fill;
                    formTambahTugas.Show();
                }
                else
                {
                    formTambahTugas.Activate();
                }

                this.Close();
            }
        }
        private void TambahTugas_FormClosed(object sender, FormClosedEventArgs e)
        {
            formTambahTugas = null;
        }


    }
}
