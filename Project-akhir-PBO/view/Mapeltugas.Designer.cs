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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mapeltugas));
            labelnamaMapel = new Label();
            labelKelas = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btTambah = new Button();
            btHapus = new Button();
            lbTopTugas = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lbGuru = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // labelnamaMapel
            // 
            labelnamaMapel.AutoSize = true;
            labelnamaMapel.Font = new Font("Segoe UI", 13F);
            labelnamaMapel.ForeColor = Color.Black;
            labelnamaMapel.Location = new Point(141, 14);
            labelnamaMapel.Name = "labelnamaMapel";
            labelnamaMapel.Size = new Size(113, 25);
            labelnamaMapel.TabIndex = 0;
            labelnamaMapel.Text = "Nama Mapel";
            // 
            // labelKelas
            // 
            labelKelas.AutoSize = true;
            labelKelas.Font = new Font("Segoe UI", 13F);
            labelKelas.ForeColor = Color.Black;
            labelKelas.Location = new Point(143, 54);
            labelKelas.Name = "labelKelas";
            labelKelas.Size = new Size(52, 25);
            labelKelas.TabIndex = 1;
            labelKelas.Text = "Kelas";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.AutoScrollMargin = new Size(0, 100);
            flowLayoutPanel1.Location = new Point(728, 53);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(253, 449);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // btTambah
            // 
            btTambah.Location = new Point(984, 362);
            btTambah.Name = "btTambah";
            btTambah.Size = new Size(100, 50);
            btTambah.TabIndex = 5;
            btTambah.Text = "Tambah";
            btTambah.UseVisualStyleBackColor = true;
            btTambah.Click += btTambah_Click;
            // 
            // btHapus
            // 
            btHapus.Location = new Point(984, 434);
            btHapus.Name = "btHapus";
            btHapus.Size = new Size(100, 50);
            btHapus.TabIndex = 6;
            btHapus.Text = "Hapus";
            btHapus.UseVisualStyleBackColor = true;
            btHapus.Click += btHapus_Click;
            // 
            // lbTopTugas
            // 
            lbTopTugas.AutoSize = true;
            lbTopTugas.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTopTugas.Location = new Point(3, 15);
            lbTopTugas.Name = "lbTopTugas";
            lbTopTugas.Size = new Size(183, 22);
            lbTopTugas.TabIndex = 7;
            lbTopTugas.Text = "           Daftar Tugas";
            lbTopTugas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(lbTopTugas);
            panel1.Location = new Point(728, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(356, 52);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(lbGuru);
            panel2.Controls.Add(labelnamaMapel);
            panel2.Controls.Add(labelKelas);
            panel2.Location = new Point(333, 53);
            panel2.Name = "panel2";
            panel2.Size = new Size(392, 141);
            panel2.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(8, 95);
            label1.Name = "label1";
            label1.Size = new Size(134, 25);
            label1.TabIndex = 5;
            label1.Text = "Guru              : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(3, 15);
            label2.Name = "label2";
            label2.Size = new Size(140, 25);
            label2.TabIndex = 3;
            label2.Text = "Nama Mapel  : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(6, 54);
            label3.Name = "label3";
            label3.Size = new Size(132, 25);
            label3.TabIndex = 4;
            label3.Text = "Kelas              :";
            // 
            // lbGuru
            // 
            lbGuru.AutoSize = true;
            lbGuru.Font = new Font("Segoe UI", 13F);
            lbGuru.ForeColor = Color.Black;
            lbGuru.Location = new Point(143, 95);
            lbGuru.Name = "lbGuru";
            lbGuru.Size = new Size(50, 25);
            lbGuru.TabIndex = 2;
            lbGuru.Text = "Guru";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(331, 209);
            label4.Name = "label4";
            label4.Size = new Size(329, 126);
            label4.TabIndex = 10;
            label4.Text = resources.GetString("label4.Text");
            // 
            // Mapeltugas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 505);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btHapus);
            Controls.Add(btTambah);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Mapeltugas";
            Text = "Mapeltugas";
            Load += Mapeltugas_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelnamaMapel;
        private Label labelKelas;
        private Button buttonTugas1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btTambah;
        private Button btHapus;
        private Label lbTopTugas;
        private Panel panel1;
        private Panel panel2;
        private Label lbGuru;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
