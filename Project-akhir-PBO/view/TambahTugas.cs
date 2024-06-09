using Project_akhir_PBO.Context;
using Project_akhir_PBO.Model;
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
    public partial class TambahTugas : Form
    {
        private Mapeltugas formMapeltugas;
        string kelas;
        string mapel;
        public string Result { get; set; }

        public TambahTugas(string kelas, string mapel)
        {
            InitializeComponent();
            this.kelas = kelas;
            this.mapel = mapel;

        }


        private void TambahTugas_Load(object sender, EventArgs e)
        {

        }

        private void Mapeltugas_FormClosed(object sender, FormClosedEventArgs e)
        {
            formMapeltugas = null;
        }

        private void buttonBuatTugas_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Apakah anda yakin ingin membuat tugas ini?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Penugasan penugasanBaru = new Penugasan();
                penugasanBaru.Nama_Tugas = TextboxJudultugas.Text;
                penugasanBaru.Deskripsi_Tugas = textBoxTulispertanyaan.Text;
                penugasanBaru.Kode_Mapel = MapelContext.getIdByMapel();
                penugasanBaru.Id_Status = 1;
                PenugasanContext.store(penugasanBaru);
                MessageBox.Show("Tugas berhasil dibuat");
                this.Result = "Yes";
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Result = "No";
                this.Close();
                
            }


        }



        // Define the event handler outside of Mapeltugas_Load
        private void TextboxJudultugas_Enter(object sender, EventArgs e)
        {
            if (TextboxJudultugas.Text == " Judul")
            {
                TextboxJudultugas.Text = "";
                TextboxJudultugas.ForeColor = Color.Black;
            }

        }

        private void textBoxTulispertanyaan_Enter(object sender, EventArgs e)
        {
            if (textBoxTulispertanyaan.Text == "Deskripsi")
            {
                textBoxTulispertanyaan.Text = "";
                textBoxTulispertanyaan.ForeColor = Color.Black;
            }


        }

        private void textBoxTulispertanyaan_Leave(object sender, EventArgs e)
        {
            if(textBoxTulispertanyaan.Text == "")
            {
                textBoxTulispertanyaan.Text = "Deskripsi";
                textBoxTulispertanyaan.ForeColor = Color.Gray;
            }
        }

        private void TextboxJudultugas_Leave(object sender, EventArgs e)
        {
            if (TextboxJudultugas.Text == "")
            {
                TextboxJudultugas.Text = " Judul";
                TextboxJudultugas.ForeColor = Color.Gray;
            }
        }
    }
}

