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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttontambahsiswa
            // 
            buttontambahsiswa.BackColor = Color.Green;
            buttontambahsiswa.ForeColor = Color.White;
            buttontambahsiswa.Location = new Point(726, 430);
            buttontambahsiswa.Name = "buttontambahsiswa";
            buttontambahsiswa.Size = new Size(88, 47);
            buttontambahsiswa.TabIndex = 0;
            buttontambahsiswa.Text = "Tambah";
            buttontambahsiswa.UseVisualStyleBackColor = false;
            buttontambahsiswa.Click += buttontambahsiswa_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.CornflowerBlue;
            btnEdit.ForeColor = Color.Black;
            btnEdit.Location = new Point(857, 430);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(88, 47);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.Red;
            btnHapus.ForeColor = Color.Black;
            btnHapus.Location = new Point(988, 430);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(88, 47);
            btnHapus.TabIndex = 2;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(351, 86);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(725, 319);
            dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(351, 28);
            label1.Name = "label1";
            label1.Size = new Size(183, 45);
            label1.TabIndex = 4;
            label1.Text = "Data Siswa";
            // 
            // FormSiswa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 505);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btnHapus);
            Controls.Add(btnEdit);
            Controls.Add(buttontambahsiswa);
            FormBorderStyle = FormBorderStyle.None;
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
    }
}
