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

namespace Project_akhir_PBO
{
    public partial class siswa_tambah : Form
    {
        private Dictionary<string, int> classMappings;
        private siswa_tambah siswatambah;

        public siswa_tambah()
        {
            InitializeComponent();
            this.siswatambah = siswatambah;
        }

        private void labelHalaman_Click(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {


        classMappings = new Dictionary<string, int>
        {
            { "X-A", 1 }, { "X-B", 2 }, { "X-C", 3 }, { "X-D", 4 }, { "X-E", 5 }, { "X-F", 6 }, { "X-G", 7 }, { "X-H", 8 },
            { "XI-A", 9 }, { "XI-B", 10 }, { "XI-C", 11 }, { "XI-D", 12 }, { "XI-E", 13 }, { "XI-F", 14 }, { "XI-G", 15 }, { "XI-H", 16 },
            { "XII-A", 17 }, { "XII-B", 18 }, { "XII-C", 19 }, { "XII-D", 20 }, { "XII-E", 21 }, { "XII-F", 22 }, { "XII-G", 23 }, { "XII-H", 24 }
        };
    // Retrieve input data from the form fields.
            string nisn = textBoxnisnsiswa.Text;
            string namaSiswa = textBoxnamasiswa.Text;
            DateTime tanggalLahir = DateTime.ParseExact(textBoxtanggalsiswa.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            string nomorTelepon = textBoxnohpsiswa.Text;
            string tempatLahir = textBoxlahirsiswa.Text;
            string alamat = textBoxalamatsiswa.Text;
/*            int idKelas = int.Parse(comboBoxkelassiswa.SelectedValue.ToString());
*/          


            int idKelas = classMappings[comboBoxkelassiswa.Text];
            // Get the class name for the id_kelas
            string className = comboBoxkelassiswa.Text;

            // Construct the confirmation message.
            string confirmationMessage = $"Apakah Anda ingin menambahkan siswa berikut?\n\n" +
                                         $"NISN: {nisn}\n" +
                                         $"Nama: {namaSiswa}\n" +
                                         $"Tanggal Lahir: {tanggalLahir.ToShortDateString()}\n" +
                                         $"No. Telepon: {nomorTelepon}\n" +
                                         $"Tempat Lahir: {tempatLahir}\n" +
                                         $"Alamat: {alamat}\n" +
                                         $"Kelas: {className}";

            // Show a confirmation dialog.
            DialogResult dialogResult = MessageBox.Show(confirmationMessage, "Konfirmasi Penambahan Siswa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                // Create a new Siswa object with the input data.
                Siswa newSiswa = new Siswa
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
                    // Insert the new siswa into the database using the SiswaContext.
                    siswaContext.store(newSiswa);
                    MessageBox.Show("Data berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Close the current form
                    //siswatambah.LoadData(); // Reload data in FormSiswa
                    //siswatambah.Show(); // Show the FormSiswa form
                }
                catch (Exception ex)
                {
                    // Handle any errors that occur during the insert operation.
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void siswa_tambah_Load(object sender, EventArgs e)
        {

        }

        private void labelTempatLahirSiswa_Click(object sender, EventArgs e)
        {

        }

        private void textBoxnamasiswa_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxnisnsiswa_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxtanggalsiswa_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxnohpsiswa_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxlahirsiswa_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxalamatsiswa_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxkelassiswa_SelectedIndexChanged(object sender, EventArgs e)
        {
    
        }

        private void labelNamaSiswa_Click(object sender, EventArgs e)
        {

        }

        private void labelNISNSiswa_Click(object sender, EventArgs e)
        {

        }

        private void labelTanggalLahirSiswa_Click(object sender, EventArgs e)
        {

        }

        private void labelNoTelpSiswa_Click(object sender, EventArgs e)
        {

        }

        private void labelAlamatSiswa_Click(object sender, EventArgs e)
        {

        }

        private void labelKelasSiswa_Click(object sender, EventArgs e)
        {

        }
    }
}
