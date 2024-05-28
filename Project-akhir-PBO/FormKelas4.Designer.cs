namespace Project_akhir_PBO
{
    partial class FormKelas4
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnGuru;
        private System.Windows.Forms.Button btnKelas;
        private System.Windows.Forms.Button btnMapel;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Label lblSIMASTER;

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
            sidePanel = new Panel();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            lblSIMASTER = new Label();
            btnAdmin = new Button();
            btnMapel = new Button();
            btnKelas = new Button();
            btnGuru = new Button();
            btnLogout = new Button();
            btnDashboard = new Button();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            dataGridView3 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.Black;
            sidePanel.Controls.Add(pictureBox6);
            sidePanel.Controls.Add(pictureBox5);
            sidePanel.Controls.Add(pictureBox4);
            sidePanel.Controls.Add(pictureBox3);
            sidePanel.Controls.Add(pictureBox2);
            sidePanel.Controls.Add(pictureBox1);
            sidePanel.Controls.Add(lblSIMASTER);
            sidePanel.Controls.Add(btnAdmin);
            sidePanel.Controls.Add(btnMapel);
            sidePanel.Controls.Add(btnKelas);
            sidePanel.Controls.Add(btnGuru);
            sidePanel.Controls.Add(btnLogout);
            sidePanel.Controls.Add(btnDashboard);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Location = new Point(0, 0);
            sidePanel.Margin = new Padding(6);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(366, 841);
            sidePanel.TabIndex = 0;
            sidePanel.Paint += sidePanel_Paint;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Black;
            pictureBox6.BackgroundImageLayout = ImageLayout.None;
            pictureBox6.Location = new Point(110, 381);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(47, 40);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 10;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Black;
            pictureBox5.BackgroundImageLayout = ImageLayout.None;
            pictureBox5.Location = new Point(153, 301);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(47, 40);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Black;
            pictureBox4.BackgroundImageLayout = ImageLayout.None;
            pictureBox4.Location = new Point(153, 245);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(47, 40);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Black;
            pictureBox3.BackgroundImageLayout = ImageLayout.None;
            pictureBox3.Location = new Point(110, 189);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(47, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Black;
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Location = new Point(110, 136);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(47, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Location = new Point(88, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblSIMASTER
            // 
            lblSIMASTER.AutoSize = true;
            lblSIMASTER.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSIMASTER.ForeColor = Color.White;
            lblSIMASTER.Location = new Point(131, 33);
            lblSIMASTER.Margin = new Padding(6, 0, 6, 0);
            lblSIMASTER.Name = "lblSIMASTER";
            lblSIMASTER.Size = new Size(131, 32);
            lblSIMASTER.TabIndex = 0;
            lblSIMASTER.Text = "SIMASTER";
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = SystemColors.ActiveCaptionText;
            btnAdmin.FlatStyle = FlatStyle.Popup;
            btnAdmin.ForeColor = SystemColors.ControlLightLight;
            btnAdmin.Location = new Point(147, 371);
            btnAdmin.Margin = new Padding(6);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(96, 58);
            btnAdmin.TabIndex = 6;
            btnAdmin.Text = "Admin";
            btnAdmin.UseVisualStyleBackColor = false;
            // 
            // btnMapel
            // 
            btnMapel.BackColor = SystemColors.ActiveCaptionText;
            btnMapel.FlatStyle = FlatStyle.Popup;
            btnMapel.ForeColor = SystemColors.ControlLightLight;
            btnMapel.Location = new Point(197, 293);
            btnMapel.Margin = new Padding(6);
            btnMapel.Name = "btnMapel";
            btnMapel.Size = new Size(88, 58);
            btnMapel.TabIndex = 5;
            btnMapel.Text = "Mapel";
            btnMapel.UseVisualStyleBackColor = false;
            // 
            // btnKelas
            // 
            btnKelas.BackColor = SystemColors.ActiveCaptionText;
            btnKelas.FlatStyle = FlatStyle.Popup;
            btnKelas.ForeColor = SystemColors.AppWorkspace;
            btnKelas.Location = new Point(191, 237);
            btnKelas.Margin = new Padding(6);
            btnKelas.Name = "btnKelas";
            btnKelas.Size = new Size(84, 58);
            btnKelas.TabIndex = 4;
            btnKelas.Text = "Kelas";
            btnKelas.UseVisualStyleBackColor = false;
            btnKelas.Click += btnKelas_Click;
            // 
            // btnGuru
            // 
            btnGuru.BackColor = Color.Black;
            btnGuru.FlatStyle = FlatStyle.Popup;
            btnGuru.ForeColor = Color.White;
            btnGuru.Location = new Point(144, 180);
            btnGuru.Margin = new Padding(6);
            btnGuru.Name = "btnGuru";
            btnGuru.Size = new Size(87, 58);
            btnGuru.TabIndex = 3;
            btnGuru.Text = "Guru";
            btnGuru.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Red;
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(88, 769);
            btnLogout.Margin = new Padding(6);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(184, 58);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Black;
            btnDashboard.FlatStyle = FlatStyle.Popup;
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(148, 123);
            btnDashboard.Margin = new Padding(6);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(131, 58);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(580, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(754, 206);
            dataGridView1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(580, 277);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(754, 317);
            dataGridView2.TabIndex = 2;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(580, 638);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 62;
            dataGridView3.Size = new Size(754, 158);
            dataGridView3.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.White;
            button1.Location = new Point(428, 301);
            button1.Margin = new Padding(6);
            button1.Name = "button1";
            button1.Size = new Size(97, 84);
            button1.TabIndex = 11;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = Color.White;
            button2.Location = new Point(428, 381);
            button2.Margin = new Padding(6);
            button2.Name = "button2";
            button2.Size = new Size(97, 84);
            button2.TabIndex = 12;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // FormKelas4
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1578, 841);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView3);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(sidePanel);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6);
            Name = "FormKelas4";
            Text = "SIMASTER";
            Load += Form1_Load;
            sidePanel.ResumeLayout(false);
            sidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
        }

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private Button button1;
        private Button button2;
    }
}
