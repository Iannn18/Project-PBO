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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            dataGridViewkelasguru = new DataGridView();
            NamaLengkap = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewComboBoxColumn();
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
            dataGridViewkelasguru.Columns.AddRange(new DataGridViewColumn[] { NamaLengkap, Column1 });
            dataGridViewkelasguru.Location = new Point(413, 99);
            dataGridViewkelasguru.Name = "dataGridViewkelasguru";
            dataGridViewkelasguru.RowHeadersWidth = 51;
            dataGridViewkelasguru.Size = new Size(952, 682);
            dataGridViewkelasguru.TabIndex = 1;
            dataGridViewkelasguru.CellContentClick += dataGridViewkelasguru_CellContentClick;
            dataGridViewkelasguru.CellMouseClick += dataGridViewkelasguru_CellMouseClick;
            // 
            // NamaLengkap
            // 
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            NamaLengkap.DefaultCellStyle = dataGridViewCellStyle1;
            NamaLengkap.HeaderText = "NamaLengkap";
            NamaLengkap.MinimumWidth = 6;
            NamaLengkap.Name = "NamaLengkap";
            NamaLengkap.ReadOnly = true;
            NamaLengkap.Width = 300;
            // 
            // Column1
            // 
            Column1.HeaderText = "Status";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Formkelasguru
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1554, 841);
            Controls.Add(dataGridViewkelasguru);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Formkelasguru";
            Text = "Formkelasguru";
            Load += Formkelasguru_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewkelasguru).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridViewkelasguru;
        private DataGridViewTextBoxColumn NamaLengkap;
        private DataGridViewComboBoxColumn Column1;
    }
}
