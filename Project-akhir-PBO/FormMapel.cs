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
    public partial class FormMapel : Form
    {
        private FormKelassemua formKelassemua;
        public FormMapel()
        {
            InitializeComponent();
        }

        private void buttonbindo_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string dataToShow = clickedButton.Text;

                if (formKelassemua == null)
                {
                    formKelassemua = new FormKelassemua();
                    formKelassemua.FormClosed += FormKelassemua_FormClosed;
                    formKelassemua.MdiParent = this.MdiParent; // Set MdiParent to the parent of FormKelas1
                    formKelassemua.Dock = DockStyle.Fill;
                    formKelassemua.Show();
                }
                else
                {
                    formKelassemua.Activate();
                }

                this.Close();
            }
        }

        private void FormKelassemua_FormClosed(object sender, FormClosedEventArgs e)
        {
            formKelassemua = null;
        }
    }
}