namespace Project_akhir_PBO
{
    partial class detailTugas
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonSimpandetailtugas = new Button();
            buttonBataldetailtugas = new Button();
            Column3 = new DataGridViewCheckBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column4, Column2, Column3 });
            dataGridView1.Location = new Point(476, 160);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(593, 377);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(476, 60);
            label1.Name = "label1";
            label1.Size = new Size(78, 28);
            label1.TabIndex = 1;
            label1.Text = "Tugas 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.Location = new Point(476, 88);
            label2.Name = "label2";
            label2.Size = new Size(106, 19);
            label2.TabIndex = 2;
            label2.Text = " Mata Pelajaran";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(484, 124);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 3;
            label3.Text = "Pertanyaan tugas";
            // 
            // buttonSimpandetailtugas
            // 
            buttonSimpandetailtugas.BackColor = Color.SeaGreen;
            buttonSimpandetailtugas.ForeColor = Color.White;
            buttonSimpandetailtugas.Location = new Point(786, 543);
            buttonSimpandetailtugas.Name = "buttonSimpandetailtugas";
            buttonSimpandetailtugas.Size = new Size(86, 29);
            buttonSimpandetailtugas.TabIndex = 4;
            buttonSimpandetailtugas.Text = "Simpan";
            buttonSimpandetailtugas.UseVisualStyleBackColor = false;
            // 
            // buttonBataldetailtugas
            // 
            buttonBataldetailtugas.BackColor = Color.Red;
            buttonBataldetailtugas.ForeColor = Color.White;
            buttonBataldetailtugas.Location = new Point(674, 543);
            buttonBataldetailtugas.Name = "buttonBataldetailtugas";
            buttonBataldetailtugas.Size = new Size(86, 29);
            buttonBataldetailtugas.TabIndex = 5;
            buttonBataldetailtugas.Text = "Batal";
            buttonBataldetailtugas.UseVisualStyleBackColor = false;
            // 
            // Column3
            // 
            Column3.HeaderText = "Status";
            Column3.Name = "Column3";
            Column3.Resizable = DataGridViewTriState.True;
            Column3.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nilai";
            Column2.Name = "Column2";
            // 
            // Column4
            // 
            Column4.HeaderText = "NISN";
            Column4.Name = "Column4";
            Column4.Width = 150;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nama Lengkap Siswa";
            Column1.Name = "Column1";
            Column1.Width = 200;
            // 
            // detailTugas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(buttonBataldetailtugas);
            Controls.Add(buttonSimpandetailtugas);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "detailTugas";
            Text = "detailTugas";
            Load += detailTugas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonSimpandetailtugas;
        private Button buttonBataldetailtugas;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewCheckBoxColumn Column3;
    }
}
