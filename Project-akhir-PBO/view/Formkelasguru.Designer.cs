namespace Project_akhir_PBO
{
    partial class Formkelasguru
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewkelasguru;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            dataGridViewkelasguru = new DataGridView();
            NamaLengkap = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewComboBoxColumn();
            ColumnNISN = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewkelasguru).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(369, 44);
            label1.Name = "label1";
            label1.Size = new Size(91, 41);
            label1.TabIndex = 0;
            label1.Text = "Kelas";
            // 
            // dataGridViewkelasguru
            // 
            dataGridViewkelasguru.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewkelasguru.Columns.AddRange(new DataGridViewColumn[] { NamaLengkap, Column1, ColumnNISN });
            dataGridViewkelasguru.Location = new Point(369, 124);
            dataGridViewkelasguru.Margin = new Padding(3, 4, 3, 4);
            dataGridViewkelasguru.Name = "dataGridViewkelasguru";
            dataGridViewkelasguru.RowHeadersWidth = 62;
            dataGridViewkelasguru.Size = new Size(800, 500);
            dataGridViewkelasguru.TabIndex = 0;
            dataGridViewkelasguru.CellClick += dataGridViewkelasguru_CellClick;
            dataGridViewkelasguru.CellContentClick += dataGridViewkelasguru_CellContentClick;
            dataGridViewkelasguru.CellValueChanged += dataGridViewkelasguru_CellValueChanged;
            dataGridViewkelasguru.DataError += dataGridViewkelasguru_DataError;
            // 
            // NamaLengkap
            // 
            NamaLengkap.DataPropertyName = "NamaLengkap";
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            NamaLengkap.DefaultCellStyle = dataGridViewCellStyle1;
            NamaLengkap.HeaderText = "Nama Lengkap";
            NamaLengkap.MinimumWidth = 8;
            NamaLengkap.Name = "NamaLengkap";
            NamaLengkap.Width = 150;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Status";
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            Column1.DefaultCellStyle = dataGridViewCellStyle2;
            Column1.HeaderText = "Status";
            Column1.Items.AddRange(new object[] { "Hadir", "Ijin", "Sakit", "Alfa" });
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // ColumnNISN
            // 
            dataGridViewCellStyle3.ForeColor = Color.Black;
            ColumnNISN.DefaultCellStyle = dataGridViewCellStyle3;
            ColumnNISN.HeaderText = "NISN";
            ColumnNISN.MinimumWidth = 6;
            ColumnNISN.Name = "ColumnNISN";
            ColumnNISN.Width = 125;
            // 
            // Formkelasguru
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1263, 673);
            Controls.Add(dataGridViewkelasguru);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Formkelasguru";
            Text = "Formkelasguru";
            Load += Formkelasguru_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewkelasguru).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridViewTextBoxColumn NamaLengkap;
        private DataGridViewComboBoxColumn Column1;
        private DataGridViewTextBoxColumn ColumnNISN;
    }
}
