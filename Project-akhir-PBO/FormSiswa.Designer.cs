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
            buttontambahsiswa.Location = new Point(719, 532);
            buttontambahsiswa.Margin = new Padding(3, 4, 3, 4);
            buttontambahsiswa.Name = "buttontambahsiswa";
            buttontambahsiswa.Size = new Size(160, 37);
            buttontambahsiswa.TabIndex = 0;
            buttontambahsiswa.Text = "Tambah Siswa";
            buttontambahsiswa.UseVisualStyleBackColor = false;
            buttontambahsiswa.Click += buttontambahsiswa_Click;
            // 
            // FormSiswa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(buttontambahsiswa);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormSiswa";
            Text = "FormSiswa";
            Load += FormSiswa_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttontambahsiswa;
    }
}
