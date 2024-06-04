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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(74, 20);
            label1.Name = "label1";
            label1.Size = new Size(142, 21);
            label1.TabIndex = 1;
            label1.Text = "Edit Akun Pegawai";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(20, 64);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Nama";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(20, 99);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 3;
            label3.Text = "NIP";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(20, 135);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 4;
            label4.Text = "PASS";
            label4.Click += label4_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 8F);
            textBox1.ForeColor = SystemColors.GrayText;
            textBox1.Location = new Point(83, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(187, 22);
            textBox1.TabIndex = 5;
            textBox1.Text = " Masukan Nama";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 8F);
            textBox2.ForeColor = SystemColors.GrayText;
            textBox2.Location = new Point(83, 99);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(187, 22);
            textBox2.TabIndex = 6;
            textBox2.Text = " Masukan NIP";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 8F);
            textBox3.ForeColor = SystemColors.GrayText;
            textBox3.Location = new Point(83, 133);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(186, 22);
            textBox3.TabIndex = 7;
            textBox3.Text = " Masukan Password";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.White;
            button1.Location = new Point(57, 206);
            button1.Name = "button1";
            button1.Size = new Size(78, 30);
            button1.TabIndex = 8;
            button1.Text = "Ubah Data";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Location = new Point(156, 206);
            button2.Name = "button2";
            button2.Size = new Size(84, 30);
            button2.TabIndex = 9;
            button2.Text = "Kembali";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(603, 126);
            panel1.Name = "panel1";
            panel1.Size = new Size(288, 334);
            panel1.TabIndex = 10;
            panel1.Paint += panel1_Paint;
            // 
            // Pegawai_edit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Pegawai_edit";
            Text = "Pegawai_edit";
            Load += Pegawai_edit_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Panel panel1;
    }
}
