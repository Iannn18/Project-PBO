namespace Project_akhir_PBO
{
    partial class Mapeltugas
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            labelnamaMapel = new Label();
            labelKelas = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewComboBoxColumn();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // labelnamaMapel
            // 
            labelnamaMapel.AutoSize = true;
            labelnamaMapel.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            labelnamaMapel.ForeColor = Color.Black;
            labelnamaMapel.Location = new Point(695, 36);
            labelnamaMapel.Name = "labelnamaMapel";
            labelnamaMapel.Size = new Size(120, 25);
            labelnamaMapel.TabIndex = 0;
            labelnamaMapel.Text = "Nama Mapel";
            // 
            // labelKelas
            // 
            labelKelas.AutoSize = true;
            labelKelas.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelKelas.ForeColor = Color.Black;
            labelKelas.Location = new Point(1001, 38);
            labelKelas.Name = "labelKelas";
            labelKelas.Size = new Size(51, 23);
            labelKelas.TabIndex = 1;
            labelKelas.Text = "Kelas";
            labelKelas.Click += label2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridView1.Location = new Point(695, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(418, 528);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            dataGridViewCellStyle1.ForeColor = Color.Black;
            Column1.DefaultCellStyle = dataGridViewCellStyle1;
            Column1.HeaderText = "Nama Lengkap Siswa";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 250;
            // 
            // Column2
            // 
            dataGridViewCellStyle2.ForeColor = Color.Black;
            Column2.DefaultCellStyle = dataGridViewCellStyle2;
            Column2.HeaderText = "Status Tugas";
            Column2.Items.AddRange(new object[] { "Selesai", "Belum Selesai" });
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Resizable = DataGridViewTriState.True;
            Column2.Width = 125;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.AutoScrollMargin = new Size(0, 100);
            flowLayoutPanel1.Location = new Point(410, 82);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(279, 509);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // Mapeltugas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1213, 591);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(dataGridView1);
            Controls.Add(labelKelas);
            Controls.Add(labelnamaMapel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Mapeltugas";
            Text = "Mapeltugas";
            Load += Mapeltugas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelnamaMapel;
        private Label labelKelas;
        private DataGridView dataGridView1;
        private Button buttonTugas1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewComboBoxColumn Column2;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
