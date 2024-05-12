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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            LogoSimaster = new PictureBox();
            panel1 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            button2 = new Button();
            panel3 = new Panel();
            button3 = new Button();
            ContainerGuru = new FlowLayoutPanel();
            panel4 = new Panel();
            button4 = new Button();
            panel5 = new Panel();
            button5 = new Button();
            panel7 = new Panel();
            button7 = new Button();
            panel8 = new Panel();
            button8 = new Button();
            panel9 = new Panel();
            button9 = new Button();
            flowLayoutPanel3 = new FlowLayoutPanel();
            GuruTransition = new System.Windows.Forms.Timer(components);
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LogoSimaster).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Black;
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Controls.Add(LogoSimaster);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10);
            flowLayoutPanel1.Size = new Size(287, 673);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // LogoSimaster
            // 
            LogoSimaster.Anchor = AnchorStyles.None;
            LogoSimaster.Image = (Image)resources.GetObject("LogoSimaster.Image");
            LogoSimaster.Location = new Point(60, 51);
            LogoSimaster.Margin = new Padding(50, 3, 3, 3);
            LogoSimaster.Name = "LogoSimaster";
            LogoSimaster.Size = new Size(195, 101);
            LogoSimaster.SizeMode = PictureBoxSizeMode.StretchImage;
            LogoSimaster.TabIndex = 1;
            LogoSimaster.TabStop = false;
            LogoSimaster.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Location = new Point(60, 195);
            panel1.Margin = new Padding(50, 40, 40, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 40);
            panel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-17, -18);
            button1.Name = "button1";
            button1.Padding = new Padding(25, 1, 1, 1);
            button1.Size = new Size(236, 73);
            button1.TabIndex = 1;
            button1.Text = "Dasboard";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button2);
            panel2.Location = new Point(724, 112);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 40);
            panel2.TabIndex = 3;
            // 
            // button2
            // 
            button2.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-17, -18);
            button2.Name = "button2";
            button2.Padding = new Padding(25, 0, 0, 0);
            button2.Size = new Size(236, 73);
            button2.TabIndex = 1;
            button2.Text = "Guru";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(button3);
            panel3.Location = new Point(396, 203);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 40);
            panel3.TabIndex = 4;
            // 
            // button3
            // 
            button3.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(-17, -18);
            button3.Name = "button3";
            button3.Padding = new Padding(25, 0, 0, 0);
            button3.Size = new Size(236, 73);
            button3.TabIndex = 1;
            button3.Text = "Admin";
            button3.UseVisualStyleBackColor = true;
            // 
            // ContainerGuru
            // 
            ContainerGuru.BackColor = Color.Black;
            ContainerGuru.Location = new Point(724, 112);
            ContainerGuru.Name = "ContainerGuru";
            ContainerGuru.Size = new Size(200, 132);
            ContainerGuru.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Location = new Point(533, 23);
            panel4.Name = "panel4";
            panel4.Size = new Size(159, 40);
            panel4.TabIndex = 8;
            // 
            // button4
            // 
            button4.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(336, 40);
            button4.Name = "button4";
            button4.Padding = new Padding(25, 0, 0, 0);
            button4.Size = new Size(236, 73);
            button4.TabIndex = 1;
            button4.Text = "Kelas";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // panel5
            // 
            panel5.Controls.Add(button5);
            panel5.Location = new Point(724, 204);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 40);
            panel5.TabIndex = 9;
            // 
            // button5
            // 
            button5.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(-16, -17);
            button5.Name = "button5";
            button5.Padding = new Padding(25, 0, 0, 0);
            button5.Size = new Size(236, 73);
            button5.TabIndex = 1;
            button5.Text = "Mapel";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(button7);
            panel7.Location = new Point(845, 445);
            panel7.Name = "panel7";
            panel7.Size = new Size(200, 40);
            panel7.TabIndex = 13;
            // 
            // button7
            // 
            button7.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(-16, -17);
            button7.Name = "button7";
            button7.Padding = new Padding(25, 0, 0, 0);
            button7.Size = new Size(236, 73);
            button7.TabIndex = 1;
            button7.Text = "Guru";
            button7.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            panel8.Controls.Add(button8);
            panel8.Location = new Point(845, 399);
            panel8.Name = "panel8";
            panel8.Size = new Size(200, 40);
            panel8.TabIndex = 12;
            // 
            // button8
            // 
            button8.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(-17, -18);
            button8.Name = "button8";
            button8.Padding = new Padding(25, 0, 0, 0);
            button8.Size = new Size(236, 73);
            button8.TabIndex = 1;
            button8.Text = "Guru";
            button8.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            panel9.Controls.Add(button9);
            panel9.Location = new Point(845, 353);
            panel9.Name = "panel9";
            panel9.Size = new Size(200, 40);
            panel9.TabIndex = 11;
            // 
            // button9
            // 
            button9.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.Image = (Image)resources.GetObject("button9.Image");
            button9.ImageAlign = ContentAlignment.MiddleLeft;
            button9.Location = new Point(-17, -18);
            button9.Name = "button9";
            button9.Padding = new Padding(25, 0, 0, 0);
            button9.Size = new Size(236, 73);
            button9.TabIndex = 1;
            button9.Text = "Guru";
            button9.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.BackColor = Color.Black;
            flowLayoutPanel3.Location = new Point(845, 353);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(200, 132);
            flowLayoutPanel3.TabIndex = 10;
            // 
            // GuruTransition
            // 
            GuruTransition.Tick += GuruTransition_Tick;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(button4);
            Controls.Add(panel7);
            Controls.Add(panel8);
            Controls.Add(panel9);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(ContainerGuru);
            Name = "Dashboard";
            Text = " ";
            Load += Dashboard_Load;
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)LogoSimaster).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel9.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox LogoSimaster;
        private Panel panel1;
        private Button button1;
        private Panel panel2;
        private Button button2;
        private Panel panel3;
        private Button button3;
        private FlowLayoutPanel ContainerGuru;
        private Panel panel4;
        private Button button4;
        private Panel panel5;
        private Button button5;
        private Panel panel7;
        private Button button7;
        private Panel panel8;
        private Button button8;
        private Panel panel9;
        private Button button9;
        private FlowLayoutPanel flowLayoutPanel3;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer GuruTransition;
    }
}