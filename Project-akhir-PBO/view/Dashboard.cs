﻿using Project_akhir_PBO.Context;
using Project_akhir_PBO.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Project_akhir_PBO.Context;

namespace Project_akhir_PBO
{
    public partial class Dashboard : Form
    {
        FormDashboard formDashboard;
        FormKelas formKelas;
        FormKelassemua formKelassemua;
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
            // Mencoba akses data akun
            // MessageBox.Show($"{userContext.akun!.NUPTK}");
            // MessageBox.Show($"{userContext.akun!.Nama_Staff}");
            // MessageBox.Show($"{userContext.akun!.Alamat}");
            // MessageBox.Show($"{userContext.akun!.Nomor_Telepon_Staff}");
            // MessageBox.Show($"{userContext.akun!.Id_Jabatan}");

            if (userContext.akun!.Id_Jabatan == 1)
            {

                AdminContainer.Controls.Add(btnAdmin);
                AdminContainer.Controls.Add(btnPegawai);
                AdminContainer.Controls.Add(btnSiswa);

                flowLayoutPanel1.Controls.Add(AdminContainer);

            } else if (userContext.akun.Id_Jabatan == 2) {

                GuruContainer.Controls.Add(btnGuru);
                GuruContainer.Controls.Add(btnKelas);
                GuruContainer.Controls.Add(btnMapel);


                flowLayoutPanel1.Controls.Add(GuruContainer);
            }

            flowLayoutPanel1.Controls.Add(btnLogOut);
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
            if (formKelas == null)
            {
                formKelas = new FormKelas();
                formKelas.FormClosed += FormKelas_FormClosed;
                formKelas.MdiParent = this;
                formKelas.Dock = DockStyle.Fill;
                formKelas.Show();
            }
            else
            {
                formKelas.Activate();
            }
        }

        private void FormKelas_FormClosed(object? sender, FormClosedEventArgs e)
        {
            formKelas = null;
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
            if (formPegawai == null)
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

        private void btnSiswa_Click(object sender, EventArgs e)
        {

        }


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSiswa_Click_1(object sender, EventArgs e)
        {
            if (formSiswa == null)
            {
                formSiswa = new FormSiswa();
                formSiswa.FormClosed += FormSiswa_FormClosed;
                formSiswa.MdiParent = this;
                formSiswa.Dock = DockStyle.Fill;
                formSiswa.Show();
            }
            else
            {
                formSiswa.Activate();
            }
        }

        private void FormSiswa_FormClosed(object? sender, FormClosedEventArgs e)
        {
            formSiswa = null;
        }
    }
}
