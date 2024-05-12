namespace Project_akhir_PBO
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            flowLayoutPanel1 = new FlowLayoutPanel();
            LogoSimaster = new PictureBox();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoSimaster).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Black;
            flowLayoutPanel1.Controls.Add(LogoSimaster);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(287, 673);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // LogoSimaster
            // 
            LogoSimaster.Image = (Image)resources.GetObject("LogoSimaster.Image");
            LogoSimaster.Location = new Point(3, 3);
            LogoSimaster.Name = "LogoSimaster";
            LogoSimaster.Size = new Size(163, 53);
            LogoSimaster.SizeMode = PictureBoxSizeMode.StretchImage;
            LogoSimaster.TabIndex = 1;
            LogoSimaster.TabStop = false;
            LogoSimaster.Click += pictureBox1_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(flowLayoutPanel1);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)LogoSimaster).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox LogoSimaster;
    }
}