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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            buttontambahsiswa = new Button();
            btnEdit = new Button();
            btnHapus = new Button();
            dataGridView1 = new DataGridView();
            clmNISNSiswa = new DataGridViewTextBoxColumn();
            clmNamaSiswa = new DataGridViewTextBoxColumn();
            clmKelas = new DataGridViewTextBoxColumn();
            labelDataSiswa = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttontambahsiswa
            // 
            buttontambahsiswa.BackColor = Color.Green;
            buttontambahsiswa.ForeColor = Color.White;
            buttontambahsiswa.Location = new Point(830, 574);
            buttontambahsiswa.Margin = new Padding(3, 4, 3, 4);
            buttontambahsiswa.Name = "buttontambahsiswa";
            buttontambahsiswa.Size = new Size(101, 62);
            buttontambahsiswa.TabIndex = 0;
            buttontambahsiswa.Text = "Tambah";
            buttontambahsiswa.UseVisualStyleBackColor = false;
            buttontambahsiswa.Click += buttontambahsiswa_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.CornflowerBlue;
            btnEdit.ForeColor = Color.Black;
            btnEdit.Location = new Point(979, 574);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(101, 62);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.Red;
            btnHapus.ForeColor = Color.Black;
            btnHapus.Location = new Point(1129, 574);
            btnHapus.Margin = new Padding(3, 4, 3, 4);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(101, 62);
            btnHapus.TabIndex = 2;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = false;
            btnHapus.Click += btnHapus_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clmNISNSiswa, clmNamaSiswa, clmKelas });
            dataGridView1.Location = new Point(413, 126);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(817, 422);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // clmNISNSiswa
            // 
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            clmNISNSiswa.DefaultCellStyle = dataGridViewCellStyle4;
            clmNISNSiswa.HeaderText = "NISN";
            clmNISNSiswa.MinimumWidth = 6;
            clmNISNSiswa.Name = "clmNISNSiswa";
            clmNISNSiswa.Width = 150;
            // 
            // clmNamaSiswa
            // 
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            clmNamaSiswa.DefaultCellStyle = dataGridViewCellStyle5;
            clmNamaSiswa.HeaderText = "Nama";
            clmNamaSiswa.MinimumWidth = 6;
            clmNamaSiswa.Name = "clmNamaSiswa";
            clmNamaSiswa.Width = 300;
            // 
            // clmKelas
            // 
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            clmKelas.DefaultCellStyle = dataGridViewCellStyle6;
            clmKelas.HeaderText = "Kelas";
            clmKelas.MinimumWidth = 6;
            clmKelas.Name = "clmKelas";
            clmKelas.Width = 150;
            // 
            // labelDataSiswa
            // 
            labelDataSiswa.AutoSize = true;
            labelDataSiswa.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDataSiswa.ForeColor = SystemColors.ActiveCaptionText;
            labelDataSiswa.Location = new Point(401, 38);
            labelDataSiswa.Name = "labelDataSiswa";
            labelDataSiswa.Size = new Size(229, 54);
            labelDataSiswa.TabIndex = 4;
            labelDataSiswa.Text = "Data Siswa";
            // 
            // FormSiswa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 674);
            Controls.Add(labelDataSiswa);
            Controls.Add(dataGridView1);
            Controls.Add(btnHapus);
            Controls.Add(btnEdit);
            Controls.Add(buttontambahsiswa);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
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
        private Label labelDataSiswa;
        private DataGridViewTextBoxColumn clmNISNSiswa;
        private DataGridViewTextBoxColumn clmNamaSiswa;
        private DataGridViewTextBoxColumn clmKelas;
    }
}
