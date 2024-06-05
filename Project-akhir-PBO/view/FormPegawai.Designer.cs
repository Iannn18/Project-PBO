namespace Project_akhir_PBO
{
    partial class FormPegawai
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
            labelJudul = new Label();
            tambahDataPegawai = new Button();
            dataGridPegawai = new DataGridView();
            Status = new DataGridViewTextBoxColumn();
            Nama = new DataGridViewTextBoxColumn();
            NUPTK = new DataGridViewTextBoxColumn();
            Jabatan = new DataGridViewTextBoxColumn();
            hapusPegawai = new Button();
            editPegawai = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridPegawai).BeginInit();
            SuspendLayout();
            // 
            // labelJudul
            // 
            labelJudul.AutoSize = true;
            labelJudul.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelJudul.ForeColor = Color.Black;
            labelJudul.Location = new Point(360, 37);
            labelJudul.Name = "labelJudul";
            labelJudul.Size = new Size(233, 35);
            labelJudul.TabIndex = 0;
            labelJudul.Text = "Daftar Pegawai";
            // 
            // tambahDataPegawai
            // 
            tambahDataPegawai.BackColor = Color.Black;
            tambahDataPegawai.ForeColor = Color.White;
            tambahDataPegawai.Location = new Point(679, 532);
            tambahDataPegawai.Name = "tambahDataPegawai";
            tambahDataPegawai.Padding = new Padding(5);
            tambahDataPegawai.Size = new Size(160, 37);
            tambahDataPegawai.TabIndex = 3;
            tambahDataPegawai.Text = "Tambah Pegawai";
            tambahDataPegawai.UseVisualStyleBackColor = false;
            tambahDataPegawai.Click += tambahDataPegawai_Click;
            // 
            // dataGridPegawai
            // 
            dataGridPegawai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPegawai.Columns.AddRange(new DataGridViewColumn[] { Status, Nama, NUPTK, Jabatan });
            dataGridPegawai.Location = new Point(475, 118);
            dataGridPegawai.Name = "dataGridPegawai";
            dataGridPegawai.RowHeadersWidth = 51;
            dataGridPegawai.Size = new Size(701, 408);
            dataGridPegawai.TabIndex = 4;
            dataGridPegawai.CellContentClick += dataGridPegawai_CellContentClick;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 125;
            // 
            // Nama
            // 
            Nama.HeaderText = "Nama Pegawai";
            Nama.MinimumWidth = 6;
            Nama.Name = "Nama";
            Nama.ReadOnly = true;
            Nama.Width = 270;
            // 
            // NUPTK
            // 
            NUPTK.HeaderText = "NUPTK";
            NUPTK.MinimumWidth = 6;
            NUPTK.Name = "NUPTK";
            NUPTK.ReadOnly = true;
            NUPTK.Width = 125;
            // 
            // Jabatan
            // 
            Jabatan.HeaderText = "Jabatan";
            Jabatan.MinimumWidth = 6;
            Jabatan.Name = "Jabatan";
            Jabatan.ReadOnly = true;
            Jabatan.Width = 125;
            // 
            // hapusPegawai
            // 
            hapusPegawai.BackColor = Color.Black;
            hapusPegawai.ForeColor = Color.White;
            hapusPegawai.Location = new Point(1016, 532);
            hapusPegawai.Name = "hapusPegawai";
            hapusPegawai.Padding = new Padding(5);
            hapusPegawai.Size = new Size(160, 37);
            hapusPegawai.TabIndex = 5;
            hapusPegawai.Text = "Hapus";
            hapusPegawai.UseVisualStyleBackColor = false;
            // 
            // editPegawai
            // 
            editPegawai.BackColor = Color.Black;
            editPegawai.ForeColor = Color.White;
            editPegawai.Location = new Point(850, 532);
            editPegawai.Name = "editPegawai";
            editPegawai.Padding = new Padding(5);
            editPegawai.Size = new Size(160, 37);
            editPegawai.TabIndex = 6;
            editPegawai.Text = "Edit Data";
            editPegawai.UseVisualStyleBackColor = false;
            editPegawai.Click += editPegawai_Click;
            // 
            // FormPegawai
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(editPegawai);
            Controls.Add(hapusPegawai);
            Controls.Add(dataGridPegawai);
            Controls.Add(tambahDataPegawai);
            Controls.Add(labelJudul);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPegawai";
            Text = "FormPegawai";
            Load += FormPegawai_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridPegawai).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelJudul;
        private Button tambahDataPegawai;
        private DataGridView dataGridPegawai;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Nama;
        private DataGridViewTextBoxColumn NUPTK;
        private DataGridViewTextBoxColumn Jabatan;
        private Button hapusPegawai;
        private Button editPegawai;
    }
}