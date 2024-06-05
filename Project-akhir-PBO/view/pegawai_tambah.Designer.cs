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
            panel1 = new Panel();
            textBox7 = new TextBox();
            buttonSubmit = new Button();
            comboBoxJabatan = new ComboBox();
            label5 = new Label();
            textBox1 = new TextBox();
            label8 = new Label();
            textBox6 = new TextBox();
            label3 = new Label();
            label9 = new Label();
            label2 = new Label();
            label7 = new Label();
            label1 = new Label();
            label6 = new Label();
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(buttonSubmit);
            panel1.Controls.Add(comboBoxJabatan);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Location = new Point(452, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(556, 385);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(167, 247);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(359, 23);
            textBox7.TabIndex = 18;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // buttonSubmit
            // 
            buttonSubmit.BackColor = SystemColors.ActiveCaptionText;
            buttonSubmit.ForeColor = SystemColors.ButtonHighlight;
            buttonSubmit.Location = new Point(36, 331);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(494, 28);
            buttonSubmit.TabIndex = 8;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = false;
            buttonSubmit.Click += button1_Click;
            // 
            // comboBoxJabatan
            // 
            comboBoxJabatan.FormattingEnabled = true;
            comboBoxJabatan.Items.AddRange(new object[] { "Guru", "Staff TU" });
            comboBoxJabatan.Location = new Point(167, 284);
            comboBoxJabatan.Name = "comboBoxJabatan";
            comboBoxJabatan.Size = new Size(359, 23);
            comboBoxJabatan.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(36, 287);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 9;
            label5.Text = "Jabatan";
            label5.Click += label5_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(167, 137);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(359, 23);
            textBox1.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Black;
            label8.Location = new Point(34, 212);
            label8.Name = "label8";
            label8.Size = new Size(75, 15);
            label8.TabIndex = 13;
            label8.Text = "Tempat Lahir";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(167, 209);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(359, 23);
            textBox6.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(32, 106);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 6;
            label3.Text = "NUPTK";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Black;
            label9.Location = new Point(36, 250);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 14;
            label9.Text = "Alamat";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(32, 74);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 5;
            label2.Text = "Nama";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Black;
            label7.Location = new Point(34, 181);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 12;
            label7.Text = "No. Telpon";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(32, 11);
            label1.Name = "label1";
            label1.Size = new Size(217, 28);
            label1.TabIndex = 4;
            label1.Text = "Tambah Akun Pegawai";
            label1.Click += label1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(32, 140);
            label6.Name = "label6";
            label6.Size = new Size(77, 15);
            label6.TabIndex = 11;
            label6.Text = "Tanggal Lahir";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(167, 173);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(359, 23);
            textBox5.TabIndex = 16;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 8F);
            textBox3.ForeColor = SystemColors.GrayText;
            textBox3.Location = new Point(167, 104);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(359, 22);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 8F);
            textBox2.ForeColor = SystemColors.GrayText;
            textBox2.Location = new Point(167, 72);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(359, 22);
            textBox2.TabIndex = 1;
            // 
            // Pegawai_tambah
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 505);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Pegawai_tambah";
            Text = "Pegawai_tambah";
            Load += Pegawai_tambah_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label3;
        private Label label2;
        private Button buttonSubmit;
        private Label label5;
        private ComboBox comboBoxJabatan;
        private Label label6;
        private TextBox textBox1;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
    }
}

