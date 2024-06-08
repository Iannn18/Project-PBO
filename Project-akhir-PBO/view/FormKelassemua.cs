using System;
using System.Windows.Forms;

namespace Project_akhir_PBO
{
    public partial class FormKelassemua : Form
    {
        private Mapeltugas formMapeltugas;
        public FormKelassemua()
        {
            InitializeComponent();
        }

        private void buttonKelasXA_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string dataToShow = clickedButton.Text;

                if (formMapeltugas == null)
                {
                    formMapeltugas = new Mapeltugas("Kelas XA","Bahasa Indonesia");
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

        private void buttonKelasXB_Click(object sender, EventArgs e)
        {

        }

        private void buttonKelasXF_Click(object sender, EventArgs e)
        {

        }

        private void buttonKelasXC_Click(object sender, EventArgs e)
        {

        }

        private void buttonKelasXD_Click(object sender, EventArgs e)
        {

        }

        private void buttonKelasXH_Click(object sender, EventArgs e)
        {

        }

        private void buttonKelasXG_Click(object sender, EventArgs e)
        {

        }

        private void buttonKelasXE_Click(object sender, EventArgs e)
        {

        }

        private void buttonKelasXI_A_Click(object sender, EventArgs e)
        {

        }

        private void buttonKelasXI_B_Click(object sender, EventArgs e)
        {

        }

        private void buttonKelasXI_C_Click(object sender, EventArgs e)
        {

        }

        private void buttonKelasXI_D_Click(object sender, EventArgs e)
        {

        }

        private void buttonKelasXI_F_Click(object sender, EventArgs e)
        {

        }

        private void buttonKelasXI_G_Click(object sender, EventArgs e)
        {

        }

        private void buttonKelasXI_H_Click(object sender, EventArgs e)
        {

        }

        private void buttonKelasXII_B_Click(object sender, EventArgs e)
        {

        }

        private void buttonKelasXII_C_Click(object sender, EventArgs e)
        {

        }

        private void buttonKelasXII_D_Click(object sender, EventArgs e)
        {

        }

        private void buttonKelasXII_F_Click(object sender, EventArgs e)
        {

        }

        private void buttonKelasXII_G_Click(object sender, EventArgs e)
        {

        }

        private void buttonKelasXII_H_Click(object sender, EventArgs e)
        {

        }

        private void buttonKelasXI_E_Click(object sender, EventArgs e)
        {

        }

        private void buttonKelasXII_A_Click(object sender, EventArgs e)
        {

        }

        private void buttonKelasXII_E_Click(object sender, EventArgs e)
        {

        }

        private void FormKelassemua_Load(object sender, EventArgs e)
        {

        }
    }
}
