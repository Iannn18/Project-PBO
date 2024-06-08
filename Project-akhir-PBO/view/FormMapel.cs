using Project_akhir_PBO.Context;
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
        private void FormKelassemua_FormClosed(object sender, FormClosedEventArgs e)
        {
            formKelassemua = null;
        }

        private void FormMapel_Load(object sender, EventArgs e)
        {

        }
        private void HandleButtonClick(object sender, string kelas, string mapel)
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

        private void buttonbindo_Click(object sender, EventArgs e)
        {
            MapelContext.cmapel = buttonbindo.Text;
            HandleButtonClick(sender, KelasContext.ckelas, MapelContext.cmapel);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            MapelContext.cmapel = button2.Text;
            HandleButtonClick(sender, KelasContext.ckelas, MapelContext.cmapel);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MapelContext.cmapel = button4.Text;
            HandleButtonClick(sender, KelasContext.ckelas, MapelContext.cmapel);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MapelContext.cmapel = button3.Text;
            HandleButtonClick(sender, KelasContext.ckelas, MapelContext.cmapel);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MapelContext.cmapel = button5.Text;
            HandleButtonClick(sender, KelasContext.ckelas, MapelContext.cmapel);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MapelContext.cmapel = button10.Text;
            HandleButtonClick(sender, KelasContext.ckelas, MapelContext.cmapel);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MapelContext.cmapel = button9.Text;
            HandleButtonClick(sender, KelasContext.ckelas, MapelContext.cmapel);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MapelContext.cmapel = button8.Text;
            HandleButtonClick(sender, KelasContext.ckelas, MapelContext.cmapel);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MapelContext.cmapel = button7.Text;
            HandleButtonClick(sender, KelasContext.ckelas, MapelContext.cmapel);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MapelContext.cmapel = button6.Text;
            HandleButtonClick(sender, KelasContext.ckelas, MapelContext.cmapel);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MapelContext.cmapel = button13.Text;
            HandleButtonClick(sender, KelasContext.ckelas, MapelContext.cmapel);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MapelContext.cmapel = button12.Text;
            HandleButtonClick(sender, KelasContext.ckelas, MapelContext.cmapel);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MapelContext.cmapel = button11.Text;
            HandleButtonClick(sender, KelasContext.ckelas, MapelContext.cmapel);
        }
    }
}