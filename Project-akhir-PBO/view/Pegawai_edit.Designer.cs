namespace Project_akhir_PBO
{
    partial class Pegawai_edit
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
            labelHalaman = new Label();
            labelNama = new Label();
            labelNUPTK = new Label();
            labelTglLahir = new Label();
            tBoxNamaPegawai = new TextBox();
            tBoxNUPTK = new TextBox();
            tBoxTglLahirPgw = new TextBox();
            btnSubmit = new Button();
            btnKembali = new Button();
            panelEditPegawai = new Panel();
            labelAlamat = new Label();
            labelTmptLahir = new Label();
            labelTelepon = new Label();
            tBoxAlamatPgw = new TextBox();
            tBoxTmptLahirPgw = new TextBox();
            tBoxTeleponPgw = new TextBox();
            labelJabatan = new Label();
            cBoxJabatan = new ComboBox();
            panelEditPegawai.SuspendLayout();
            SuspendLayout();
            // 
            // labelHalaman
            // 
            labelHalaman.AutoSize = true;
            labelHalaman.BackColor = Color.Transparent;
            labelHalaman.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            labelHalaman.ForeColor = Color.Black;
            labelHalaman.Location = new Point(74, 20);
            labelHalaman.Name = "labelHalaman";
            labelHalaman.Size = new Size(142, 21);
            labelHalaman.TabIndex = 1;
            labelHalaman.Text = "Edit Akun Pegawai";
            labelHalaman.Click += labelHalaman_Click;
            // 
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.BackColor = Color.Transparent;
            labelNama.ForeColor = Color.Black;
            labelNama.Location = new Point(25, 64);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(39, 15);
            labelNama.TabIndex = 2;
            labelNama.Text = "Nama";
            labelNama.Click += labelNama_Click;
            // 
            // labelNUPTK
            // 
            labelNUPTK.AutoSize = true;
            labelNUPTK.BackColor = Color.Transparent;
            labelNUPTK.ForeColor = Color.Black;
            labelNUPTK.Location = new Point(25, 97);
            labelNUPTK.Name = "labelNUPTK";
            labelNUPTK.Size = new Size(44, 15);
            labelNUPTK.TabIndex = 3;
            labelNUPTK.Text = "NUPTK";
            labelNUPTK.Click += labelNUPTK_Click;
            // 
            // labelTglLahir
            // 
            labelTglLahir.AutoSize = true;
            labelTglLahir.BackColor = Color.Transparent;
            labelTglLahir.ForeColor = Color.Black;
            labelTglLahir.Location = new Point(24, 132);
            labelTglLahir.Name = "labelTglLahir";
            labelTglLahir.Size = new Size(77, 15);
            labelTglLahir.TabIndex = 4;
            labelTglLahir.Text = "Tanggal Lahir";
            labelTglLahir.Click += labelTglLahir_Click;
            // 
            // tBoxNamaPegawai
            // 
            tBoxNamaPegawai.Font = new Font("Segoe UI", 8F);
            tBoxNamaPegawai.ForeColor = SystemColors.GrayText;
            tBoxNamaPegawai.Location = new Point(171, 60);
            tBoxNamaPegawai.Name = "tBoxNamaPegawai";
            tBoxNamaPegawai.Size = new Size(373, 22);
            tBoxNamaPegawai.TabIndex = 5;
            tBoxNamaPegawai.TextChanged += tBoxNamaPegawai_TextChanged;
            // 
            // tBoxNUPTK
            // 
            tBoxNUPTK.Font = new Font("Segoe UI", 8F);
            tBoxNUPTK.ForeColor = SystemColors.GrayText;
            tBoxNUPTK.Location = new Point(171, 95);
            tBoxNUPTK.Name = "tBoxNUPTK";
            tBoxNUPTK.Size = new Size(373, 22);
            tBoxNUPTK.TabIndex = 6;
            tBoxNUPTK.TextChanged += tBoxNUPTK_TextChanged;
            // 
            // tBoxTglLahirPgw
            // 
            tBoxTglLahirPgw.Font = new Font("Segoe UI", 8F);
            tBoxTglLahirPgw.ForeColor = SystemColors.GrayText;
            tBoxTglLahirPgw.Location = new Point(171, 130);
            tBoxTglLahirPgw.Name = "tBoxTglLahirPgw";
            tBoxTglLahirPgw.Size = new Size(373, 22);
            tBoxTglLahirPgw.TabIndex = 7;
            tBoxTglLahirPgw.TextChanged += tBoxTglLahirPgw_TextChanged;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.Black;
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(192, 356);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(78, 30);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "Ubah Data";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnKembali
            // 
            btnKembali.ForeColor = Color.Black;
            btnKembali.Location = new Point(298, 356);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(84, 30);
            btnKembali.TabIndex = 9;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            btnKembali.Click += btnKembali_Click;
            // 
            // panelEditPegawai
            // 
            panelEditPegawai.BorderStyle = BorderStyle.FixedSingle;
            panelEditPegawai.Controls.Add(labelAlamat);
            panelEditPegawai.Controls.Add(labelTmptLahir);
            panelEditPegawai.Controls.Add(labelTelepon);
            panelEditPegawai.Controls.Add(tBoxAlamatPgw);
            panelEditPegawai.Controls.Add(tBoxTmptLahirPgw);
            panelEditPegawai.Controls.Add(tBoxTeleponPgw);
            panelEditPegawai.Controls.Add(labelJabatan);
            panelEditPegawai.Controls.Add(cBoxJabatan);
            panelEditPegawai.Controls.Add(labelHalaman);
            panelEditPegawai.Controls.Add(btnKembali);
            panelEditPegawai.Controls.Add(labelNama);
            panelEditPegawai.Controls.Add(btnSubmit);
            panelEditPegawai.Controls.Add(labelNUPTK);
            panelEditPegawai.Controls.Add(tBoxNUPTK);
            panelEditPegawai.Controls.Add(tBoxTglLahirPgw);
            panelEditPegawai.Controls.Add(labelTglLahir);
            panelEditPegawai.Controls.Add(tBoxNamaPegawai);
            panelEditPegawai.Location = new Point(427, 43);
            panelEditPegawai.Name = "panelEditPegawai";
            panelEditPegawai.Size = new Size(569, 418);
            panelEditPegawai.TabIndex = 10;
            panelEditPegawai.Paint += panelEditPegawai_Paint;
            // 
            // labelAlamat
            // 
            labelAlamat.AutoSize = true;
            labelAlamat.ForeColor = Color.Black;
            labelAlamat.Location = new Point(25, 243);
            labelAlamat.Name = "labelAlamat";
            labelAlamat.Size = new Size(45, 15);
            labelAlamat.TabIndex = 18;
            labelAlamat.Text = "Alamat";
            labelAlamat.Click += labelAlamat_Click;
            // 
            // labelTmptLahir
            // 
            labelTmptLahir.AutoSize = true;
            labelTmptLahir.ForeColor = Color.Black;
            labelTmptLahir.Location = new Point(25, 210);
            labelTmptLahir.Name = "labelTmptLahir";
            labelTmptLahir.Size = new Size(75, 15);
            labelTmptLahir.TabIndex = 17;
            labelTmptLahir.Text = "Tempat Lahir";
            labelTmptLahir.Click += labelTmptLahir_Click;
            // 
            // labelTelepon
            // 
            labelTelepon.AutoSize = true;
            labelTelepon.ForeColor = Color.Black;
            labelTelepon.Location = new Point(25, 169);
            labelTelepon.Name = "labelTelepon";
            labelTelepon.Size = new Size(70, 15);
            labelTelepon.TabIndex = 16;
            labelTelepon.Text = "No. Telepon";
            labelTelepon.Click += labelTelepon_Click;
            // 
            // tBoxAlamatPgw
            // 
            tBoxAlamatPgw.Location = new Point(171, 240);
            tBoxAlamatPgw.Name = "tBoxAlamatPgw";
            tBoxAlamatPgw.Size = new Size(373, 23);
            tBoxAlamatPgw.TabIndex = 14;
            tBoxAlamatPgw.TextChanged += tBoxAlamatPgw_TextChanged;
            // 
            // tBoxTmptLahirPgw
            // 
            tBoxTmptLahirPgw.Location = new Point(171, 202);
            tBoxTmptLahirPgw.Name = "tBoxTmptLahirPgw";
            tBoxTmptLahirPgw.Size = new Size(372, 23);
            tBoxTmptLahirPgw.TabIndex = 13;
            tBoxTmptLahirPgw.TextChanged += tBoxTmptLahirPgw_TextChanged;
            // 
            // tBoxTeleponPgw
            // 
            tBoxTeleponPgw.Location = new Point(171, 166);
            tBoxTeleponPgw.Name = "tBoxTeleponPgw";
            tBoxTeleponPgw.Size = new Size(373, 23);
            tBoxTeleponPgw.TabIndex = 12;
            tBoxTeleponPgw.TextChanged += tBoxTeleponPgw_TextChanged;
            // 
            // labelJabatan
            // 
            labelJabatan.AutoSize = true;
            labelJabatan.ForeColor = Color.Black;
            labelJabatan.Location = new Point(25, 280);
            labelJabatan.Name = "labelJabatan";
            labelJabatan.Size = new Size(47, 15);
            labelJabatan.TabIndex = 11;
            labelJabatan.Text = "Jabatan";
            labelJabatan.Click += labelJabatan_Click;
            // 
            // cBoxJabatan
            // 
            cBoxJabatan.FormattingEnabled = true;
            cBoxJabatan.Items.AddRange(new object[] { "Guru", "Staff TU" });
            cBoxJabatan.Location = new Point(171, 277);
            cBoxJabatan.Margin = new Padding(3, 2, 3, 2);
            cBoxJabatan.Name = "cBoxJabatan";
            cBoxJabatan.Size = new Size(373, 23);
            cBoxJabatan.TabIndex = 10;
            cBoxJabatan.SelectedIndexChanged += cBoxJabatan_SelectedIndexChanged;
            // 
            // Pegawai_edit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 505);
            Controls.Add(panelEditPegawai);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Pegawai_edit";
            Text = "Pegawai_edit";
            Load += Pegawai_edit_Load;
            panelEditPegawai.ResumeLayout(false);
            panelEditPegawai.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label labelHalaman;
        private Label labelNama;
        private Label labelNUPTK;
        private Label labelTglLahir;
        private TextBox tBoxNamaPegawai;
        private TextBox tBoxNUPTK;
        private TextBox tBoxTglLahirPgw;
        private Button btnSubmit;
        private Button btnKembali;
        private Panel panelEditPegawai;
        private Label labelJabatan;
        private ComboBox cBoxJabatan;
        private TextBox tBoxTmptLahirPgw;
        private TextBox tBoxTeleponPgw;
        private TextBox tBoxAlamatPgw;
        private Label labelAlamat;
        private Label labelTmptLahir;
        private Label labelTelepon;
    }
}
