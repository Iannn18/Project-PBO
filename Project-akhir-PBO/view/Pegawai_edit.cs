using Project_akhir_PBO.Context;
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

namespace Project_akhir_PBO
{
    public partial class Pegawai_edit : Form
    {
        private FormPegawai formPegawai;
        public Pegawai_edit()
        {
            InitializeComponent();
        }

        private void labelTglLahir_Click(object sender, EventArgs e)
        {

        }

        private void labelHalaman_Click(object sender, EventArgs e)
        {

        }

        private void panelEditPegawai_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pegawai_edit_Load(object sender, EventArgs e)
        {

        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            //jika tombol ini di klik , maka akan kembali ke form pegawai
            Button button = sender as Button;
            if (button != null)
            {
                string dataToShow = button.Text;

                if (formPegawai == null)
                {
                    formPegawai = new FormPegawai();
                    formPegawai.FormClosed += FormPegawai_FormClosed;
                    formPegawai.MdiParent = this.MdiParent; // Set MdiParent to the parent of FormKelas1
                    formPegawai.Dock = DockStyle.Fill;
                    formPegawai.Show();
                }
                else
                {
                    formPegawai.Activate();
                }

                this.Close();
            }

        }

        private void FormPegawai_FormClosed(object? sender, FormClosedEventArgs e)
        {
            formPegawai = null;
        }

        private void tBoxTmptLahirPgw_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelJabatan_Click(object sender, EventArgs e)
        {

        }

        private void tBoxNamaPegawai_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBoxNUPTK_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBoxTglLahirPgw_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBoxTeleponPgw_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBoxAlamatPgw_TextChanged(object sender, EventArgs e)
        {

        }

        private void cBoxJabatan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelNama_Click(object sender, EventArgs e)
        {

        }

        private void labelNUPTK_Click(object sender, EventArgs e)
        {

        }

        private void labelTelepon_Click(object sender, EventArgs e)
        {

        }

        private void labelTmptLahir_Click(object sender, EventArgs e)
        {

        }

        private void labelAlamat_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Retrieve input data from the form fields.
            string nuptk = tBoxNUPTK.Text;
            string namaStaff = tBoxNamaPegawai.Text;
            DateTime tanggalLahir = DateTime.Parse(tBoxTglLahirPgw.Text);
            string nomorTelepon = tBoxTeleponPgw.Text;
            string tempatLahir = tBoxTmptLahirPgw.Text;
            string alamat = tBoxAlamatPgw.Text;
            int idJabatan = cBoxJabatan.SelectedIndex + 1;

            // Construct the confirmation message.
            string confirmationMessage = $"Apakah Anda ingin mengubah data pegawai berikut?\n\n" +
                                         $"NUPTK: {nuptk}\n" +
                                         $"Nama: {namaStaff}\n" +
                                         $"Tanggal Lahir: {tanggalLahir.ToShortDateString()}\n" +
                                         $"No. Telepon: {nomorTelepon}\n" +
                                         $"Tempat Lahir: {tempatLahir}\n" +
                                         $"Alamat: {alamat}\n" +
                                         $"Jabatan: {cBoxJabatan.SelectedItem.ToString()}";

            // Show a confirmation dialog.
            DialogResult dialogResult = MessageBox.Show(confirmationMessage, "Konfirmasi Perubahan Data Pegawai", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                // Create a new Staff object with the updated data.
                Staff updatedStaff = new Staff
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
                    // Update the staff member in the database using the StaffContext.
                    StaffContext.update(updatedStaff);
                    MessageBox.Show("Data berhasil diubah!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Close the current form
                    formPegawai.LoadData(); // Reload data in FormPegawai
                    formPegawai.Show(); // Show the FormPegawai form
                }
                catch (Exception ex)
                {
                    // Handle any errors that occur during the update operation.
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
