using Project_akhir_PBO.Context;
using Project_akhir_PBO.Model;
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
        private void FormKelassemua_Load(object sender, EventArgs e)
        {

        }
        private void HandleButtonClick(object sender, string kelas, string mapel)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string dataToShow = clickedButton.Text;

                if (formMapeltugas == null)
                {
                    formMapeltugas = new Mapeltugas(kelas, mapel);
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

        private void buttonKelasXA_Click(object sender, EventArgs e)
        {
            KelasContext.ckelas = "Kelas XA";
            HandleButtonClick(sender, KelasContext.ckelas, MapelContext.cmapel);
        }
        private void buttonKelasXB_Click(object sender, EventArgs e)
        {
            KelasContext.ckelas = "Kelas XB";
            HandleButtonClick(sender, KelasContext.ckelas, MapelContext.cmapel);
        }

        private void buttonKelasXF_Click(object sender, EventArgs e)
        {
            KelasContext.ckelas = "Kelas XF";
            HandleButtonClick(sender, KelasContext.ckelas, MapelContext.cmapel);

        }

        private void buttonKelasXC_Click(object sender, EventArgs e)
        {
            KelasContext.ckelas = "Kelas XC";
            HandleButtonClick(sender, KelasContext.ckelas, MapelContext.cmapel);
        }

        private void buttonKelasXD_Click(object sender, EventArgs e)
        {
            KelasContext.ckelas = "Kelas XD";
            HandleButtonClick(sender, KelasContext.ckelas, MapelContext.cmapel);
        }

        private void buttonKelasXH_Click(object sender, EventArgs e)
        {
            KelasContext.ckelas = "Kelas XH";
            HandleButtonClick(sender, KelasContext.ckelas, MapelContext.cmapel);
        }

        private void buttonKelasXG_Click(object sender, EventArgs e)
        {
            KelasContext.ckelas = "Kelas XG";
            HandleButtonClick(sender, KelasContext.ckelas, MapelContext.cmapel);
        }

        private void buttonKelasXE_Click(object sender, EventArgs e)
        {
            KelasContext.ckelas = "Kelas XE";
            HandleButtonClick(sender, KelasContext.ckelas, MapelContext.cmapel);
        }

        private void buttonKelasXI_A_Click(object sender, EventArgs e)
        {
            KelasContext.ckelas = "Kelas XI A";
            HandleButtonClick(sender, KelasContext.ckelas, MapelContext.cmapel);
        }

        private void buttonKelasXI_B_Click(object sender, EventArgs e)
        {
            KelasContext.ckelas = "Kelas XI B";
            HandleButtonClick(sender, KelasContext.ckelas, MapelContext.cmapel);
        }

        private void buttonKelasXI_C_Click(object sender, EventArgs e)
        {
            KelasContext.ckelas = "Kelas XI C";
            HandleButtonClick(sender, KelasContext.ckelas, MapelContext.cmapel);
        }

        private void buttonKelasXI_D_Click(object sender, EventArgs e)
        {
            KelasContext.ckelas = "Kelas XI D";
            HandleButtonClick(sender, KelasContext.ckelas, MapelContext.cmapel);
        }

        private void buttonKelasXI_F_Click(object sender, EventArgs e)
        {
            KelasContext.ckelas = "Kelas XI F";
            HandleButtonClick(sender, KelasContext.ckelas, MapelContext.cmapel);
        }

        private void buttonKelasXI_G_Click(object sender, EventArgs e)
        {
            KelasContext.ckelas = "Kelas XI G";
            HandleButtonClick(sender, KelasContext.ckelas, MapelContext.cmapel);
        }

        private void buttonKelasXI_H_Click(object sender, EventArgs e)
        {
            KelasContext.ckelas = "Kelas XI H";
            HandleButtonClick(sender, KelasContext.ckelas, MapelContext.cmapel);
        }

        private void buttonKelasXII_B_Click(object sender, EventArgs e)
        {
            KelasContext.ckelas = "Kelas XII B";
            HandleButtonClick(sender, KelasContext.ckelas, MapelContext.cmapel);
        }

        private void buttonKelasXII_C_Click(object sender, EventArgs e)
        {
            KelasContext.ckelas = "Kelas XII C";
            HandleButtonClick(sender, KelasContext.ckelas, MapelContext.cmapel);
        }

        private void buttonKelasXII_D_Click(object sender, EventArgs e)
        {
            KelasContext.ckelas = "Kelas XII D";
            HandleButtonClick(sender, KelasContext.ckelas, MapelContext.cmapel);
        }

        private void buttonKelasXII_F_Click(object sender, EventArgs e)
        {
            KelasContext.ckelas = "Kelas XII F";
            HandleButtonClick(sender, KelasContext.ckelas, MapelContext.cmapel);
        }

        private void buttonKelasXII_G_Click(object sender, EventArgs e)
        {
            KelasContext.ckelas = "Kelas XII G";
            HandleButtonClick(sender, KelasContext.ckelas, MapelContext.cmapel);
        }

        private void buttonKelasXII_H_Click(object sender, EventArgs e)
        {
            KelasContext.ckelas = "Kelas XII H";
            HandleButtonClick(sender, KelasContext.ckelas, MapelContext.cmapel);
        }

        private void buttonKelasXI_E_Click(object sender, EventArgs e)
        {
            KelasContext.ckelas = "Kelas XI E";
            HandleButtonClick(sender, KelasContext.ckelas, MapelContext.cmapel);
        }

        private void buttonKelasXII_A_Click(object sender, EventArgs e)
        {
            KelasContext.ckelas = "Kelas XII A";
            HandleButtonClick(sender, KelasContext.ckelas, MapelContext.cmapel);
        }

        private void buttonKelasXII_E_Click(object sender, EventArgs e)
        {
            KelasContext.ckelas = "Kelas XII E";
            HandleButtonClick(sender, KelasContext.ckelas, MapelContext.cmapel);
        }

    }
}
