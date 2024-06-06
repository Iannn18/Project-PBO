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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            labelnamaMapel = new Label();
            label2 = new Label();
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
            labelnamaMapel.Location = new Point(635, 34);
            labelnamaMapel.Name = "labelnamaMapel";
            labelnamaMapel.Size = new Size(120, 25);
            labelnamaMapel.TabIndex = 0;
            labelnamaMapel.Text = "Nama Mapel";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(941, 36);
            label2.Name = "label2";
            label2.Size = new Size(51, 23);
            label2.TabIndex = 1;
            label2.Text = "Kelas";
            label2.Click += label2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridView1.Location = new Point(635, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(418, 561);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            dataGridViewCellStyle5.ForeColor = Color.Black;
            Column1.DefaultCellStyle = dataGridViewCellStyle5;
            Column1.HeaderText = "Nama Lengkap Siswa";
            Column1.Name = "Column1";
            Column1.Width = 250;
            // 
            // Column2
            // 
            dataGridViewCellStyle6.ForeColor = Color.Black;
            Column2.DefaultCellStyle = dataGridViewCellStyle6;
            Column2.HeaderText = "Status Kehadiran";
            Column2.Items.AddRange(new object[] { "Hadir", "Ijin", "Sakit", "Alfa" });
            Column2.Name = "Column2";
            Column2.Resizable = DataGridViewTriState.True;
            Column2.Width = 125;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Location = new Point(346, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(203, 543);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(buttonDetailtgs1);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(194, 528);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // buttonDetailtgs1
            // 
            buttonDetailtgs1.ForeColor = Color.Black;
            buttonDetailtgs1.Location = new Point(3, 3);
            buttonDetailtgs1.Name = "buttonDetailtgs1";
            buttonDetailtgs1.Size = new Size(191, 94);
            buttonDetailtgs1.TabIndex = 0;
            buttonDetailtgs1.Text = "Tugas 1";
            buttonDetailtgs1.UseVisualStyleBackColor = true;
            // 
            // buttonTambahTugas
            // 
            buttonTambahTugas.AutoSize = true;
            buttonTambahTugas.Font = new Font("Segoe UI", 25F);
            buttonTambahTugas.Location = new Point(410, 597);
            buttonTambahTugas.Name = "buttonTambahTugas";
            buttonTambahTugas.Size = new Size(92, 56);
            buttonTambahTugas.TabIndex = 2;
            buttonTambahTugas.Text = "+";
            buttonTambahTugas.UseVisualStyleBackColor = true;
            // 
            // Mapeltugas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(buttonTambahTugas);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(labelnamaMapel);
            FormBorderStyle = FormBorderStyle.None;
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
        private Label label2;
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
