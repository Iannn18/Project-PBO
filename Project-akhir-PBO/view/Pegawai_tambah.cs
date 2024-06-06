using System;
using System.Windows.Forms;
using Npgsql;
using Project_akhir_PBO.DB;

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Pegawai_tambah_Load(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nuptk = textBox3.Text;
            string namaStaff = textBox2.Text;
            DateTime tanggalLahir = DateTime.Parse(textBox4.Text);
            string nomorTelepon = textBox1.Text;
            string tempatLahir = textBox5.Text;
            string alamat = textBox6.Text;
            int idJabatan = comboBox1.SelectedIndex + 1;

            string confirmationMessage = $"Apakah Anda ingin menambahkan pegawai berikut?\n\n" +
                                         $"NUPTK: {nuptk}\n" +
                                         $"Nama: {namaStaff}\n" +
                                         $"Tanggal Lahir: {tanggalLahir.ToShortDateString()}\n" +
                                         $"No. Telepon: {nomorTelepon}\n" +
                                         $"Tempat Lahir: {tempatLahir}\n" +
                                         $"Alamat: {alamat}\n" +
                                         $"Jabatan: {comboBox1.SelectedItem.ToString()}";

            DialogResult dialogResult = MessageBox.Show(confirmationMessage, "Konfirmasi Penambahan Pegawai", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                string query = "INSERT INTO staff (nuptk, nama_staff, tanggal_lahir, nomor_telepon_staff, tempat_lahir, alamat, id_jabatan) VALUES (@nuptk, @nama_staff, @tanggal_lahir, @nomor_telepon_staff, @tempat_lahir, @alamat, @id_jabatan)";

                NpgsqlParameter[] parameters = new NpgsqlParameter[]
                {
                    new NpgsqlParameter("@nuptk", nuptk),
                    new NpgsqlParameter("@nama_staff", namaStaff),
                    new NpgsqlParameter("@tanggal_lahir", tanggalLahir),
                    new NpgsqlParameter("@nomor_telepon_staff", nomorTelepon),
                    new NpgsqlParameter("@tempat_lahir", tempatLahir),
                    new NpgsqlParameter("@alamat", alamat),
                    new NpgsqlParameter("@id_jabatan", idJabatan)
                };

                try
                {
                    Database.commandExecutor(query, parameters);
                    MessageBox.Show("Data berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Close the current form
                    formPegawai.LoadData(); // Reload data in FormPegawai
                    formPegawai.Show(); // Show the FormPegawai form
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
