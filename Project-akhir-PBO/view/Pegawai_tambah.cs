using System;
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
        private Dictionary<TextBox, string> placeholderTexts = new Dictionary<TextBox, string>();

        public Pegawai_tambah(FormPegawai formPegawai)
        {
            InitializeComponent();
            this.formPegawai = formPegawai;
            InitializePlaceholderTexts();
        }
        private void InitializePlaceholderTexts()
        {
            // Define placeholder texts for each TextBox
            placeholderTexts[tBoxNamaPegawai] = "Nama Pegawai";
            placeholderTexts[tBoxNUPTK] = "NUPTK";
            placeholderTexts[tBoxTglLahirPegawai] = "Tanggal Lahir(YYYY-MM-DD)";
            placeholderTexts[tBoxTelponPegawai] = "Nomor Telepon pegawai";
            placeholderTexts[tBoxTmptLahirPegawai] = "Tempat Lahir pegawai";
            placeholderTexts[tBoxAlamatPegawai] = "Alamat pegawai";

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

        private void FormPegawai_FormClosed(object? sender, FormClosedEventArgs e)
        {
            formPegawai = null;
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
    }
}
