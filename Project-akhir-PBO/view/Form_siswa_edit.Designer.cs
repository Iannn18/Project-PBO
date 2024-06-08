namespace Project_akhir_PBO.view
{
    partial class Form_siswa_edit
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
            panelEditSiswa = new Panel();
            btnKembali = new Button();
            btnSubmit = new Button();
            labelKelas = new Label();
            cBoxKelas = new ComboBox();
            labelAlamat = new Label();
            tBoxAlamat = new TextBox();
            labelTmptLahir = new Label();
            tBoxTmptLahir = new TextBox();
            labelNoTelp = new Label();
            labelTglLahir = new Label();
            tBoxNoTelp = new TextBox();
            labelNISN = new Label();
            tBoxTglLahir = new TextBox();
            labelNamaSw = new Label();
            tBoxNISN = new TextBox();
            tBoxNamaSw = new TextBox();
            labelHalaman = new Label();
            panelEditSiswa.SuspendLayout();
            SuspendLayout();
            // 
            // panelEditSiswa
            // 
            panelEditSiswa.BorderStyle = BorderStyle.FixedSingle;
            panelEditSiswa.Controls.Add(btnKembali);
            panelEditSiswa.Controls.Add(btnSubmit);
            panelEditSiswa.Controls.Add(labelKelas);
            panelEditSiswa.Controls.Add(cBoxKelas);
            panelEditSiswa.Controls.Add(labelAlamat);
            panelEditSiswa.Controls.Add(tBoxAlamat);
            panelEditSiswa.Controls.Add(labelTmptLahir);
            panelEditSiswa.Controls.Add(tBoxTmptLahir);
            panelEditSiswa.Controls.Add(labelNoTelp);
            panelEditSiswa.Controls.Add(labelTglLahir);
            panelEditSiswa.Controls.Add(tBoxNoTelp);
            panelEditSiswa.Controls.Add(labelNISN);
            panelEditSiswa.Controls.Add(tBoxTglLahir);
            panelEditSiswa.Controls.Add(labelNamaSw);
            panelEditSiswa.Controls.Add(tBoxNISN);
            panelEditSiswa.Controls.Add(tBoxNamaSw);
            panelEditSiswa.Controls.Add(labelHalaman);
            panelEditSiswa.Location = new Point(488, 57);
            panelEditSiswa.Margin = new Padding(3, 4, 3, 4);
            panelEditSiswa.Name = "panelEditSiswa";
            panelEditSiswa.Size = new Size(650, 557);
            panelEditSiswa.TabIndex = 0;
            // 
            // btnKembali
            // 
            btnKembali.ForeColor = Color.Black;
            btnKembali.Location = new Point(383, 474);
            btnKembali.Margin = new Padding(3, 4, 3, 4);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(96, 40);
            btnKembali.TabIndex = 10;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            btnKembali.Click += btnKembali_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.Black;
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(181, 474);
            btnSubmit.Margin = new Padding(3, 4, 3, 4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(89, 40);
            btnSubmit.TabIndex = 14;
            btnSubmit.Text = "Ubah Data";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // labelKelas
            // 
            labelKelas.AutoSize = true;
            labelKelas.ForeColor = Color.Black;
            labelKelas.Location = new Point(34, 405);
            labelKelas.Name = "labelKelas";
            labelKelas.Size = new Size(51, 20);
            labelKelas.TabIndex = 13;
            labelKelas.Text = "Kelas :";
            // 
            // cBoxKelas
            // 
            cBoxKelas.FormattingEnabled = true;
            cBoxKelas.Items.AddRange(new object[] { "X-A", "X-B", "X-C", "X-D", "X-E", "X-F", "X-G", "X-H", "XI-A", "XI-B", "XI-C", "XI-D", "XI-E", "XI-F", "XI-G", "XI-H", "XII-A", "XII-B", "XII-C", "XII-D", "XII-E", "XII-F", "XII-G", "XII-H" });
            cBoxKelas.Location = new Point(200, 401);
            cBoxKelas.Name = "cBoxKelas";
            cBoxKelas.Size = new Size(400, 28);
            cBoxKelas.TabIndex = 12;
            cBoxKelas.SelectedIndexChanged += cBoxKelas_SelectedIndexChanged;
            // 
            // labelAlamat
            // 
            labelAlamat.AutoSize = true;
            labelAlamat.ForeColor = Color.Black;
            labelAlamat.Location = new Point(35, 348);
            labelAlamat.Name = "labelAlamat";
            labelAlamat.Size = new Size(64, 20);
            labelAlamat.TabIndex = 8;
            labelAlamat.Text = "Alamat :";
            // 
            // tBoxAlamat
            // 
            tBoxAlamat.Location = new Point(200, 348);
            tBoxAlamat.Name = "tBoxAlamat";
            tBoxAlamat.Size = new Size(400, 27);
            tBoxAlamat.TabIndex = 7;
            tBoxAlamat.TextChanged += tBoxAlamat_TextChanged;
            // 
            // labelTmptLahir
            // 
            labelTmptLahir.AutoSize = true;
            labelTmptLahir.ForeColor = Color.Black;
            labelTmptLahir.Location = new Point(35, 298);
            labelTmptLahir.Name = "labelTmptLahir";
            labelTmptLahir.Size = new Size(102, 20);
            labelTmptLahir.TabIndex = 6;
            labelTmptLahir.Text = "Tempat Lahir :";
            // 
            // tBoxTmptLahir
            // 
            tBoxTmptLahir.Location = new Point(200, 298);
            tBoxTmptLahir.Name = "tBoxTmptLahir";
            tBoxTmptLahir.Size = new Size(400, 27);
            tBoxTmptLahir.TabIndex = 5;
            tBoxTmptLahir.TextChanged += tBoxTmptLahir_TextChanged;
            // 
            // labelNoTelp
            // 
            labelNoTelp.AutoSize = true;
            labelNoTelp.ForeColor = Color.Black;
            labelNoTelp.Location = new Point(35, 250);
            labelNoTelp.Name = "labelNoTelp";
            labelNoTelp.Size = new Size(120, 20);
            labelNoTelp.TabIndex = 4;
            labelNoTelp.Text = "Nomor Telepon :";
            // 
            // labelTglLahir
            // 
            labelTglLahir.AutoSize = true;
            labelTglLahir.ForeColor = Color.Black;
            labelTglLahir.Location = new Point(35, 198);
            labelTglLahir.Name = "labelTglLahir";
            labelTglLahir.Size = new Size(108, 20);
            labelTglLahir.TabIndex = 4;
            labelTglLahir.Text = "Tanggal Lahir : ";
            // 
            // tBoxNoTelp
            // 
            tBoxNoTelp.Location = new Point(200, 250);
            tBoxNoTelp.Name = "tBoxNoTelp";
            tBoxNoTelp.Size = new Size(400, 27);
            tBoxNoTelp.TabIndex = 3;
            tBoxNoTelp.TextChanged += tBoxNoTelp_TextChanged;
            // 
            // labelNISN
            // 
            labelNISN.AutoSize = true;
            labelNISN.ForeColor = Color.Black;
            labelNISN.Location = new Point(35, 150);
            labelNISN.Name = "labelNISN";
            labelNISN.Size = new Size(50, 20);
            labelNISN.TabIndex = 4;
            labelNISN.Text = "NISN :";
            // 
            // tBoxTglLahir
            // 
            tBoxTglLahir.Location = new Point(200, 198);
            tBoxTglLahir.Name = "tBoxTglLahir";
            tBoxTglLahir.Size = new Size(400, 27);
            tBoxTglLahir.TabIndex = 3;
            tBoxTglLahir.TextChanged += tBoxTglLahir_TextChanged;
            // 
            // labelNamaSw
            // 
            labelNamaSw.AutoSize = true;
            labelNamaSw.ForeColor = Color.Black;
            labelNamaSw.Location = new Point(35, 99);
            labelNamaSw.Name = "labelNamaSw";
            labelNamaSw.Size = new Size(101, 20);
            labelNamaSw.TabIndex = 2;
            labelNamaSw.Text = "Nama Siswa : ";
            // 
            // tBoxNISN
            // 
            tBoxNISN.Location = new Point(200, 150);
            tBoxNISN.Name = "tBoxNISN";
            tBoxNISN.Size = new Size(400, 27);
            tBoxNISN.TabIndex = 3;
            tBoxNISN.TextChanged += tBoxNISN_TextChanged;
            // 
            // tBoxNamaSw
            // 
            tBoxNamaSw.Location = new Point(200, 99);
            tBoxNamaSw.Name = "tBoxNamaSw";
            tBoxNamaSw.Size = new Size(400, 27);
            tBoxNamaSw.TabIndex = 1;
            tBoxNamaSw.TextChanged += tBoxNamaSw_TextChanged;
            // 
            // labelHalaman
            // 
            labelHalaman.AutoSize = true;
            labelHalaman.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHalaman.ForeColor = Color.Black;
            labelHalaman.Location = new Point(85, 27);
            labelHalaman.Name = "labelHalaman";
            labelHalaman.Size = new Size(102, 28);
            labelHalaman.TabIndex = 0;
            labelHalaman.Text = "Edit Siswa";
            // 
            // Form_siswa_edit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1445, 883);
            Controls.Add(panelEditSiswa);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_siswa_edit";
            Text = "Form_siswa_edit";
            Load += Form_siswa_edit_Load;
            panelEditSiswa.ResumeLayout(false);
            panelEditSiswa.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelEditSiswa;
        private Label labelHalaman;
        private TextBox tBoxNamaSw;
        private Label labelNamaSw;
        private Label labelNISN;
        private TextBox tBoxNISN;
        private Label labelTglLahir;
        private TextBox tBoxTglLahir;
        private Label labelNoTelp;
        private TextBox tBoxNoTelp;
        private Label labelAlamat;
        private TextBox tBoxAlamat;
        private Label labelTmptLahir;
        private TextBox tBoxTmptLahir;
        private Label labelKelas;
        private ComboBox cBoxKelas;
        private Button btnSubmit;
        private Button btnKembali;
    }
}