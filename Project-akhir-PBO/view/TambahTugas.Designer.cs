namespace Project_akhir_PBO
{
    partial class TambahTugas
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
            TextboxJudultugas = new TextBox();
            panel1 = new Panel();
            textBoxTulispertanyaan = new TextBox();
            textBoxTopikTugas = new TextBox();
            buttonBuatTugas = new Button();
            buttonBatalbuattugas = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TextboxJudultugas
            // 
            TextboxJudultugas.BorderStyle = BorderStyle.None;
            TextboxJudultugas.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            TextboxJudultugas.Location = new Point(41, 31);
            TextboxJudultugas.Name = "TextboxJudultugas";
            TextboxJudultugas.Size = new Size(606, 32);
            TextboxJudultugas.TabIndex = 0;
            TextboxJudultugas.Text = " Judul";
            TextboxJudultugas.TextChanged += textBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(textBoxTulispertanyaan);
            panel1.Controls.Add(textBoxTopikTugas);
            panel1.Controls.Add(TextboxJudultugas);
            panel1.Location = new Point(479, 57);
            panel1.Name = "panel1";
            panel1.Size = new Size(652, 425);
            panel1.TabIndex = 1;
            // 
            // textBoxTulispertanyaan
            // 
            textBoxTulispertanyaan.BorderStyle = BorderStyle.None;
            textBoxTulispertanyaan.Font = new Font("Segoe UI", 10F);
            textBoxTulispertanyaan.Location = new Point(50, 137);
            textBoxTulispertanyaan.Name = "textBoxTulispertanyaan";
            textBoxTulispertanyaan.Size = new Size(538, 18);
            textBoxTulispertanyaan.TabIndex = 2;
            textBoxTulispertanyaan.Text = "Tulis Pertanyaan";
            // 
            // textBoxTopikTugas
            // 
            textBoxTopikTugas.BackColor = Color.White;
            textBoxTopikTugas.BorderStyle = BorderStyle.None;
            textBoxTopikTugas.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            textBoxTopikTugas.Location = new Point(50, 80);
            textBoxTopikTugas.Name = "textBoxTopikTugas";
            textBoxTopikTugas.Size = new Size(100, 20);
            textBoxTopikTugas.TabIndex = 1;
            textBoxTopikTugas.Text = " Topik";
            // 
            // buttonBuatTugas
            // 
            buttonBuatTugas.BackColor = Color.SeaGreen;
            buttonBuatTugas.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBuatTugas.ForeColor = Color.White;
            buttonBuatTugas.Location = new Point(829, 500);
            buttonBuatTugas.Margin = new Padding(0);
            buttonBuatTugas.Name = "buttonBuatTugas";
            buttonBuatTugas.Size = new Size(109, 32);
            buttonBuatTugas.TabIndex = 2;
            buttonBuatTugas.Text = "Buat";
            buttonBuatTugas.UseVisualStyleBackColor = false;
            // 
            // buttonBatalbuattugas
            // 
            buttonBatalbuattugas.BackColor = Color.Red;
            buttonBatalbuattugas.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBatalbuattugas.ForeColor = Color.White;
            buttonBatalbuattugas.Location = new Point(677, 500);
            buttonBatalbuattugas.Name = "buttonBatalbuattugas";
            buttonBatalbuattugas.Size = new Size(109, 32);
            buttonBatalbuattugas.TabIndex = 3;
            buttonBatalbuattugas.Text = "Batal";
            buttonBatalbuattugas.UseVisualStyleBackColor = false;
            buttonBatalbuattugas.Click += buttonBatalbuattugas_Click;
            // 
            // TambahTugas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(buttonBatalbuattugas);
            Controls.Add(buttonBuatTugas);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TambahTugas";
            Text = "TambahTugas";
            Load += TambahTugas_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox TextboxJudultugas;
        private Panel panel1;
        private TextBox textBoxTopikTugas;
        private TextBox textBoxTulispertanyaan;
        private Button buttonBuatTugas;
        private Button buttonBatalbuattugas;
    }
}