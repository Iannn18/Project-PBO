namespace Project_akhir_PBO
{
    partial class Formkelasguru
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
            dataGridViewkelasguru = new DataGridView();
            NamaLengkap = new DataGridViewTextBoxColumn();
            Hadir = new DataGridViewTextBoxColumn();
            Izin = new DataGridViewTextBoxColumn();
            Sakit = new DataGridViewTextBoxColumn();
            Alfa = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewkelasguru).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(365, 30);
            label1.Name = "label1";
            label1.Size = new Size(152, 41);
            label1.TabIndex = 0;
            label1.Text = "Kelas X-A";
            label1.Click += label1_Click;
            // 
            // dataGridViewkelasguru
            // 
            dataGridViewkelasguru.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewkelasguru.Columns.AddRange(new DataGridViewColumn[] { NamaLengkap, Hadir, Izin, Sakit, Alfa, Edit });
            dataGridViewkelasguru.Location = new Point(413, 99);
            dataGridViewkelasguru.Name = "dataGridViewkelasguru";
            dataGridViewkelasguru.RowHeadersWidth = 51;
            dataGridViewkelasguru.Size = new Size(952, 682);
            dataGridViewkelasguru.TabIndex = 1;
            dataGridViewkelasguru.CellContentClick += dataGridViewkelasguru_CellContentClick;
            // 
            // NamaLengkap
            // 
            NamaLengkap.HeaderText = "NamaLengkap";
            NamaLengkap.MinimumWidth = 6;
            NamaLengkap.Name = "NamaLengkap";
            NamaLengkap.ReadOnly = true;
            NamaLengkap.Width = 125;
            // 
            // Hadir
            // 
            Hadir.HeaderText = "Hadir";
            Hadir.MinimumWidth = 6;
            Hadir.Name = "Hadir";
            Hadir.ReadOnly = true;
            Hadir.Width = 125;
            // 
            // Izin
            // 
            Izin.HeaderText = "Izin";
            Izin.MinimumWidth = 6;
            Izin.Name = "Izin";
            Izin.ReadOnly = true;
            Izin.Width = 125;
            // 
            // Sakit
            // 
            Sakit.HeaderText = "Sakit";
            Sakit.MinimumWidth = 6;
            Sakit.Name = "Sakit";
            Sakit.ReadOnly = true;
            Sakit.Width = 125;
            // 
            // Alfa
            // 
            Alfa.HeaderText = "Alfa";
            Alfa.MinimumWidth = 6;
            Alfa.Name = "Alfa";
            Alfa.ReadOnly = true;
            Alfa.Width = 125;
            // 
            // Edit
            // 
            Edit.HeaderText = "EDIT";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.Width = 125;
            // 
            // Formkelasguru
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1578, 841);
            Controls.Add(dataGridViewkelasguru);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Formkelasguru";
            Text = "Formkelasguru";
            ((System.ComponentModel.ISupportInitialize)dataGridViewkelasguru).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridViewkelasguru;
        private DataGridViewTextBoxColumn NamaLengkap;
        private DataGridViewTextBoxColumn Hadir;
        private DataGridViewTextBoxColumn Izin;
        private DataGridViewTextBoxColumn Sakit;
        private DataGridViewTextBoxColumn Alfa;
        private DataGridViewLinkColumn Edit;
    }
}