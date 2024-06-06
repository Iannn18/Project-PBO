namespace Project_akhir_PBO
{
    partial class FormSiswa
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            buttontambahsiswa = new Button();
            btnEdit = new Button();
            btnHapus = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            clmNISNSiswa = new DataGridViewTextBoxColumn();
            clmNamaSiswa = new DataGridViewTextBoxColumn();
            clmKelas = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttontambahsiswa
            // 
            buttontambahsiswa.BackColor = Color.Green;
            buttontambahsiswa.ForeColor = Color.White;
            buttontambahsiswa.Location = new Point(1037, 717);
            buttontambahsiswa.Margin = new Padding(4, 5, 4, 5);
            buttontambahsiswa.Name = "buttontambahsiswa";
            buttontambahsiswa.Size = new Size(126, 78);
            buttontambahsiswa.TabIndex = 0;
            buttontambahsiswa.Text = "Tambah";
            buttontambahsiswa.UseVisualStyleBackColor = false;
            buttontambahsiswa.Click += buttontambahsiswa_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.CornflowerBlue;
            btnEdit.ForeColor = Color.Black;
            btnEdit.Location = new Point(1224, 717);
            btnEdit.Margin = new Padding(4, 5, 4, 5);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(126, 78);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.Red;
            btnHapus.ForeColor = Color.Black;
            btnHapus.Location = new Point(1411, 717);
            btnHapus.Margin = new Padding(4, 5, 4, 5);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(126, 78);
            btnHapus.TabIndex = 2;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clmNISNSiswa, clmNamaSiswa, clmKelas });
            dataGridView1.Location = new Point(516, 157);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1021, 528);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(501, 47);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(273, 65);
            label1.TabIndex = 4;
            label1.Text = "Data Siswa";
            // 
            // clmNISNSiswa
            // 
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            clmNISNSiswa.DefaultCellStyle = dataGridViewCellStyle1;
            clmNISNSiswa.HeaderText = "NISN";
            clmNISNSiswa.MinimumWidth = 6;
            clmNISNSiswa.Name = "clmNISNSiswa";
            clmNISNSiswa.Width = 150;
            // 
            // clmNamaSiswa
            // 
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            clmNamaSiswa.DefaultCellStyle = dataGridViewCellStyle2;
            clmNamaSiswa.HeaderText = "Nama";
            clmNamaSiswa.MinimumWidth = 6;
            clmNamaSiswa.Name = "clmNamaSiswa";
            clmNamaSiswa.Width = 300;
            // 
            // clmKelas
            // 
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            clmKelas.DefaultCellStyle = dataGridViewCellStyle3;
            clmKelas.HeaderText = "Kelas";
            clmKelas.MinimumWidth = 6;
            clmKelas.Name = "clmKelas";
            clmKelas.Width = 150;
            // 
            // FormSiswa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1577, 842);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btnHapus);
            Controls.Add(btnEdit);
            Controls.Add(buttontambahsiswa);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormSiswa";
            Text = "FormSiswa";
            Load += FormSiswa_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttontambahsiswa;
        private Button btnEdit;
        private Button btnHapus;
        private DataGridView dataGridView1;
        private Label label1;
        private DataGridViewTextBoxColumn clmNISNSiswa;
        private DataGridViewTextBoxColumn clmNamaSiswa;
        private DataGridViewTextBoxColumn clmKelas;
    }
}
