namespace Project_akhir_PBO
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            button1 = new Button();
            UsernameBox = new TextBox();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            PasswordBox = new TextBox();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(622, 268);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(280, 37);
            button1.TabIndex = 0;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // UsernameBox
            // 
            UsernameBox.ForeColor = SystemColors.InactiveCaption;
            UsernameBox.Location = new Point(622, 177);
            UsernameBox.Margin = new Padding(3, 2, 3, 2);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Size = new Size(280, 23);
            UsernameBox.TabIndex = 1;
            UsernameBox.Text = "Username";
            UsernameBox.TextChanged += textBox1_TextChanged;
            UsernameBox.Enter += UsenameBox_Enter;
            UsernameBox.Leave += UsenameBox_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(640, 107);
            label1.Name = "label1";
            label1.Size = new Size(223, 46);
            label1.TabIndex = 2;
            label1.Text = "Welcome !";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Black;
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(394, 505);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(109, 165);
            pictureBox1.Margin = new Padding(109, 165, 0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 251);
            label2.Name = "label2";
            label2.Padding = new Padding(122, 0, 0, 0);
            label2.Size = new Size(260, 29);
            label2.TabIndex = 6;
            label2.Text = "SIMASTER";
            // 
            // PasswordBox
            // 
            PasswordBox.ForeColor = SystemColors.InactiveCaption;
            PasswordBox.Location = new Point(622, 215);
            PasswordBox.Margin = new Padding(3, 2, 3, 2);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(280, 23);
            PasswordBox.TabIndex = 5;
            PasswordBox.Text = "Password";
            PasswordBox.Enter += PasswordBox_Enter;
            PasswordBox.Leave += PasswordBox_Leave;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 505);
            Controls.Add(PasswordBox);
            Controls.Add(UsernameBox);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(flowLayoutPanel1);
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox UsernameBox;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox PasswordBox;
        private PictureBox pictureBox1;
        private Label label2;
    }
}
