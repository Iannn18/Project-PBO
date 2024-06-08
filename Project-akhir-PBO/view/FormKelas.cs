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
    public partial class FormKelas : Form
    {
        public FormKelas()
        {
            InitializeComponent();
        }

        // Fungsi untuk membuka form Formkelasguru dan mengirimkan nama kelas dan ID kelas
        private void OpenKelasGuruForm(string kelas, int idKelas)
        {
            // Membuat instance formkelasguru dengan parameter nama kelas dan ID kelas
            Formkelasguru formkelasguru = new Formkelasguru(kelas, idKelas);
            formkelasguru.FormClosed += Formkelasguru_FormClosed;
            formkelasguru.MdiParent = this.MdiParent; // Set MdiParent ke parent dari FormKelas
            formkelasguru.Dock = DockStyle.Fill;
            formkelasguru.Show();
            this.Close(); // Menutup form saat ini (FormKelas)
        }

        // Event handler untuk menutup form Formkelasguru
        private void Formkelasguru_FormClosed(object sender, FormClosedEventArgs e)
        {
            Formkelasguru formkelasguru = null;
        }

        // Event handler untuk tombol Kelas X A
        private void btnKelasXA_Click(object sender, EventArgs e)
        {
            OpenKelasGuruForm("Kelas X A", 1);
        }

        // Event handler untuk tombol Kelas X B
        private void btnKelasXB_Click(object sender, EventArgs e)
        {
            OpenKelasGuruForm("Kelas X B", 2);
        }

        // Event handler untuk tombol Kelas X C
        private void btnKelasXC_Click(object sender, EventArgs e)
        {
            OpenKelasGuruForm("Kelas X C", 3);
        }

        // Event handler untuk tombol Kelas X D
        private void btnKelasXD_Click(object sender, EventArgs e)
        {
            OpenKelasGuruForm("Kelas X D", 4);
        }

        // Event handler untuk tombol Kelas X E
        private void btnKelasXE_Click(object sender, EventArgs e)
        {
            OpenKelasGuruForm("Kelas X E", 5);
        }

        // Event handler untuk tombol Kelas X F
        private void btnKelasXF_Click(object sender, EventArgs e)
        {
            OpenKelasGuruForm("Kelas X F", 6);
        }

        // Event handler untuk tombol Kelas X G
        private void btnKelasXG_Click(object sender, EventArgs e)
        {
            OpenKelasGuruForm("Kelas X G", 7);
        }

        // Event handler untuk tombol Kelas X H
        private void btnKelasXH_Click(object sender, EventArgs e)
        {
            OpenKelasGuruForm("Kelas X H", 8);
        }

        // Event handler untuk tombol Kelas XI A
        private void btnKelasXIA_Click(object sender, EventArgs e)
        {
            OpenKelasGuruForm("Kelas XI A", 9);
        }

        // Event handler untuk tombol Kelas XI B
        private void btnKelasXIB_Click(object sender, EventArgs e)
        {
            OpenKelasGuruForm("Kelas XI B", 10);
        }

        // Event handler untuk tombol Kelas XI C
        private void btnKelasXIC_Click(object sender, EventArgs e)
        {
            OpenKelasGuruForm("Kelas XI C", 11);
        }

        // Event handler untuk tombol Kelas XI D
        private void btnKelasXID_Click(object sender, EventArgs e)
        {
            OpenKelasGuruForm("Kelas XI D", 12);
        }

        // Event handler untuk tombol Kelas XI E
        private void btnKelasXIE_Click(object sender, EventArgs e)
        {
            OpenKelasGuruForm("Kelas XI E", 13);
        }

        // Event handler untuk tombol Kelas XI F
        private void btnKelasXIF_Click(object sender, EventArgs e)
        {
            OpenKelasGuruForm("Kelas XI F", 14);
        }

        // Event handler untuk tombol Kelas XI G
        private void btnKelasXIG_Click(object sender, EventArgs e)
        {
            OpenKelasGuruForm("Kelas XI G", 15);
        }

        // Event handler untuk tombol Kelas XI H
        private void btnKelasXIH_Click(object sender, EventArgs e)
        {
            OpenKelasGuruForm("Kelas XI H", 16);
        }

        // Event handler untuk tombol Kelas XII A
        private void btnKelasXIIA_Click(object sender, EventArgs e)
        {
            OpenKelasGuruForm("Kelas XII A", 17);
        }

        // Event handler untuk tombol Kelas XII B
        private void btnKelasXIIB_Click(object sender, EventArgs e)
        {
            OpenKelasGuruForm("Kelas XII B", 18);
        }

        // Event handler untuk tombol Kelas XII C
        private void btnKelasXIIC_Click(object sender, EventArgs e)
        {
            OpenKelasGuruForm("Kelas XII C", 19);
        }

        // Event handler untuk tombol Kelas XII D
        private void btnKelasXIID_Click(object sender, EventArgs e)
        {
            OpenKelasGuruForm("Kelas XII D", 20);
        }

        // Event handler untuk tombol Kelas XII E
        private void btnKelasXIIE_Click(object sender, EventArgs e)
        {
            OpenKelasGuruForm("Kelas XII E", 21);
        }

        // Event handler untuk tombol Kelas XII F
        private void btnKelasXIIF_Click(object sender, EventArgs e)
        {
            OpenKelasGuruForm("Kelas XII F", 22);
        }

        // Event handler untuk tombol Kelas XII G
        private void btnKelasXIIG_Click(object sender, EventArgs e)
        {
            OpenKelasGuruForm("Kelas XII G", 23);
        }

        // Event handler untuk tombol Kelas XII H
        private void btnKelasXIIH_Click(object sender, EventArgs e)
        {
            OpenKelasGuruForm("Kelas XII H", 24);
        }

        private void FormKelas_Load(object sender, EventArgs e)
        {
            // Any initialization code if needed
        }
    }
}
