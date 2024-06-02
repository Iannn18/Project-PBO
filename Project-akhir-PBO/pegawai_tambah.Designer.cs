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
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Location = new Point(511, 162);
            panel1.Name = "panel1";
            panel1.Size = new Size(556, 247);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 8F);
            textBox2.ForeColor = SystemColors.GrayText;
            textBox2.Location = new Point(167, 72);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(359, 22);
            textBox2.TabIndex = 1;
            textBox2.Text = " Masukan Nama";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 8F);
            textBox3.ForeColor = SystemColors.GrayText;
            textBox3.Location = new Point(167, 101);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(359, 22);
            textBox3.TabIndex = 2;
            textBox3.Text = " Masukan NIP";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 8F);
            textBox4.ForeColor = SystemColors.GrayText;
            textBox4.Location = new Point(167, 130);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(359, 22);
            textBox4.TabIndex = 3;
            textBox4.Text = " Masukan Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 10);
            label1.Name = "label1";
            label1.Size = new Size(217, 28);
            label1.TabIndex = 4;
            label1.Text = "Tambah Akun Pegawai";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 72);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 5;
            label2.Text = "Nama";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 104);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 6;
            label3.Text = "NIP";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 133);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 7;
            label4.Text = "PASS";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(22, 198);
            button1.Name = "button1";
            button1.Size = new Size(514, 29);
            button1.TabIndex = 8;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            // 
            // Pegawai_tambah
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
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
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button1;
    }
}

