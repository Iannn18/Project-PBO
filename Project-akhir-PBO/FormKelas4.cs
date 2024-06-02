using System;
using System.Windows.Forms;

namespace Project_akhir_PBO
{
    public partial class FormKelas4 : Form
    {
        public FormKelas4()
        {
            InitializeComponent();
            btnLogout.Click += BtnLogout_Click;
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            // Implementasi untuk logout, contoh:
            MessageBox.Show("You have logged out successfully.");
        }

        private void sidePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Tempat kode ini di dalam event handler atau metode yang memanggil form baru
            FormKelas3 regisMhs = new FormKelas3();
            this.Hide(); // Sembunyikan form saat ini
            // Daftarkan event FormClosed untuk menutup form saat ini setelah form baru ditutup
            regisMhs.FormClosed += (sender, args) => this.Close();
            // Tampilkan form baru sebagai dialog modal
            regisMhs.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Tempat kode ini di dalam event handler atau metode yang memanggil form baru
            FormKelas3 regisMhs = new FormKelas3();
            this.Hide(); // Sembunyikan form saat ini
            // Daftarkan event FormClosed untuk menutup form saat ini setelah form baru ditutup
            regisMhs.FormClosed += (sender, args) => this.Close();
            // Tampilkan form baru sebagai dialog modal
            regisMhs.ShowDialog();

        }

        private void btnKelas_Click(object sender, EventArgs e)
        {
            // Tempat kode ini di dalam event handler atau metode yang memanggil form baru
            FormKelassemua regisMhs = new FormKelassemua();
            this.Hide(); // Sembunyikan form saat ini
            // Daftarkan event FormClosed untuk menutup form saat ini setelah form baru ditutup
            regisMhs.FormClosed += (sender, args) => this.Close();
            // Tampilkan form baru sebagai dialog modal
            regisMhs.ShowDialog();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
