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
            button1 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
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
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(520, 124);
            panel1.Name = "panel1";
            panel1.Size = new Size(425, 289);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.ForeColor = Color.White;
            button1.Location = new Point(30, 219);
            button1.Name = "button1";
            button1.Size = new Size(354, 28);
            button1.TabIndex = 7;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 8F);
            textBox3.ForeColor = SystemColors.GrayText;
            textBox3.Location = new Point(117, 160);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(267, 22);
            textBox3.TabIndex = 6;
            textBox3.Text = " Masukan Kelas";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 8F);
            textBox2.ForeColor = SystemColors.GrayText;
            textBox2.Location = new Point(117, 122);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(267, 22);
            textBox2.TabIndex = 5;
            textBox2.Text = " Masukan NISN";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 8F);
            textBox1.ForeColor = SystemColors.GrayText;
            textBox1.Location = new Point(117, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(267, 22);
            textBox1.TabIndex = 4;
            textBox1.Text = " Masukan Nama";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(30, 160);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 3;
            label4.Text = "Kelas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(30, 125);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 2;
            label3.Text = "NISN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(30, 87);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Nama";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 25);
            label1.Name = "label1";
            label1.Size = new Size(139, 28);
            label1.TabIndex = 0;
            label1.Text = "Tambah Siswa";
            label1.Click += label1_Click;
            // 
            // siswa_tambah
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
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
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button1;
    }
}