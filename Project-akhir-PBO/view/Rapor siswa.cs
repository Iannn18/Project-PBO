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
    public partial class Rapor_siswa : Form
    {
        EditRaporSiswa editRaporSiswa;
        public Rapor_siswa()
        {
            InitializeComponent();
        }

        private void Rapor_siswa_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditData_Click(object sender, EventArgs e)
        {
            tboxBindo.ReadOnly = false;
            tboxNilaiInggris.ReadOnly = false;
            tboxNilaiMtkWajib.ReadOnly = false;
            tboxNilaiMtkMinat.ReadOnly = false;
            tboxNilaiFisika.ReadOnly = false;
            tboxNilaiKimia.ReadOnly = false;
            txboxNilaiBiologi.ReadOnly = false;
            tboxNilaiAgama.ReadOnly = false;
            tboxNilaiPPKN.ReadOnly = false;
            tboxNilaiPKWU.ReadOnly = false;
            tboxNilaiSeni.ReadOnly = false;
            tboxNilaiJasmani.ReadOnly = false;
            tboxHadir.ReadOnly = false;
            tboxIzin.ReadOnly = false;
            tboxSakit.ReadOnly = false;
            tboxAlpa.ReadOnly = false;
        }

        private void EditRaporSiswa_FormClosed(object? sender, FormClosedEventArgs e)
        {
            editRaporSiswa = null;
        }

        private void textBoxbahasa_TextChanged(object sender, EventArgs e)
        {

        }

        private void bahasa_Click(object sender, EventArgs e)
        {

        }

        private void BIG_Click(object sender, EventArgs e)
        {

        }

        private void matMin_Click(object sender, EventArgs e)
        {

        }


        private void tboxBindo_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tboxNilaiInggris_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tboxNilaiMtkWajib_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tboxNilaiMtkMinat_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tboxNilaiFisika_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tboxNilaiKimia_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txboxNilaiBiologi_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tboxNilaiPPKN_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tboxNilaiPKWU_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tboxNilaiSeni_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tboxNilaiAgama_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tboxNilaiJasmani_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tboxHadir_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tboxIzin_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tboxSakit_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tboxAlpa_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            tboxBindo.ReadOnly = true;
            tboxNilaiInggris.ReadOnly = true;
            tboxNilaiMtkWajib.ReadOnly = true;
            tboxNilaiMtkMinat.ReadOnly = true;
            tboxNilaiFisika.ReadOnly = true;
            tboxNilaiKimia.ReadOnly = true;
            txboxNilaiBiologi.ReadOnly = true;
            tboxNilaiAgama.ReadOnly = true;
            tboxNilaiPPKN.ReadOnly = true;
            tboxNilaiPKWU.ReadOnly = true;
            tboxNilaiSeni.ReadOnly = true;
            tboxNilaiJasmani.ReadOnly = true;
            tboxHadir.ReadOnly = true;
            tboxIzin.ReadOnly = true;
            tboxSakit.ReadOnly = true;
            tboxAlpa.ReadOnly = true;
        }

        private void tboxNilaiSenibudaya_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
