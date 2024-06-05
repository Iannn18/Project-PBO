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
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
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
            panel1.Location = new Point(519, 160);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(635, 328);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(25, 264);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(587, 38);
            button1.TabIndex = 8;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(37, 178);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 7;
            label4.Text = "PASS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(37, 138);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 6;
            label3.Text = "NIP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(37, 96);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 5;
            label2.Text = "Nama";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(37, 14);
            label1.Name = "label1";
            label1.Size = new Size(273, 35);
            label1.TabIndex = 4;
            label1.Text = "Tambah Akun Pegawai";
            label1.Click += label1_Click;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 8F);
            textBox4.ForeColor = SystemColors.GrayText;
            textBox4.Location = new Point(191, 174);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(410, 25);
            textBox4.TabIndex = 3;
            textBox4.Text = " Masukan Password";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 8F);
            textBox3.ForeColor = SystemColors.GrayText;
            textBox3.Location = new Point(191, 134);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(410, 25);
            textBox3.TabIndex = 2;
            textBox3.Text = " Masukan NIP";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 8F);
            textBox2.ForeColor = SystemColors.GrayText;
            textBox2.Location = new Point(191, 96);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(410, 25);
            textBox2.TabIndex = 1;
            textBox2.Text = " Masukan Nama";
            // 
            // Pegawai_tambah
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
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

