namespace Project_akhir_PBO
{
    partial class Pegawai_tambah
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
            panelPegawai = new Panel();
            btnKembali = new Button();
            labelJbtnPgw = new Label();
            labelAlmtPgw = new Label();
            labelTmptLahirPgw = new Label();
            cBoxJabatan = new ComboBox();
            tBoxAlamatPegawai = new TextBox();
            tBoxTmptLahirPegawai = new TextBox();
            tBoxTelponPegawai = new TextBox();
            labelTelponPgw = new Label();
            btnSubmitPgw = new Button();
            labelTglLahirPgw = new Label();
            labelNUPTK = new Label();
            labelNamaPgw = new Label();
            labelJudulHalaman = new Label();
            tBoxTglLahirPegawai = new TextBox();
            tBoxNUPTK = new TextBox();
            tBoxNamaPegawai = new TextBox();
            panelPegawai.SuspendLayout();
            SuspendLayout();
            // 
            // panelPegawai
            // 
            panelPegawai.BorderStyle = BorderStyle.FixedSingle;
            panelPegawai.Controls.Add(btnKembali);
            panelPegawai.Controls.Add(labelJbtnPgw);
            panelPegawai.Controls.Add(labelAlmtPgw);
            panelPegawai.Controls.Add(labelTmptLahirPgw);
            panelPegawai.Controls.Add(cBoxJabatan);
            panelPegawai.Controls.Add(tBoxAlamatPegawai);
            panelPegawai.Controls.Add(tBoxTmptLahirPegawai);
            panelPegawai.Controls.Add(tBoxTelponPegawai);
            panelPegawai.Controls.Add(labelTelponPgw);
            panelPegawai.Controls.Add(btnSubmitPgw);
            panelPegawai.Controls.Add(labelTglLahirPgw);
            panelPegawai.Controls.Add(labelNUPTK);
            panelPegawai.Controls.Add(labelNamaPgw);
            panelPegawai.Controls.Add(labelJudulHalaman);
            panelPegawai.Controls.Add(tBoxTglLahirPegawai);
            panelPegawai.Controls.Add(tBoxNUPTK);
            panelPegawai.Controls.Add(tBoxNamaPegawai);
            panelPegawai.Location = new Point(584, 46);
            panelPegawai.Margin = new Padding(3, 4, 3, 4);
            panelPegawai.Name = "panelPegawai";
            panelPegawai.Size = new Size(635, 600);
            panelPegawai.TabIndex = 1;
            panelPegawai.Paint += labelJudulHalaman_Paint;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.Black;
            btnKembali.ForeColor = Color.White;
            btnKembali.Location = new Point(191, 512);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(258, 34);
            btnKembali.TabIndex = 17;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // labelJbtnPgw
            // 
            labelJbtnPgw.AutoSize = true;
            labelJbtnPgw.ForeColor = Color.Black;
            labelJbtnPgw.Location = new Point(37, 366);
            labelJbtnPgw.Name = "labelJbtnPgw";
            labelJbtnPgw.Size = new Size(60, 20);
            labelJbtnPgw.TabIndex = 16;
            labelJbtnPgw.Text = "Jabatan";
            // 
            // labelAlmtPgw
            // 
            labelAlmtPgw.AutoSize = true;
            labelAlmtPgw.ForeColor = Color.Black;
            labelAlmtPgw.Location = new Point(37, 316);
            labelAlmtPgw.Name = "labelAlmtPgw";
            labelAlmtPgw.Size = new Size(57, 20);
            labelAlmtPgw.TabIndex = 15;
            labelAlmtPgw.Text = "Alamat";
            // 
            // labelTmptLahirPgw
            // 
            labelTmptLahirPgw.AutoSize = true;
            labelTmptLahirPgw.ForeColor = Color.Black;
            labelTmptLahirPgw.Location = new Point(34, 268);
            labelTmptLahirPgw.Name = "labelTmptLahirPgw";
            labelTmptLahirPgw.Size = new Size(95, 20);
            labelTmptLahirPgw.TabIndex = 14;
            labelTmptLahirPgw.Text = "Tempat Lahir";
            // 
            // cBoxJabatan
            // 
            cBoxJabatan.FormattingEnabled = true;
            cBoxJabatan.Items.AddRange(new object[] { "Staff TU", "Guru" });
            cBoxJabatan.Location = new Point(191, 362);
            cBoxJabatan.Margin = new Padding(3, 4, 3, 4);
            cBoxJabatan.Name = "cBoxJabatan";
            cBoxJabatan.Size = new Size(410, 28);
            cBoxJabatan.TabIndex = 13;
            cBoxJabatan.SelectedIndexChanged += cBoxJabatan_SelectedIndexChanged;
            // 
            // tBoxAlamatPegawai
            // 
            tBoxAlamatPegawai.Location = new Point(191, 312);
            tBoxAlamatPegawai.Margin = new Padding(3, 4, 3, 4);
            tBoxAlamatPegawai.Name = "tBoxAlamatPegawai";
            tBoxAlamatPegawai.Size = new Size(410, 27);
            tBoxAlamatPegawai.TabIndex = 12;
            tBoxAlamatPegawai.TextChanged += tBoxAlamatPegawai_TextChanged;
            // 
            // tBoxTmptLahirPegawai
            // 
            tBoxTmptLahirPegawai.Location = new Point(191, 264);
            tBoxTmptLahirPegawai.Margin = new Padding(3, 4, 3, 4);
            tBoxTmptLahirPegawai.Name = "tBoxTmptLahirPegawai";
            tBoxTmptLahirPegawai.Size = new Size(410, 27);
            tBoxTmptLahirPegawai.TabIndex = 11;
            tBoxTmptLahirPegawai.TextChanged += tBoxTmptLahirPegawai_TextChanged;
            // 
            // tBoxTelponPegawai
            // 
            tBoxTelponPegawai.Location = new Point(191, 218);
            tBoxTelponPegawai.Margin = new Padding(3, 4, 3, 4);
            tBoxTelponPegawai.Name = "tBoxTelponPegawai";
            tBoxTelponPegawai.Size = new Size(410, 27);
            tBoxTelponPegawai.TabIndex = 10;
            tBoxTelponPegawai.TextChanged += tBoxTelponPegawai_TextChanged;
            // 
            // labelTelponPgw
            // 
            labelTelponPgw.AutoSize = true;
            labelTelponPgw.ForeColor = Color.Black;
            labelTelponPgw.Location = new Point(37, 222);
            labelTelponPgw.Name = "labelTelponPgw";
            labelTelponPgw.Size = new Size(89, 20);
            labelTelponPgw.TabIndex = 9;
            labelTelponPgw.Text = "No. Telepon";
            // 
            // btnSubmitPgw
            // 
            btnSubmitPgw.BackColor = SystemColors.ActiveCaptionText;
            btnSubmitPgw.ForeColor = SystemColors.ButtonHighlight;
            btnSubmitPgw.Location = new Point(23, 467);
            btnSubmitPgw.Margin = new Padding(3, 4, 3, 4);
            btnSubmitPgw.Name = "btnSubmitPgw";
            btnSubmitPgw.Size = new Size(587, 38);
            btnSubmitPgw.TabIndex = 8;
            btnSubmitPgw.Text = "Submit";
            btnSubmitPgw.UseVisualStyleBackColor = false;
            btnSubmitPgw.Click += btnSubmitPgw_Click;
            // 
            // labelTglLahirPgw
            // 
            labelTglLahirPgw.AutoSize = true;
            labelTglLahirPgw.ForeColor = Color.Black;
            labelTglLahirPgw.Location = new Point(37, 178);
            labelTglLahirPgw.Name = "labelTglLahirPgw";
            labelTglLahirPgw.Size = new Size(97, 20);
            labelTglLahirPgw.TabIndex = 7;
            labelTglLahirPgw.Text = "Tanggal Lahir";
            // 
            // labelNUPTK
            // 
            labelNUPTK.AutoSize = true;
            labelNUPTK.ForeColor = Color.Black;
            labelNUPTK.Location = new Point(37, 138);
            labelNUPTK.Name = "labelNUPTK";
            labelNUPTK.Size = new Size(55, 20);
            labelNUPTK.TabIndex = 6;
            labelNUPTK.Text = "NUPTK";
            // 
            // labelNamaPgw
            // 
            labelNamaPgw.AutoSize = true;
            labelNamaPgw.ForeColor = Color.Black;
            labelNamaPgw.Location = new Point(37, 96);
            labelNamaPgw.Name = "labelNamaPgw";
            labelNamaPgw.Size = new Size(49, 20);
            labelNamaPgw.TabIndex = 5;
            labelNamaPgw.Text = "Nama";
            // 
            // labelJudulHalaman
            // 
            labelJudulHalaman.AutoSize = true;
            labelJudulHalaman.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelJudulHalaman.ForeColor = Color.Black;
            labelJudulHalaman.Location = new Point(37, 14);
            labelJudulHalaman.Name = "labelJudulHalaman";
            labelJudulHalaman.Size = new Size(206, 35);
            labelJudulHalaman.TabIndex = 4;
            labelJudulHalaman.Text = "Tambah Pegawai";
            labelJudulHalaman.Click += labelJudulHalaman_Click;
            // 
            // tBoxTglLahirPegawai
            // 
            tBoxTglLahirPegawai.Font = new Font("Segoe UI", 8F);
            tBoxTglLahirPegawai.ForeColor = SystemColors.GrayText;
            tBoxTglLahirPegawai.Location = new Point(191, 174);
            tBoxTglLahirPegawai.Margin = new Padding(3, 4, 3, 4);
            tBoxTglLahirPegawai.Name = "tBoxTglLahirPegawai";
            tBoxTglLahirPegawai.Size = new Size(410, 25);
            tBoxTglLahirPegawai.TabIndex = 3;
            tBoxTglLahirPegawai.TextChanged += tBoxTglLahirPegawai_TextChanged;
            // 
            // tBoxNUPTK
            // 
            tBoxNUPTK.Font = new Font("Segoe UI", 8F);
            tBoxNUPTK.ForeColor = SystemColors.GrayText;
            tBoxNUPTK.Location = new Point(191, 134);
            tBoxNUPTK.Margin = new Padding(3, 4, 3, 4);
            tBoxNUPTK.Name = "tBoxNUPTK";
            tBoxNUPTK.Size = new Size(410, 25);
            tBoxNUPTK.TabIndex = 2;
            tBoxNUPTK.TextChanged += tBoxNUPTK_TextChanged;
            // 
            // tBoxNamaPegawai
            // 
            tBoxNamaPegawai.Font = new Font("Segoe UI", 8F);
            tBoxNamaPegawai.ForeColor = SystemColors.GrayText;
            tBoxNamaPegawai.Location = new Point(191, 96);
            tBoxNamaPegawai.Margin = new Padding(3, 4, 3, 4);
            tBoxNamaPegawai.Name = "tBoxNamaPegawai";
            tBoxNamaPegawai.Size = new Size(410, 25);
            tBoxNamaPegawai.TabIndex = 1;
            tBoxNamaPegawai.TextChanged += tBoxNamaPegawai_TextChanged;
            // 
            // Pegawai_tambah
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1445, 882);
            Controls.Add(panelPegawai);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Pegawai_tambah";
            Text = "Pegawai_tambah";
            Load += Pegawai_tambah_Load;
            panelPegawai.ResumeLayout(false);
            panelPegawai.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelPegawai;
        private TextBox tBoxNamaPegawai;
        private TextBox tBoxTglLahirPegawai;
        private TextBox tBoxNUPTK;
        private Label labelJudulHalaman;
        private Label labelTglLahirPgw;
        private Label labelNUPTK;
        private Label labelNamaPgw;
        private Button btnSubmitPgw;
        private Label labelTelponPgw;
        private Label labelTmptLahirPgw;
        private ComboBox cBoxJabatan;
        private TextBox tBoxAlamatPegawai;
        private TextBox tBoxTmptLahirPegawai;
        private TextBox tBoxTelponPegawai;
        private Label labelAlmtPgw;
        private Label labelJbtnPgw;
        private Button btnKembali;
    }
}