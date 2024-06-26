﻿namespace Project_akhir_PBO
{
    partial class FormPegawai
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

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            labelJudul = new Label();
            tambahDataPegawai = new Button();
            dataGridPegawai = new DataGridView();
            NamaPegawai = new DataGridViewTextBoxColumn();
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
            labelJudul.Location = new Point(315, 28);
            labelJudul.Name = "labelJudul";
            labelJudul.Size = new Size(184, 29);
            labelJudul.TabIndex = 0;
            labelJudul.Text = "Daftar Pegawai";
            // 
            // tambahDataPegawai
            // 
            tambahDataPegawai.BackColor = Color.Black;
            tambahDataPegawai.ForeColor = Color.White;
            tambahDataPegawai.Location = new Point(594, 399);
            tambahDataPegawai.Margin = new Padding(3, 2, 3, 2);
            tambahDataPegawai.Name = "tambahDataPegawai";
            tambahDataPegawai.Padding = new Padding(4, 4, 4, 4);
            tambahDataPegawai.Size = new Size(140, 28);
            tambahDataPegawai.TabIndex = 3;
            tambahDataPegawai.Text = "Tambah Pegawai";
            tambahDataPegawai.UseVisualStyleBackColor = false;
            tambahDataPegawai.Click += tambahDataPegawai_Click;
            // 
            // dataGridPegawai
            // 
            dataGridPegawai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPegawai.Columns.AddRange(new DataGridViewColumn[] { NamaPegawai, NUPTK, Jabatan });
            dataGridPegawai.Location = new Point(416, 88);
            dataGridPegawai.Margin = new Padding(3, 2, 3, 2);
            dataGridPegawai.Name = "dataGridPegawai";
            dataGridPegawai.RowHeadersWidth = 51;
            dataGridPegawai.Size = new Size(613, 306);
            dataGridPegawai.TabIndex = 4;
            dataGridPegawai.CellContentClick += dataGridPegawai_CellContentClick;
            // 
            // NamaPegawai
            // 
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            NamaPegawai.DefaultCellStyle = dataGridViewCellStyle1;
            NamaPegawai.HeaderText = "Nama Pegawai";
            NamaPegawai.MinimumWidth = 6;
            NamaPegawai.Name = "NamaPegawai";
            NamaPegawai.ReadOnly = true;
            NamaPegawai.Width = 270;
            // 
            // NUPTK
            // 
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            NUPTK.DefaultCellStyle = dataGridViewCellStyle2;
            NUPTK.HeaderText = "NUPTK";
            NUPTK.MinimumWidth = 6;
            NUPTK.Name = "NUPTK";
            NUPTK.ReadOnly = true;
            NUPTK.Width = 125;
            // 
            // Jabatan
            // 
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            Jabatan.DefaultCellStyle = dataGridViewCellStyle3;
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
            hapusPegawai.Location = new Point(889, 399);
            hapusPegawai.Margin = new Padding(3, 2, 3, 2);
            hapusPegawai.Name = "hapusPegawai";
            hapusPegawai.Padding = new Padding(4, 4, 4, 4);
            hapusPegawai.Size = new Size(140, 28);
            hapusPegawai.TabIndex = 5;
            hapusPegawai.Text = "Hapus";
            hapusPegawai.UseVisualStyleBackColor = false;
            hapusPegawai.Click += hapusPegawai_Click;
            // 
            // editPegawai
            // 
            editPegawai.BackColor = Color.Black;
            editPegawai.ForeColor = Color.White;
            editPegawai.Location = new Point(744, 399);
            editPegawai.Margin = new Padding(3, 2, 3, 2);
            editPegawai.Name = "editPegawai";
            editPegawai.Padding = new Padding(4, 4, 4, 4);
            editPegawai.Size = new Size(140, 28);
            editPegawai.TabIndex = 6;
            editPegawai.Text = "Edit Data";
            editPegawai.UseVisualStyleBackColor = false;
            editPegawai.Click += editPegawai_Click;
            // 
            // FormPegawai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 505);
            Controls.Add(editPegawai);
            Controls.Add(hapusPegawai);
            Controls.Add(dataGridPegawai);
            Controls.Add(tambahDataPegawai);
            Controls.Add(labelJudul);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormPegawai";
            Text = "FormPegawai";
            Load += FormPegawai_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridPegawai).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label labelJudul;
        private Button tambahDataPegawai;
        private DataGridView dataGridPegawai;
        private Button hapusPegawai;
        private Button editPegawai;
        private DataGridViewTextBoxColumn NamaPegawai;
        private DataGridViewTextBoxColumn NUPTK;
        private DataGridViewTextBoxColumn Jabatan;
    }
}
