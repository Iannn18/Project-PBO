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
    public partial class Dashboard : Form
    {
        FormDashboard formDashboard;
        FormKelas1 formKelas1;
        FormMapel formMapel;
        FormPegawai formPegawai;
        FormSiswa formSiswa;




        public Dashboard()
        {
            InitializeComponent();
        }

        bool GuruExpand = false;
        bool AdminExpand = false;
        public int tinggi = 100;

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnMapel_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e) 
        {
            if (formDashboard == null)
            {
                formDashboard = new FormDashboard();
                formDashboard.FormClosed += FormDashboard_FormClosed;
                formDashboard.MdiParent = this;
                formDashboard.Dock = DockStyle.Fill;
                formDashboard.Show();
            }
            else
            {
                formDashboard.Activate();
            }
        }

        private void FormDashboard_FormClosed(object? sender, FormClosedEventArgs e)
        {
            formDashboard = null;
        }

        private void btnGuru_Click(object sender, EventArgs e)
        {
            GuruTransition.Start();
        }

        private void GuruTransition_Tick(object sender, EventArgs e)
        {
            if (GuruExpand == false)
            {
                GuruContainer.Height += tinggi;
                GuruTransition.Stop();
                GuruExpand = true;
            }
            else
            {
                GuruContainer.Height -= tinggi;
                GuruTransition.Stop();
                GuruExpand = false;
            }
        }

        private void AdminTransition_Tick(object sender, EventArgs e)
        {
            if (AdminExpand == false)
            {
                AdminContainer.Height += tinggi;
                AdminTransition.Stop();
                AdminExpand = true;
            }
            else
            {
                AdminContainer.Height -= tinggi;
                AdminTransition.Stop();
                AdminExpand = false;
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminTransition.Start();
        }

        private void btnKelas_Click(object sender, EventArgs e)
        {
            if (formKelas1 == null)
            {
                formKelas1 = new FormKelas1();
                formKelas1.FormClosed += FormKelas1_FormClosed;
                formKelas1.MdiParent = this;
                formKelas1.Dock = DockStyle.Fill;
                formKelas1.Show();
            }
            else
            {
                formKelas1.Activate();
            }
        }

        private void FormKelas1_FormClosed(object? sender, FormClosedEventArgs e)
        {
            formKelas1 = null;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void btnMapel_Click_1(object sender, EventArgs e)
        {
            if (formMapel == null)
            {
                formMapel = new FormMapel();
                formMapel.FormClosed += FormMapel_FormClosed;
                formMapel.MdiParent = this;
                formMapel.Dock = DockStyle.Fill;
                formMapel.Show();
            }
            else
            {
                formMapel.Activate();
            }
        }

        private void FormMapel_FormClosed(object? sender, FormClosedEventArgs e)
        {
            formMapel = null;
        }

        private void btnPegawai_Click(object sender, EventArgs e)
        {
            if(formPegawai == null)
            {
                formPegawai = new FormPegawai();
                formPegawai.FormClosed += FormPegawai_FormClosed;
                formPegawai.MdiParent = this;
                formPegawai.Dock = DockStyle.Fill;
                formPegawai.Show();
            }
            else
            {
                formPegawai.Activate();
            }
        }

        private void FormPegawai_FormClosed(object? sender, FormClosedEventArgs e)
        {
            formPegawai = null;
        }
    }
}
