namespace Project_akhir_PBO
{
    partial class FormSiswa
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
            buttontambahsiswa = new Button();
            SuspendLayout();
            // 
            // buttontambahsiswa
            // 
            buttontambahsiswa.BackColor = Color.Black;
            buttontambahsiswa.ForeColor = Color.White;
            buttontambahsiswa.Location = new Point(698, 609);
            buttontambahsiswa.Name = "buttontambahsiswa";
            buttontambahsiswa.Size = new Size(142, 29);
            buttontambahsiswa.TabIndex = 0;
            buttontambahsiswa.Text = "Tambah Siswa";
            buttontambahsiswa.UseVisualStyleBackColor = false;
            buttontambahsiswa.Click += buttontambahsiswa_Click;
            // 
            // FormSiswa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(buttontambahsiswa);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSiswa";
            Text = "FormSiswa";
            Load += FormSiswa_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttontambahsiswa;
    }
}
