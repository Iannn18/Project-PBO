using Project_akhir_PBO.Context;
using Project_akhir_PBO.view;
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
    public partial class Mapeltugas : Form
    {
        private TambahTugas formTambahTugas;
        string kelas;
        string mapel;
        bool isHapus = false;
        public Mapeltugas(string kelas, string mapel)
        {
            InitializeComponent();
            this.kelas = kelas;
            this.mapel = mapel;
        }

        // Define the event handler outside of Mapeltugas_Load
        private void ListTugasControll_Click(object sender, EventArgs e)
        {
            // Get the parent control of the sender and cast it to ListTugasControll
            ListTugasControll clickedControl = ((Control)sender).Parent as ListTugasControll;
            if (isHapus = true)
            {
                DialogResult dialogResult = MessageBox.Show("Apakah anda yakin ingin menghapus tugas ini?", "Konfirmasi", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    PenugasanContext.destroy(Convert.ToInt32(clickedControl.id));
                    MessageBox.Show("Tugas berhasil dihapus");
                    flowLayoutPanel1.Controls.Clear();
                    Mapeltugas_Load(sender, e);
                    btHapus_Click(null,null);
                }
                else if (dialogResult == DialogResult.No)
                {
                }
                else
                {
                    if (clickedControl != null)
                    {
                        // Show a MessageBox
                        MessageBox.Show($"You clicked {clickedControl.judul}" +
                            $"\n{clickedControl.deskripsi}" +
                            $"\n{clickedControl.id}" +
                            $"\n{clickedControl.id_mapel}" +
                            $"\n{clickedControl.id_status}");
                    }

                }
            }

        }

        private void Mapeltugas_Load(object sender, EventArgs e)
        {

            this.labelnamaMapel.Text = mapel;
            this.labelKelas.Text = kelas;
            this.lbGuru.Text = PenugasanContext.getGuru(mapel);
            ListTugasControll[] listTugasControlls = new ListTugasControll[10];
            void populateFlow()
            {
                PenugasanContext penugasanContext = new PenugasanContext();
                DataTable penugasan = PenugasanContext.all();
                foreach (DataRow row in penugasan.Rows)
                {
                    ListTugasControll control = new ListTugasControll();
                    control.judul = row["nama_tugas"].ToString();
                    control.deskripsi = row["deskripsi_tugas"].ToString();
                    control.id = row["id_tugas"].ToString();
                    control.id_mapel = row["kode_mapel"].ToString();
                    control.id_status = row["id_status"].ToString();
                    control.Name = row["id_tugas"].ToString();
                    control.Click += ListTugasControll_Click;
                    foreach (Control childControl in control.Controls)
                    {
                        childControl.Click += ListTugasControll_Click;
                    }

                    flowLayoutPanel1.Controls.Add(control);
                }
            }
            populateFlow();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void btTambah_Click(object sender, EventArgs e)
        {
            using (formTambahTugas = new TambahTugas(kelas, mapel))
            {
                formTambahTugas.ShowDialog();
                string result = formTambahTugas.Result;
                if (result == "Yes")
                {
                    flowLayoutPanel1.Controls.Clear();
                    Mapeltugas_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Tugas gagal dibuat");
                }

            }

        }

        private void btHapus_Click(object sender, EventArgs e)
        {
            isHapus = !isHapus;
            if (isHapus == true)
            {
                btHapus.BackColor = Color.Red;
                btHapus.Text = "Batal";
                btHapus.ForeColor = Color.White;
                lbTopTugas.Text = "Click Tugas Untuk Menghapus Tugas";
            }
            else
            {
                btHapus.BackColor = Color.White;
                btHapus.Text = "Hapus";
                btHapus.ForeColor = Color.Black;
                lbTopTugas.Text = "Daftar Tugas";
            }
        }
    }
}
