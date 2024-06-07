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
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            textBoxalamatsiswa = new TextBox();
            textBoxlahirsiswa = new TextBox();
            textBoxnohpsiswa = new TextBox();
            submit = new Button();
            textBoxtanggalsiswa = new TextBox();
            textBoxnisnsiswa = new TextBox();
            textBoxnamasiswa = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(comboBoxkelassiswa);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBoxalamatsiswa);
            panel1.Controls.Add(textBoxlahirsiswa);
            panel1.Controls.Add(textBoxnohpsiswa);
            panel1.Controls.Add(submit);
            panel1.Controls.Add(textBoxtanggalsiswa);
            panel1.Controls.Add(textBoxnisnsiswa);
            panel1.Controls.Add(textBoxnamasiswa);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(733, 55);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(673, 727);
            panel1.TabIndex = 0;
            // 
            // comboBoxkelassiswa
            // 
            comboBoxkelassiswa.FormattingEnabled = true;
            comboBoxkelassiswa.Items.AddRange(new object[] { "X-A", "X-B", "X-C", "X-D", "X-E", "X-F", "X-G", "X-H", "XI-A", "XI-B", "XI-C", "XI-D", "XI-E", "XI-F", "XI-G", "XI-H", "XII-A", "XII-B", "XII-C", "XII-D", "XII-E", "XII-F", "XII-G", "XII-H" });
            comboBoxkelassiswa.Location = new Point(244, 508);
            comboBoxkelassiswa.Margin = new Padding(4, 5, 4, 5);
            comboBoxkelassiswa.Name = "comboBoxkelassiswa";
            comboBoxkelassiswa.Size = new Size(380, 33);
            comboBoxkelassiswa.TabIndex = 16;
            comboBoxkelassiswa.SelectedIndexChanged += comboBoxkelassiswa_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Black;
            label8.Location = new Point(47, 513);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(52, 25);
            label8.TabIndex = 15;
            label8.Text = "Kelas";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Black;
            label7.Location = new Point(44, 445);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(68, 25);
            label7.TabIndex = 14;
            label7.Text = "Alamat";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(43, 382);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(112, 25);
            label6.TabIndex = 13;
            label6.Text = "Tempat Lahir";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(43, 322);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(106, 25);
            label5.TabIndex = 12;
            label5.Text = "No. Telepon";
            // 
            // textBoxalamatsiswa
            // 
            textBoxalamatsiswa.Location = new Point(246, 440);
            textBoxalamatsiswa.Margin = new Padding(4, 5, 4, 5);
            textBoxalamatsiswa.Name = "textBoxalamatsiswa";
            textBoxalamatsiswa.Size = new Size(378, 31);
            textBoxalamatsiswa.TabIndex = 10;
            textBoxalamatsiswa.TextChanged += textBoxalamatsiswa_TextChanged;
            // 
            // textBoxlahirsiswa
            // 
            textBoxlahirsiswa.Location = new Point(244, 377);
            textBoxlahirsiswa.Margin = new Padding(4, 5, 4, 5);
            textBoxlahirsiswa.Name = "textBoxlahirsiswa";
            textBoxlahirsiswa.Size = new Size(380, 31);
            textBoxlahirsiswa.TabIndex = 9;
            textBoxlahirsiswa.TextChanged += textBoxlahirsiswa_TextChanged;
            // 
            // textBoxnohpsiswa
            // 
            textBoxnohpsiswa.Location = new Point(244, 317);
            textBoxnohpsiswa.Margin = new Padding(4, 5, 4, 5);
            textBoxnohpsiswa.Name = "textBoxnohpsiswa";
            textBoxnohpsiswa.Size = new Size(380, 31);
            textBoxnohpsiswa.TabIndex = 8;
            textBoxnohpsiswa.TextChanged += textBoxnohpsiswa_TextChanged;
            // 
            // submit
            // 
            submit.BackColor = SystemColors.ActiveCaptionText;
            submit.ForeColor = Color.White;
            submit.Location = new Point(47, 618);
            submit.Margin = new Padding(4, 5, 4, 5);
            submit.Name = "submit";
            submit.Size = new Size(579, 47);
            submit.TabIndex = 7;
            submit.Text = "Submit";
            submit.UseVisualStyleBackColor = false;
            submit.Click += button1_Click;
            // 
            // textBoxtanggalsiswa
            // 
            textBoxtanggalsiswa.Font = new Font("Segoe UI", 8F);
            textBoxtanggalsiswa.ForeColor = SystemColors.GrayText;
            textBoxtanggalsiswa.Location = new Point(244, 258);
            textBoxtanggalsiswa.Margin = new Padding(4, 5, 4, 5);
            textBoxtanggalsiswa.Name = "textBoxtanggalsiswa";
            textBoxtanggalsiswa.Size = new Size(380, 29);
            textBoxtanggalsiswa.TabIndex = 6;
            textBoxtanggalsiswa.TextChanged += textBoxtanggalsiswa_TextChanged;
            // 
            // textBoxnisnsiswa
            // 
            textBoxnisnsiswa.Font = new Font("Segoe UI", 8F);
            textBoxnisnsiswa.ForeColor = SystemColors.GrayText;
            textBoxnisnsiswa.Location = new Point(244, 200);
            textBoxnisnsiswa.Margin = new Padding(4, 5, 4, 5);
            textBoxnisnsiswa.Name = "textBoxnisnsiswa";
            textBoxnisnsiswa.Size = new Size(380, 29);
            textBoxnisnsiswa.TabIndex = 5;
            textBoxnisnsiswa.TextChanged += textBoxnisnsiswa_TextChanged;
            // 
            // textBoxnamasiswa
            // 
            textBoxnamasiswa.Font = new Font("Segoe UI", 8F);
            textBoxnamasiswa.ForeColor = SystemColors.GrayText;
            textBoxnamasiswa.Location = new Point(244, 142);
            textBoxnamasiswa.Margin = new Padding(4, 5, 4, 5);
            textBoxnamasiswa.Name = "textBoxnamasiswa";
            textBoxnamasiswa.Size = new Size(380, 29);
            textBoxnamasiswa.TabIndex = 4;
            textBoxnamasiswa.TextChanged += textBoxnamasiswa_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(41, 267);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(115, 25);
            label4.TabIndex = 3;
            label4.Text = "Tanggal Lahir";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(43, 208);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(53, 25);
            label3.TabIndex = 2;
            label3.Text = "NISN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(43, 145);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 1;
            label2.Text = "Nama";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(43, 42);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(210, 41);
            label1.TabIndex = 0;
            label1.Text = "Tambah Siswa";
            label1.Click += label1_Click;
            // 
            // siswa_tambah
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1806, 1135);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "siswa_tambah";
            Text = "siswa_tambah";
            Load += siswa_tambah_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox textBoxtanggalsiswa;
        private TextBox textBoxnisnsiswa;
        private TextBox textBoxnamasiswa;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button submit;
        private TextBox textBoxalamatsiswa;
        private TextBox textBoxlahirsiswa;
        private TextBox textBoxnohpsiswa;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private ComboBox comboBoxkelassiswa;
    }
}