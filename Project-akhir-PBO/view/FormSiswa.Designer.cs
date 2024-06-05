namespace Project_akhir_PBO
{
    partial class FormSiswa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttontambahsiswa = new Button();
            btnEdit = new Button();
            btnHapus = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            namaSiswa = new DataGridViewTextBoxColumn();
            hadirSiswa = new DataGridViewTextBoxColumn();
            izinSiswa = new DataGridViewTextBoxColumn();
            sakitSiswa = new DataGridViewTextBoxColumn();
            alpaSiswa = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttontambahsiswa
            // 
            buttontambahsiswa.BackColor = Color.Green;
            buttontambahsiswa.ForeColor = Color.White;
            buttontambahsiswa.Location = new Point(830, 573);
            buttontambahsiswa.Margin = new Padding(3, 4, 3, 4);
            buttontambahsiswa.Name = "buttontambahsiswa";
            buttontambahsiswa.Size = new Size(101, 63);
            buttontambahsiswa.TabIndex = 0;
            buttontambahsiswa.Text = "Tambah";
            buttontambahsiswa.UseVisualStyleBackColor = false;
            buttontambahsiswa.Click += buttontambahsiswa_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.CornflowerBlue;
            btnEdit.ForeColor = Color.Black;
            btnEdit.Location = new Point(979, 573);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(101, 63);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.Red;
            btnHapus.ForeColor = Color.Black;
            btnHapus.Location = new Point(1129, 573);
            btnHapus.Margin = new Padding(3, 4, 3, 4);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(101, 63);
            btnHapus.TabIndex = 2;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { namaSiswa, hadirSiswa, izinSiswa, sakitSiswa, alpaSiswa });
            dataGridView1.Location = new Point(413, 125);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(817, 423);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(401, 37);
            label1.Name = "label1";
            label1.Size = new Size(229, 54);
            label1.TabIndex = 4;
            label1.Text = "Data Siswa";
            // 
            // namaSiswa
            // 
            namaSiswa.HeaderText = "Nama";
            namaSiswa.MinimumWidth = 6;
            namaSiswa.Name = "namaSiswa";
            namaSiswa.Width = 270;
            // 
            // hadirSiswa
            // 
            hadirSiswa.HeaderText = "Hadir";
            hadirSiswa.MinimumWidth = 6;
            hadirSiswa.Name = "hadirSiswa";
            hadirSiswa.Width = 125;
            // 
            // izinSiswa
            // 
            izinSiswa.HeaderText = "Izin";
            izinSiswa.MinimumWidth = 6;
            izinSiswa.Name = "izinSiswa";
            izinSiswa.Width = 125;
            // 
            // sakitSiswa
            // 
            sakitSiswa.HeaderText = "Sakit";
            sakitSiswa.MinimumWidth = 6;
            sakitSiswa.Name = "sakitSiswa";
            sakitSiswa.Width = 125;
            // 
            // alpaSiswa
            // 
            alpaSiswa.HeaderText = "Alpa";
            alpaSiswa.MinimumWidth = 6;
            alpaSiswa.Name = "alpaSiswa";
            alpaSiswa.Width = 125;
            // 
            // FormSiswa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(label1);
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
        private Label label1;
        private DataGridViewTextBoxColumn namaSiswa;
        private DataGridViewTextBoxColumn hadirSiswa;
        private DataGridViewTextBoxColumn izinSiswa;
        private DataGridViewTextBoxColumn sakitSiswa;
        private DataGridViewTextBoxColumn alpaSiswa;
    }
}
