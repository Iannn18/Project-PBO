namespace Project_akhir_PBO
{
    partial class siswa_tambah
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
            panel1 = new Panel();
            comboBoxkelassiswa = new ComboBox();
            labelKelasSiswa = new Label();
            labelAlamatSiswa = new Label();
            labelTempatLahirSiswa = new Label();
            labelNoTelpSiswa = new Label();
            textBoxalamatsiswa = new TextBox();
            textBoxlahirsiswa = new TextBox();
            textBoxnohpsiswa = new TextBox();
            submit = new Button();
            textBoxtanggalsiswa = new TextBox();
            textBoxnisnsiswa = new TextBox();
            textBoxnamasiswa = new TextBox();
            labelTanggalLahirSiswa = new Label();
            labelNISNSiswa = new Label();
            labelNamaSiswa = new Label();
            labelHalaman = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(comboBoxkelassiswa);
            panel1.Controls.Add(labelKelasSiswa);
            panel1.Controls.Add(labelAlamatSiswa);
            panel1.Controls.Add(labelTempatLahirSiswa);
            panel1.Controls.Add(labelNoTelpSiswa);
            panel1.Controls.Add(textBoxalamatsiswa);
            panel1.Controls.Add(textBoxlahirsiswa);
            panel1.Controls.Add(textBoxnohpsiswa);
            panel1.Controls.Add(submit);
            panel1.Controls.Add(textBoxtanggalsiswa);
            panel1.Controls.Add(textBoxnisnsiswa);
            panel1.Controls.Add(textBoxnamasiswa);
            panel1.Controls.Add(labelTanggalLahirSiswa);
            panel1.Controls.Add(labelNISNSiswa);
            panel1.Controls.Add(labelNamaSiswa);
            panel1.Controls.Add(labelHalaman);
            panel1.Location = new Point(586, 44);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(539, 582);
            panel1.TabIndex = 0;
            // 
            // comboBoxkelassiswa
            // 
            comboBoxkelassiswa.FormattingEnabled = true;
            comboBoxkelassiswa.Items.AddRange(new object[] { "X-A", "X-B", "X-C", "X-D", "X-E", "X-F", "X-G", "X-H", "XI-A", "XI-B", "XI-C", "XI-D", "XI-E", "XI-F", "XI-G", "XI-H", "XII-A", "XII-B", "XII-C", "XII-D", "XII-E", "XII-F", "XII-G", "XII-H" });
            comboBoxkelassiswa.Location = new Point(195, 406);
            comboBoxkelassiswa.Margin = new Padding(3, 4, 3, 4);
            comboBoxkelassiswa.Name = "comboBoxkelassiswa";
            comboBoxkelassiswa.Size = new Size(305, 28);
            comboBoxkelassiswa.TabIndex = 16;
            comboBoxkelassiswa.SelectedIndexChanged += comboBoxkelassiswa_SelectedIndexChanged;
            // 
            // labelKelasSiswa
            // 
            labelKelasSiswa.AutoSize = true;
            labelKelasSiswa.ForeColor = Color.Black;
            labelKelasSiswa.Location = new Point(38, 410);
            labelKelasSiswa.Name = "labelKelasSiswa";
            labelKelasSiswa.Size = new Size(44, 20);
            labelKelasSiswa.TabIndex = 15;
            labelKelasSiswa.Text = "Kelas";
            labelKelasSiswa.Click += labelKelasSiswa_Click;
            // 
            // labelAlamatSiswa
            // 
            labelAlamatSiswa.AutoSize = true;
            labelAlamatSiswa.ForeColor = Color.Black;
            labelAlamatSiswa.Location = new Point(35, 356);
            labelAlamatSiswa.Name = "labelAlamatSiswa";
            labelAlamatSiswa.Size = new Size(57, 20);
            labelAlamatSiswa.TabIndex = 14;
            labelAlamatSiswa.Text = "Alamat";
            labelAlamatSiswa.Click += labelAlamatSiswa_Click;
            // 
            // labelTempatLahirSiswa
            // 
            labelTempatLahirSiswa.AutoSize = true;
            labelTempatLahirSiswa.ForeColor = Color.Black;
            labelTempatLahirSiswa.Location = new Point(34, 306);
            labelTempatLahirSiswa.Name = "labelTempatLahirSiswa";
            labelTempatLahirSiswa.Size = new Size(95, 20);
            labelTempatLahirSiswa.TabIndex = 13;
            labelTempatLahirSiswa.Text = "Tempat Lahir";
            labelTempatLahirSiswa.Click += labelTempatLahirSiswa_Click;
            // 
            // labelNoTelpSiswa
            // 
            labelNoTelpSiswa.AutoSize = true;
            labelNoTelpSiswa.ForeColor = Color.Black;
            labelNoTelpSiswa.Location = new Point(34, 258);
            labelNoTelpSiswa.Name = "labelNoTelpSiswa";
            labelNoTelpSiswa.Size = new Size(89, 20);
            labelNoTelpSiswa.TabIndex = 12;
            labelNoTelpSiswa.Text = "No. Telepon";
            labelNoTelpSiswa.Click += labelNoTelpSiswa_Click;
            // 
            // textBoxalamatsiswa
            // 
            textBoxalamatsiswa.Location = new Point(197, 352);
            textBoxalamatsiswa.Margin = new Padding(3, 4, 3, 4);
            textBoxalamatsiswa.Name = "textBoxalamatsiswa";
            textBoxalamatsiswa.Size = new Size(303, 27);
            textBoxalamatsiswa.TabIndex = 10;
            textBoxalamatsiswa.TextChanged += textBoxalamatsiswa_TextChanged;
            // 
            // textBoxlahirsiswa
            // 
            textBoxlahirsiswa.Location = new Point(195, 302);
            textBoxlahirsiswa.Margin = new Padding(3, 4, 3, 4);
            textBoxlahirsiswa.Name = "textBoxlahirsiswa";
            textBoxlahirsiswa.Size = new Size(305, 27);
            textBoxlahirsiswa.TabIndex = 9;
            textBoxlahirsiswa.TextChanged += textBoxlahirsiswa_TextChanged;
            // 
            // textBoxnohpsiswa
            // 
            textBoxnohpsiswa.Location = new Point(195, 254);
            textBoxnohpsiswa.Margin = new Padding(3, 4, 3, 4);
            textBoxnohpsiswa.Name = "textBoxnohpsiswa";
            textBoxnohpsiswa.Size = new Size(305, 27);
            textBoxnohpsiswa.TabIndex = 8;
            textBoxnohpsiswa.TextChanged += textBoxnohpsiswa_TextChanged;
            // 
            // submit
            // 
            submit.BackColor = SystemColors.ActiveCaptionText;
            submit.ForeColor = Color.White;
            submit.Location = new Point(38, 494);
            submit.Margin = new Padding(3, 4, 3, 4);
            submit.Name = "submit";
            submit.Size = new Size(463, 38);
            submit.TabIndex = 7;
            submit.Text = "Submit";
            submit.UseVisualStyleBackColor = false;
            submit.Click += submit_Click;
            // 
            // textBoxtanggalsiswa
            // 
            textBoxtanggalsiswa.Font = new Font("Segoe UI", 8F);
            textBoxtanggalsiswa.ForeColor = SystemColors.GrayText;
            textBoxtanggalsiswa.Location = new Point(195, 206);
            textBoxtanggalsiswa.Margin = new Padding(3, 4, 3, 4);
            textBoxtanggalsiswa.Name = "textBoxtanggalsiswa";
            textBoxtanggalsiswa.Size = new Size(305, 25);
            textBoxtanggalsiswa.TabIndex = 6;
            textBoxtanggalsiswa.TextChanged += textBoxtanggalsiswa_TextChanged;
            // 
            // textBoxnisnsiswa
            // 
            textBoxnisnsiswa.Font = new Font("Segoe UI", 8F);
            textBoxnisnsiswa.ForeColor = SystemColors.GrayText;
            textBoxnisnsiswa.Location = new Point(195, 160);
            textBoxnisnsiswa.Margin = new Padding(3, 4, 3, 4);
            textBoxnisnsiswa.Name = "textBoxnisnsiswa";
            textBoxnisnsiswa.Size = new Size(305, 25);
            textBoxnisnsiswa.TabIndex = 5;
            textBoxnisnsiswa.TextChanged += textBoxnisnsiswa_TextChanged;
            // 
            // textBoxnamasiswa
            // 
            textBoxnamasiswa.Font = new Font("Segoe UI", 8F);
            textBoxnamasiswa.ForeColor = SystemColors.GrayText;
            textBoxnamasiswa.Location = new Point(195, 114);
            textBoxnamasiswa.Margin = new Padding(3, 4, 3, 4);
            textBoxnamasiswa.Name = "textBoxnamasiswa";
            textBoxnamasiswa.Size = new Size(305, 25);
            textBoxnamasiswa.TabIndex = 4;
            textBoxnamasiswa.TextChanged += textBoxnamasiswa_TextChanged;
            // 
            // labelTanggalLahirSiswa
            // 
            labelTanggalLahirSiswa.AutoSize = true;
            labelTanggalLahirSiswa.BackColor = Color.Transparent;
            labelTanggalLahirSiswa.ForeColor = Color.Black;
            labelTanggalLahirSiswa.Location = new Point(33, 214);
            labelTanggalLahirSiswa.Name = "labelTanggalLahirSiswa";
            labelTanggalLahirSiswa.Size = new Size(97, 20);
            labelTanggalLahirSiswa.TabIndex = 3;
            labelTanggalLahirSiswa.Text = "Tanggal Lahir";
            labelTanggalLahirSiswa.Click += labelTanggalLahirSiswa_Click;
            // 
            // labelNISNSiswa
            // 
            labelNISNSiswa.AutoSize = true;
            labelNISNSiswa.BackColor = Color.Transparent;
            labelNISNSiswa.ForeColor = Color.Black;
            labelNISNSiswa.Location = new Point(34, 166);
            labelNISNSiswa.Name = "labelNISNSiswa";
            labelNISNSiswa.Size = new Size(43, 20);
            labelNISNSiswa.TabIndex = 2;
            labelNISNSiswa.Text = "NISN";
            labelNISNSiswa.Click += labelNISNSiswa_Click;
            // 
            // labelNamaSiswa
            // 
            labelNamaSiswa.AutoSize = true;
            labelNamaSiswa.BackColor = Color.Transparent;
            labelNamaSiswa.ForeColor = Color.Black;
            labelNamaSiswa.Location = new Point(34, 116);
            labelNamaSiswa.Name = "labelNamaSiswa";
            labelNamaSiswa.Size = new Size(49, 20);
            labelNamaSiswa.TabIndex = 1;
            labelNamaSiswa.Text = "Nama";
            labelNamaSiswa.Click += labelNamaSiswa_Click;
            // 
            // labelHalaman
            // 
            labelHalaman.AutoSize = true;
            labelHalaman.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHalaman.ForeColor = Color.Black;
            labelHalaman.Location = new Point(34, 34);
            labelHalaman.Name = "labelHalaman";
            labelHalaman.Size = new Size(176, 35);
            labelHalaman.TabIndex = 0;
            labelHalaman.Text = "Tambah Siswa";
            labelHalaman.Click += labelHalaman_Click;
            // 
            // siswa_tambah
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1445, 882);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "siswa_tambah";
            Text = "siswa_tambah";
            Load += siswa_tambah_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelHalaman;
        private TextBox textBoxtanggalsiswa;
        private TextBox textBoxnisnsiswa;
        private TextBox textBoxnamasiswa;
        private Label labelTanggalLahirSiswa;
        private Label labelNISNSiswa;
        private Label labelNamaSiswa;
        private Button submit;
        private TextBox textBoxalamatsiswa;
        private TextBox textBoxlahirsiswa;
        private TextBox textBoxnohpsiswa;
        private Label labelKelasSiswa;
        private Label labelAlamatSiswa;
        private Label labelTempatLahirSiswa;
        private Label labelNoTelpSiswa;
        private ComboBox comboBoxkelassiswa;
    }
}