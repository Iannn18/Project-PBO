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
            buttonBatalbuattugas = new Button();
            textBoxTulispertanyaan = new TextBox();
            buttonBuatTugas = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TextboxJudultugas
            // 
            TextboxJudultugas.BorderStyle = BorderStyle.FixedSingle;
            TextboxJudultugas.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            TextboxJudultugas.ForeColor = SystemColors.ScrollBar;
            TextboxJudultugas.Location = new Point(43, 51);
            TextboxJudultugas.Name = "TextboxJudultugas";
            TextboxJudultugas.Size = new Size(570, 39);
            TextboxJudultugas.TabIndex = 0;
            TextboxJudultugas.Text = " Judul";
            TextboxJudultugas.Enter += TextboxJudultugas_Enter;
            TextboxJudultugas.Leave += TextboxJudultugas_Leave;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(buttonBatalbuattugas);
            panel1.Controls.Add(textBoxTulispertanyaan);
            panel1.Controls.Add(TextboxJudultugas);
            panel1.Location = new Point(2, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(652, 489);
            panel1.TabIndex = 1;
            // 
            // buttonBatalbuattugas
            // 
            buttonBatalbuattugas.BackColor = Color.Red;
            buttonBatalbuattugas.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBatalbuattugas.ForeColor = Color.White;
            buttonBatalbuattugas.Location = new Point(192, 443);
            buttonBatalbuattugas.Name = "buttonBatalbuattugas";
            buttonBatalbuattugas.Size = new Size(109, 32);
            buttonBatalbuattugas.TabIndex = 3;
            buttonBatalbuattugas.Text = "Batal";
            buttonBatalbuattugas.UseVisualStyleBackColor = false;
            // 
            // textBoxTulispertanyaan
            // 
            textBoxTulispertanyaan.BorderStyle = BorderStyle.FixedSingle;
            textBoxTulispertanyaan.Font = new Font("Segoe UI", 10F);
            textBoxTulispertanyaan.ForeColor = SystemColors.ScrollBar;
            textBoxTulispertanyaan.Location = new Point(43, 112);
            textBoxTulispertanyaan.Multiline = true;
            textBoxTulispertanyaan.Name = "textBoxTulispertanyaan";
            textBoxTulispertanyaan.Size = new Size(570, 277);
            textBoxTulispertanyaan.TabIndex = 2;
            textBoxTulispertanyaan.Text = "Deskripsi";
            textBoxTulispertanyaan.Enter += textBoxTulispertanyaan_Enter;
            textBoxTulispertanyaan.Leave += textBoxTulispertanyaan_Leave;
            // 
            // buttonBuatTugas
            // 
            buttonBuatTugas.BackColor = Color.SeaGreen;
            buttonBuatTugas.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBuatTugas.ForeColor = Color.White;
            buttonBuatTugas.Location = new Point(352, 447);
            buttonBuatTugas.Margin = new Padding(0);
            buttonBuatTugas.Name = "buttonBuatTugas";
            buttonBuatTugas.Size = new Size(109, 32);
            buttonBuatTugas.TabIndex = 2;
            buttonBuatTugas.Text = "Buat";
            buttonBuatTugas.UseVisualStyleBackColor = false;
            buttonBuatTugas.Click += buttonBuatTugas_Click;
            // 
            // TambahTugas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 492);
            Controls.Add(buttonBuatTugas);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
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
        private TextBox textBoxTulispertanyaan;
        private Button buttonBuatTugas;
        private Button buttonBatalbuattugas;
    }
}