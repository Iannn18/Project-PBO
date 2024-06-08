using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_akhir_PBO.view
{
    public partial class EditRaporSiswa : Form
    {
        Rapor_siswa raporSiswa;
        public EditRaporSiswa(Rapor_siswa raporSiswa)
        {
            InitializeComponent();
            this.raporSiswa = raporSiswa;
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            // Show the Rapor_siswa form if it's not already shown
            if (raporSiswa == null || raporSiswa.IsDisposed)
            {
                raporSiswa = new Rapor_siswa();
                raporSiswa.FormClosed += RaporSiswa_FormClosed;
                raporSiswa.MdiParent = this.MdiParent;
                raporSiswa.Dock = DockStyle.Fill;
            }

            raporSiswa.Show();
            this.Close();
        }


        private void RaporSiswa_FormClosed(object? sender, FormClosedEventArgs e)
        {
            raporSiswa = null;
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            
        }

        private void EditRaporSiswa_Load(object sender, EventArgs e)
        {

        }
    }
}
