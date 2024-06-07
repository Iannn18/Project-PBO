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
    public partial class FormKelas : Form
    {
        private Formkelasguru formkelasguru;
        public FormKelas()
        {
            InitializeComponent();
        }

        private void btnKelasXA_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string dataToShow = clickedButton.Text;

                if (formkelasguru == null)
                {
                    formkelasguru = new Formkelasguru();
                    formkelasguru.FormClosed += Formkelasguru_FormClosed;
                    formkelasguru.MdiParent = this.MdiParent; // Set MdiParent to the parent of FormKelas1
                    formkelasguru.Dock = DockStyle.Fill;
                    formkelasguru.Show();
                }
                else
                {
                    formkelasguru.Activate();
                }

                this.Close();
            }
        }
        private void Formkelasguru_FormClosed(object sender, FormClosedEventArgs e)
        {
            formkelasguru = null;
        }

        private void btnKelasXB_Click(object sender, EventArgs e)
        {

        }

        private void btnKelasXC_Click(object sender, EventArgs e)
        {

        }

        private void btnKelasXD_Click(object sender, EventArgs e)
        {

        }

        private void btnKelasXE_Click(object sender, EventArgs e)
        {

        }

        private void btnKelasXF_Click(object sender, EventArgs e)
        {

        }

        private void btnKelasXG_Click(object sender, EventArgs e)
        {

        }

        private void btnKelasXH_Click(object sender, EventArgs e)
        {

        }

        private void btnKelasXIA_Click(object sender, EventArgs e)
        {

        }

        private void btnKelasXIB_Click(object sender, EventArgs e)
        {

        }

        private void btnKelasXIC_Click(object sender, EventArgs e)
        {

        }

        private void btnKelasXID_Click(object sender, EventArgs e)
        {

        }

        private void btnKelasXIE_Click(object sender, EventArgs e)
        {

        }

        private void btnKelasXIF_Click(object sender, EventArgs e)
        {

        }

        private void btnKelasXIG_Click(object sender, EventArgs e)
        {

        }

        private void btnKelasXIH_Click(object sender, EventArgs e)
        {

        }

        private void btnKelasXIIA_Click(object sender, EventArgs e)
        {

        }

        private void btnKelasXIIB_Click(object sender, EventArgs e)
        {

        }

        private void btnKelasXIIC_Click(object sender, EventArgs e)
        {

        }

        private void btnKelasXIID_Click(object sender, EventArgs e)
        {

        }

        private void btnKelasXIIE_Click(object sender, EventArgs e)
        {

        }

        private void btnKelasXIIF_Click(object sender, EventArgs e)
        {

        }

        private void btnKelasXIIG_Click(object sender, EventArgs e)
        {

        }

        private void btnKelasXIIH_Click(object sender, EventArgs e)
        {

        }
    }
}
