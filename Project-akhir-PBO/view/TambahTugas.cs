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
    public partial class TambahTugas : Form
    {
        private Mapeltugas formMapeltugas;
        public TambahTugas()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TambahTugas_Load(object sender, EventArgs e)
        {

        }

        private void buttonBatalbuattugas_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string dataToShow = clickedButton.Text;

                if (formMapeltugas == null)
                {
                    formMapeltugas = new Mapeltugas();
                    formMapeltugas.FormClosed += Mapeltugas_FormClosed;
                    formMapeltugas.MdiParent = this.MdiParent; // Set MdiParent to the parent of FormKelas1
                    formMapeltugas.Dock = DockStyle.Fill;
                    formMapeltugas.Show();
                }
                else
                {
                    formMapeltugas.Activate();
                }

                this.Close();
            }
        }
        private void Mapeltugas_FormClosed(object sender, FormClosedEventArgs e)
        {
            formMapeltugas = null;
        }
    }
}

