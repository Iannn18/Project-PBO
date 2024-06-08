using Npgsql;
using Project_akhir_PBO.Context;
using Project_akhir_PBO.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_akhir_PBO
{
    public partial class FormPegawai : Form
    {
        private Pegawai_tambah pegawai_tambah;
        private Pegawai_edit formPegawai_edit;

        public FormPegawai()
        {
            InitializeComponent();
        }

        private void FormPegawai_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            string query = "SELECT nama_staff AS \"Nama Pegawai\", nuptk AS NUPTK, jabatan AS Jabatan FROM staff INNER JOIN jabatan ON staff.id_jabatan = jabatan.id_jabatan";
            DataTable dt = Database.queryExecutor(query);

            dataGridPegawai.Rows.Clear(); // Clear existing rows

            foreach (DataRow row in dt.Rows)
            {
                dataGridPegawai.Rows.Add(row["Nama Pegawai"], row["NUPTK"], row["Jabatan"]);
            }
        }

        private void tambahDataPegawai_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                if (pegawai_tambah == null)
                {
                    pegawai_tambah = new Pegawai_tambah(this);
                    pegawai_tambah.FormClosed += Pegawai_tambah_FormClosed;
                    pegawai_tambah.MdiParent = this.MdiParent; // Set MdiParent to the parent of FormPegawai
                    pegawai_tambah.Dock = DockStyle.Fill;
                    pegawai_tambah.Show();
                }
                else
                {
                    pegawai_tambah.Activate();
                }

                this.Hide(); // Hide the current form
            }
        }

        private void Pegawai_tambah_FormClosed(object sender, FormClosedEventArgs e)
        {
            pegawai_tambah = null;
            this.Show(); // Show the current form when Pegawai_tambah is closed
            LoadData(); // Reload the data to refresh the DataGridView
        }

        private void dataGridPegawai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void editPegawai_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                if (formPegawai_edit == null)
                {
                    formPegawai_edit = new Pegawai_edit();
                    formPegawai_edit.FormClosed += Pegawai_edit_FormClosed;
                    formPegawai_edit.MdiParent = this.MdiParent; // Set MdiParent to the parent of FormPegawai
                    formPegawai_edit.Dock = DockStyle.Fill;
                    formPegawai_edit.Show();
                }
                else
                {
                    formPegawai_edit.Activate();
                }

                this.Hide(); // Hide the current form
            }
        }

        private void Pegawai_edit_FormClosed(object sender, FormClosedEventArgs e)
        {
            formPegawai_edit = null;
            this.Show(); // Show the current form when Pegawai_edit is closed
            LoadData(); // Reload the data to refresh the DataGridView
        }

        private void hapusPegawai_Click(object sender, EventArgs e)
        {
            if (dataGridPegawai.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridPegawai.SelectedRows[0];
                string nama = selectedRow.Cells["NamaPegawai"].Value.ToString();
                string nuptk = selectedRow.Cells["NUPTK"].Value.ToString();
                string jabatan = selectedRow.Cells["Jabatan"].Value.ToString();

                DialogResult result = MessageBox.Show($"Apakah Anda yakin ingin menghapus pegawai berikut?\n\nNUPTK: {nuptk}\nNama: {nama}\nJabatan: {jabatan}", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string deleteQuery = "DELETE FROM staff WHERE nuptk = @nuptk";
                    NpgsqlParameter[] parameters = new NpgsqlParameter[]
                    {
                        new NpgsqlParameter("@nuptk", nuptk)
                    };

                    try
                    {
                        Database.commandExecutor(deleteQuery, parameters);
                        MessageBox.Show("Data pegawai berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Terjadi kesalahan saat menghapus data pegawai: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Silakan pilih pegawai yang ingin dihapus, Pastikan menekan bagian paling kiri dari baris data untuk MEMILIH.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // Get the NUPTK from the form
            /*string nuptk = .Text;

            if (string.IsNullOrEmpty(nuptk))
            {
                MessageBox.Show("Please enter a NUPTK.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Call the destroy method to delete the staff from the database
                StaffContext.destroy(nuptk);
                MessageBox.Show("Staff member has been successfully deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Optionally, you can refresh the form or close it after the deletion
                this.Close();
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the deletion operation
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }
    }
}
