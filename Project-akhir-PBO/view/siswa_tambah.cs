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
        private Dictionary<TextBox, string> placeholderTexts = new Dictionary<TextBox, string>();
        FormSiswa formSiswa;

        public siswa_tambah()
        {
            InitializeComponent();
            this.siswatambah = siswatambah;
            InitializePlaceholderTexts();
        }
        private void InitializePlaceholderTexts()
        {
            // Define placeholder texts for each TextBox
            placeholderTexts[textBoxnamasiswa] = "Nama Siswa";
            placeholderTexts[textBoxnisnsiswa] = "NISN";
            placeholderTexts[textBoxtanggalsiswa] = "Tanggal Lahir(YYYY-MM-DD)";
            placeholderTexts[textBoxnohpsiswa] = "Nomor Telepon Siswa";
            placeholderTexts[textBoxlahirsiswa] = "Tempat Lahir Siswa";
            placeholderTexts[textBoxalamatsiswa] = "Alamat Siswa";

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

        private void FormPegawai_FormClosed(object? sender, FormClosedEventArgs e)
        {
            formSiswa = null;
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
                    formSiswa.FormClosed += FormPegawai_FormClosed;
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
    }
}
