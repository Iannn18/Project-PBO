﻿using System;
using System.Windows.Forms;
using Npgsql;
using Project_akhir_PBO.Context;
using Project_akhir_PBO.DB;
using Project_akhir_PBO.Model;

namespace Project_akhir_PBO
{
    public partial class Pegawai_tambah : Form
    {
        private FormPegawai formPegawai;

        public Pegawai_tambah(FormPegawai formPegawai)
        {
            InitializeComponent();
            this.formPegawai = formPegawai;
        }

        private void labelJudulHalaman_Paint(object sender, PaintEventArgs e)
        {
        }

        private void labelJudulHalaman_Click(object sender, EventArgs e)
        {
        }

        private void Pegawai_tambah_Load(object sender, EventArgs e)
        {

        }

        private void tBoxNamaPegawai_TextChanged(object sender, EventArgs e)
        {
        }

        private void tBoxNUPTK_TextChanged(object sender, EventArgs e)
        {
        }

        private void tBoxTglLahirPegawai_TextChanged(object sender, EventArgs e)
        {
        }

        private void tBoxTelponPegawai_TextChanged(object sender, EventArgs e)
        {
        }

        private void tBoxTmptLahirPegawai_TextChanged(object sender, EventArgs e)
        {
        }

        private void tBoxAlamatPegawai_TextChanged(object sender, EventArgs e)
        {
        }

        private void cBoxJabatan_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void btnSubmitPgw_Click(object sender, EventArgs e)
        {
            // Retrieve input data from the form fields.
            string nuptk = tBoxNUPTK.Text;
            string namaStaff = tBoxNamaPegawai.Text;
            DateTime tanggalLahir = DateTime.Parse(tBoxTglLahirPegawai.Text);
            string nomorTelepon = tBoxTelponPegawai.Text;
            string tempatLahir = tBoxTmptLahirPegawai.Text;
            string alamat = tBoxAlamatPegawai.Text;
            int idJabatan = cBoxJabatan.SelectedIndex + 1;

            // Construct the confirmation message.
            string confirmationMessage = $"Apakah Anda ingin menambahkan pegawai berikut?\n\n" +
                                         $"NUPTK: {nuptk}\n" +
                                         $"Nama: {namaStaff}\n" +
                                         $"Tanggal Lahir: {tanggalLahir.ToShortDateString()}\n" +
                                         $"No. Telepon: {nomorTelepon}\n" +
                                         $"Tempat Lahir: {tempatLahir}\n" +
                                         $"Alamat: {alamat}\n" +
                                         $"Jabatan: {cBoxJabatan.SelectedItem.ToString()}";

            // Show a confirmation dialog.
            DialogResult dialogResult = MessageBox.Show(confirmationMessage, "Konfirmasi Penambahan Pegawai", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                // Create a new Staff object with the input data.
                Staff newStaff = new Staff
                {
                    NUPTK = nuptk,
                    Nama_Staff = namaStaff,
                    Tanggal_Lahir = tanggalLahir,
                    Nomor_Telepon_Staff = nomorTelepon,
                    Tempat_Lahir = tempatLahir,
                    Alamat = alamat,
                    Id_Jabatan = idJabatan
                };

                try
                {
                    // Insert the new staff member into the database using the StaffContext.
                    StaffContext.store(newStaff);
                    MessageBox.Show("Data berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Close the current form
                    formPegawai.LoadData(); // Reload data in FormPegawai
                    formPegawai.Show(); // Show the FormPegawai form
                }
                catch (Exception ex)
                {
                    // Handle any errors that occur during the insert operation.
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
