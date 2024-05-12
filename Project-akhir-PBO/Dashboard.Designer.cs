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
            button1 = new Button();
            panel1 = new Panel();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoSimaster).BeginInit();
            panel1.SuspendLayout();
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
            LogoSimaster.Anchor = AnchorStyles.None;
            LogoSimaster.Image = (Image)resources.GetObject("LogoSimaster.Image");
            LogoSimaster.Location = new Point(50, 3);
            LogoSimaster.Margin = new Padding(50, 3, 3, 3);
            LogoSimaster.Name = "LogoSimaster";
            LogoSimaster.Size = new Size(195, 101);
            LogoSimaster.SizeMode = PictureBoxSizeMode.StretchImage;
            LogoSimaster.TabIndex = 1;
            LogoSimaster.TabStop = false;
            LogoSimaster.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(-10, -15);
            button1.Name = "button1";
            button1.Size = new Size(219, 66);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Location = new Point(533, 294);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 40);
            panel1.TabIndex = 2;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)LogoSimaster).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox LogoSimaster;
        private Button button1;
        private Panel panel1;
    }
}