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
        public Mapeltugas()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        // Define the event handler outside of Mapeltugas_Load
        private void ListTugasControll_Click(object sender, EventArgs e)
        {
            // Get the parent control of the sender and cast it to ListTugasControll
            ListTugasControll clickedControl = ((Control)sender).Parent as ListTugasControll;

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

        private void Mapeltugas_Load(object sender, EventArgs e)
        {

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
                /*                for (int i = 0; i < 10; i++)
                                {
                                    listTugasControlls[i] = new ListTugasControll();
                                    listTugasControlls[i].judul = "Tugas " + i;
                                    listTugasControlls[i].deskripsi = "Deskripsi Tugas " + i;
                                    listTugasControlls[i].Name = "Tugas " + i;
                                    listTugasControlls[i].Click += ListTugasControll_Click;
                                    foreach (Control childControl in listTugasControlls[i].Controls)
                                    {
                                        childControl.Click += ListTugasControll_Click;
                                    }

                                    if (flowLayoutPanel1.Controls.Count < 0)
                                    {
                                        flowLayoutPanel1.Controls.Clear();
                                    }
                                    else
                                    {

                                        flowLayoutPanel1.Controls.Add(listTugasControlls[i]);
                                    }
                                }*/
            }
            populateFlow();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonTambahTugas_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string dataToShow = clickedButton.Text;

                if (formTambahTugas == null)
                {
                    formTambahTugas = new TambahTugas();
                    formTambahTugas.FormClosed += TambahTugas_FormClosed;
                    formTambahTugas.MdiParent = this.MdiParent; // Set MdiParent to the parent of FormKelas1
                    formTambahTugas.Dock = DockStyle.Fill;
                    formTambahTugas.Show();
                }
                else
                {
                    formTambahTugas.Activate();
                }

                this.Close();
            }
        }
        private void TambahTugas_FormClosed(object sender, FormClosedEventArgs e)
        {
            formTambahTugas = null;
        }


    }
}
