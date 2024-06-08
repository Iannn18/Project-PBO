namespace Project_akhir_PBO.view
{
    partial class ListTugasControll
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btJudul = new Label();
            btDeskripsi = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btJudul
            // 
            btJudul.Anchor = AnchorStyles.Top;
            btJudul.AutoSize = true;
            btJudul.BackColor = Color.Transparent;
            btJudul.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btJudul.ForeColor = Color.Black;
            btJudul.Location = new Point(3, 3);
            btJudul.Name = "btJudul";
            btJudul.Size = new Size(66, 30);
            btJudul.TabIndex = 2;
            btJudul.Text = "label1";
            // 
            // btDeskripsi
            // 
            btDeskripsi.Anchor = AnchorStyles.Top;
            btDeskripsi.AutoSize = true;
            btDeskripsi.BackColor = Color.Transparent;
            btDeskripsi.Font = new Font("Gadugi", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btDeskripsi.ForeColor = Color.Black;
            btDeskripsi.Location = new Point(3, 0);
            btDeskripsi.Name = "btDeskripsi";
            btDeskripsi.Size = new Size(61, 22);
            btDeskripsi.TabIndex = 3;
            btDeskripsi.Text = "label1";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btDeskripsi);
            flowLayoutPanel1.Location = new Point(3, 36);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(225, 143);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // ListTugasControll
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(btJudul);
            Controls.Add(flowLayoutPanel1);
            Name = "ListTugasControll";
            Size = new Size(231, 182);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label btJudul;
        private Label btDeskripsi;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
