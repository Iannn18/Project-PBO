using Project_akhir_PBO.Context;
using Project_akhir_PBO.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_akhir_PBO.view
{
    public partial class Form_siswa_edit : Form
    {
        private FormSiswa formSiswa;
        private Dictionary<TextBox, string> placeholderTexts = new Dictionary<TextBox, string>();
        public Form_siswa_edit()
        {
            InitializeComponent();
            InitializePlaceholderTexts();
        }
        private void InitializePlaceholderTexts()
        {
            // Define placeholder texts for each TextBox
            placeholderTexts[tBoxNamaSw] = "Nama Siswa";
            placeholderTexts[tBoxNISN] = "NISN";
            placeholderTexts[tBoxTglLahir] = "Tanggal Lahir(YYYY-MM-DD)";
            placeholderTexts[tBoxNoTelp] = "Nomor Telepon Siswa";
            placeholderTexts[tBoxTmptLahir] = "Tempat Lahir Siswa";
            placeholderTexts[tBoxAlamat] = "Alamat Siswa";

            // Initialize each TextBox with its placeholder text
            foreach (var textBox in placeholderTexts.Keys)
            {
                textBox.Text = placeholderTexts[textBox];
                textBox.ForeColor = Color.Gray;
                textBox.Enter += RemovePlaceholder;
                textBox.Leave += SetPlaceholder;
            }
        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Text == placeholderTexts[textBox])
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }

        private void SetPlaceholder(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = placeholderTexts[textBox];
                textBox.ForeColor = Color.Gray;
            }
        }
        private void Form_siswa_edit_Load(object sender, EventArgs e)
        {

        }

        private void tBoxNamaSw_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBoxNISN_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBoxTglLahir_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBoxNoTelp_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBoxTmptLahir_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBoxAlamat_TextChanged(object sender, EventArgs e)
        {

        }

        private void cBoxKelas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Class mappings dictionary
            Dictionary<string, int> classMappings = new Dictionary<string, int>
    {
        { "X-A", 1 }, { "X-B", 2 }, { "X-C", 3 }, { "X-D", 4 }, { "X-E", 5 }, { "X-F", 6 }, { "X-G", 7 }, { "X-H", 8 },
        { "XI-A", 9 }, { "XI-B", 10 }, { "XI-C", 11 }, { "XI-D", 12 }, { "XI-E", 13 }, { "XI-F", 14 }, { "XI-G", 15 }, { "XI-H", 16 },
        { "XII-A", 17 }, { "XII-B", 18 }, { "XII-C", 19 }, { "XII-D", 20 }, { "XII-E", 21 }, { "XII-F", 22 }, { "XII-G", 23 }, { "XII-H", 24 }
    };

            // Retrieve input data from the form fields.
            string nisn = tBoxNISN.Text;
            string namaSiswa = tBoxNamaSw.Text;
            DateTime tanggalLahir = DateTime.ParseExact(tBoxTglLahir.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            string nomorTelepon = tBoxNoTelp.Text;
            string tempatLahir = tBoxTmptLahir.Text;
            string alamat = tBoxAlamat.Text;
            int idKelas = classMappings[cBoxKelas.Text];
            //string className = cBoxKelas.Text;

            // Construct the confirmation message.
            string confirmationMessage = $"Apakah Anda ingin mengubah data siswa berikut?\n\n" +
                                         $"NISN: {nisn}\n" +
                                         $"Nama: {namaSiswa}\n" +
                                         $"Tanggal Lahir: {tanggalLahir.ToShortDateString()}\n" +
                                         $"No. Telepon: {nomorTelepon}\n" +
                                         $"Tempat Lahir: {tempatLahir}\n" +
                                         $"Alamat: {alamat}\n" +
                                         $"Kelas: {idKelas}";

            // Show a confirmation dialog.
            DialogResult dialogResult = MessageBox.Show(confirmationMessage, "Konfirmasi Perubahan Data Siswa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                // Create a new Siswa object with the updated data.
                Siswa updatedSiswa = new Siswa
                {
                    NISN = nisn,
                    Nama_Siswa = namaSiswa,
                    Tanggal_Lahir = tanggalLahir,
                    Nomor_Telepon_Siswa = nomorTelepon,
                    Tempat_Lahir = tempatLahir,
                    Alamat = alamat,
                    Id_Kelas = idKelas
                };

                try
                {
                    // Update the siswa in the database using the SiswaContext.
                    siswaContext.update(updatedSiswa);
                    MessageBox.Show("Data berhasil diubah!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Close the current form
                }
                catch (Exception ex)
                {
                    // Handle any errors that occur during the update operation.
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnKembali_Click(object sender, EventArgs e)
        {
            //jika tombol ini di klik , maka akan kembali ke form pegawai
            Button button = sender as Button;
            if (button != null)
            {
                string dataToShow = button.Text;

                if (formSiswa == null)
                {
                    formSiswa = new FormSiswa();
                    formSiswa.FormClosed += FormSiswa_FormClosed;
                    formSiswa.MdiParent = this.MdiParent; // Set MdiParent to the parent of FormKelas1
                    formSiswa.Dock = DockStyle.Fill;
                    formSiswa.Show();
                }
                else
                {
                    formSiswa.Activate();
                }

                this.Close();
            }
        }
        private void FormSiswa_FormClosed(object? sender, FormClosedEventArgs e)
        {
            formSiswa = null;
        }
    }
}
