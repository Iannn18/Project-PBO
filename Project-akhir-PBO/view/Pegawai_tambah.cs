using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using Project_akhir_PBO.DB; // pastikan namespace untuk akses Database

namespace Project_akhir_PBO
{
    public partial class Pegawai_tambah : Form
    {
        private FormPegawai formPegawai;
        public Pegawai_tambah()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Apakah Anda yakin ingin menyimpan data ini?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    // Ambil nilai dari TextBox dan ComboBox
                    string nama = textBox2.Text;
                    string nip = textBox3.Text;
                    string pass = textBox4.Text;
                    int jabatan = comboBox1.SelectedItem.ToString() == "Staff" ? 4 : 1; // Staff = 4, Guru = 1

                    // Buat query untuk menyimpan data
                    string query = "INSERT INTO staff (nuptk, nama_staff, id_jabatan) VALUES (@nip, @nama, @jabatan)";

                    // Buat parameter untuk query
                    NpgsqlParameter[] parameters = new NpgsqlParameter[]
                    {
                        new NpgsqlParameter("@nip", nip),
                        new NpgsqlParameter("@nama", nama),
                        new NpgsqlParameter("@jabatan", jabatan)
                    };

                    // Eksekusi query
                    Database.commandExecutor(query, parameters);

                    MessageBox.Show("Data berhasil disimpan");

                    // Kembali ke form sebelumnya
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
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message);
                }
            }
        }

        private void FormPegawai_FormClosed(object sender, FormClosedEventArgs e)
        {
            formPegawai = null;
        }

        private void label5_Click(object sender, EventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
