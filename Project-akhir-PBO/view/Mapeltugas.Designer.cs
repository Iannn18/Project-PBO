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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            labelnamaMapel = new Label();
            labelKelas = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewComboBoxColumn();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonDetailtgs1 = new Button();
            buttonTambahTugas = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelnamaMapel
            // 
            labelnamaMapel.AutoSize = true;
            labelnamaMapel.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            labelnamaMapel.ForeColor = Color.Black;
            labelnamaMapel.Location = new Point(794, 48);
            labelnamaMapel.Name = "labelnamaMapel";
            labelnamaMapel.Size = new Size(145, 30);
            labelnamaMapel.TabIndex = 0;
            labelnamaMapel.Text = "Nama Mapel";
            // 
            // labelKelas
            // 
            labelKelas.AutoSize = true;
            labelKelas.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelKelas.ForeColor = Color.Black;
            labelKelas.Location = new Point(1144, 51);
            labelKelas.Name = "labelKelas";
            labelKelas.Size = new Size(67, 30);
            labelKelas.TabIndex = 1;
            labelKelas.Text = "Kelas";
            labelKelas.Click += label2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridView1.Location = new Point(794, 109);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(478, 748);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            dataGridViewCellStyle3.ForeColor = Color.Black;
            Column1.DefaultCellStyle = dataGridViewCellStyle3;
            Column1.HeaderText = "Nama Lengkap Siswa";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 250;
            // 
            // Column2
            // 
            dataGridViewCellStyle4.ForeColor = Color.Black;
            Column2.DefaultCellStyle = dataGridViewCellStyle4;
            Column2.HeaderText = "Status Kehadiran";
            Column2.Items.AddRange(new object[] { "Hadir", "Ijin", "Sakit", "Alfa" });
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Resizable = DataGridViewTriState.True;
            Column2.Width = 125;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Location = new Point(471, 51);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(232, 724);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(buttonDetailtgs1);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 16);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(222, 704);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // buttonDetailtgs1
            // 
            buttonDetailtgs1.ForeColor = Color.Black;
            buttonDetailtgs1.Location = new Point(3, 4);
            buttonDetailtgs1.Margin = new Padding(3, 4, 3, 4);
            buttonDetailtgs1.Name = "buttonDetailtgs1";
            buttonDetailtgs1.Size = new Size(208, 125);
            buttonDetailtgs1.TabIndex = 0;
            buttonDetailtgs1.Text = "Tugas 1";
            buttonDetailtgs1.UseVisualStyleBackColor = true;
            // 
            // buttonTambahTugas
            // 
            buttonTambahTugas.AutoSize = true;
            buttonTambahTugas.Font = new Font("Segoe UI", 25F);
            buttonTambahTugas.ForeColor = Color.Black;
            buttonTambahTugas.Location = new Point(544, 799);
            buttonTambahTugas.Margin = new Padding(3, 4, 3, 4);
            buttonTambahTugas.Name = "buttonTambahTugas";
            buttonTambahTugas.Size = new Size(105, 75);
            buttonTambahTugas.TabIndex = 2;
            buttonTambahTugas.Text = "+";
            buttonTambahTugas.UseVisualStyleBackColor = true;
            buttonTambahTugas.Click += buttonTambahTugas_Click;
            // 
            // Mapeltugas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1445, 908);
            Controls.Add(buttonTambahTugas);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(labelKelas);
            Controls.Add(labelnamaMapel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Mapeltugas";
            Text = "Mapeltugas";
            Load += Mapeltugas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelnamaMapel;
        private Label labelKelas;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Button buttonTugas1;
        private Button buttonTambahTugas;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonDetailtgs1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewComboBoxColumn Column2;
    }
}
