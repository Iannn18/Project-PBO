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
            btnDashboard = new Button();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            GuruContainer = new FlowLayoutPanel();
            btnGuru = new Button();
            btnKelas = new Button();
            btnMapel = new Button();
            AdminContainer = new FlowLayoutPanel();
            btnAdmin = new Button();
            btnPegawai = new Button();
            btnSiswa = new Button();
            btnLogOut = new Button();
            GuruTransition = new System.Windows.Forms.Timer(components);
            AdminTransition = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            GuruContainer.SuspendLayout();
            AdminContainer.SuspendLayout();
            SuspendLayout();
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.White;
            btnDashboard.BackgroundImageLayout = ImageLayout.None;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.Black;
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.ImageAlign = ContentAlignment.TopLeft;
            btnDashboard.Location = new Point(25, 85);
            btnDashboard.Margin = new Padding(25, 0, 0, 0);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(300, 50);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(180, 35);
            label1.Margin = new Padding(0, 35, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(85, 18);
            label1.TabIndex = 1;
            label1.Text = "SIMASTER";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(100, 25);
            pictureBox2.Margin = new Padding(100, 25, 10, 25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Black;
            flowLayoutPanel1.Controls.Add(pictureBox2);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(btnDashboard);
            flowLayoutPanel1.Controls.Add(GuruContainer);
            flowLayoutPanel1.Controls.Add(AdminContainer);
            flowLayoutPanel1.Controls.Add(btnLogOut);
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(350, 673);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // GuruContainer
            // 
            GuruContainer.Controls.Add(btnGuru);
            GuruContainer.Controls.Add(btnKelas);
            GuruContainer.Controls.Add(btnMapel);
            GuruContainer.Location = new Point(25, 145);
            GuruContainer.Margin = new Padding(25, 10, 0, 0);
            GuruContainer.Name = "GuruContainer";
            GuruContainer.Size = new Size(300, 50);
            GuruContainer.TabIndex = 8;
            // 
            // btnGuru
            // 
            btnGuru.BackColor = Color.White;
            btnGuru.BackgroundImageLayout = ImageLayout.None;
            btnGuru.FlatStyle = FlatStyle.Flat;
            btnGuru.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuru.ForeColor = Color.Black;
            btnGuru.Image = (Image)resources.GetObject("btnGuru.Image");
            btnGuru.ImageAlign = ContentAlignment.TopLeft;
            btnGuru.Location = new Point(0, 0);
            btnGuru.Margin = new Padding(0);
            btnGuru.Name = "btnGuru";
            btnGuru.Size = new Size(300, 50);
            btnGuru.TabIndex = 7;
            btnGuru.Text = "Guru";
            btnGuru.UseVisualStyleBackColor = false;
            btnGuru.Click += btnGuru_Click;
            // 
            // btnKelas
            // 
            btnKelas.BackColor = Color.White;
            btnKelas.BackgroundImageLayout = ImageLayout.None;
            btnKelas.FlatStyle = FlatStyle.Flat;
            btnKelas.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKelas.ForeColor = Color.Black;
            btnKelas.Image = (Image)resources.GetObject("btnKelas.Image");
            btnKelas.ImageAlign = ContentAlignment.TopLeft;
            btnKelas.Location = new Point(75, 50);
            btnKelas.Margin = new Padding(75, 0, 0, 0);
            btnKelas.Name = "btnKelas";
            btnKelas.Size = new Size(225, 50);
            btnKelas.TabIndex = 9;
            btnKelas.Text = "Kelas";
            btnKelas.UseVisualStyleBackColor = false;
            btnKelas.Click += btnKelas_Click;
            // 
            // btnMapel
            // 
            btnMapel.BackColor = Color.White;
            btnMapel.BackgroundImageLayout = ImageLayout.None;
            btnMapel.FlatStyle = FlatStyle.Flat;
            btnMapel.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMapel.ForeColor = Color.Black;
            btnMapel.Image = (Image)resources.GetObject("btnMapel.Image");
            btnMapel.ImageAlign = ContentAlignment.TopLeft;
            btnMapel.Location = new Point(75, 100);
            btnMapel.Margin = new Padding(75, 0, 0, 0);
            btnMapel.Name = "btnMapel";
            btnMapel.Size = new Size(225, 50);
            btnMapel.TabIndex = 10;
            btnMapel.Text = "Mapel";
            btnMapel.UseVisualStyleBackColor = false;
            btnMapel.Click += btnMapel_Click_1;
            // 
            // AdminContainer
            // 
            AdminContainer.Controls.Add(btnAdmin);
            AdminContainer.Controls.Add(btnPegawai);
            AdminContainer.Controls.Add(btnSiswa);
            AdminContainer.Location = new Point(25, 205);
            AdminContainer.Margin = new Padding(25, 10, 0, 0);
            AdminContainer.Name = "AdminContainer";
            AdminContainer.Size = new Size(300, 50);
            AdminContainer.TabIndex = 9;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.White;
            btnAdmin.BackgroundImageLayout = ImageLayout.None;
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdmin.ForeColor = Color.Black;
            btnAdmin.Image = (Image)resources.GetObject("btnAdmin.Image");
            btnAdmin.ImageAlign = ContentAlignment.TopLeft;
            btnAdmin.Location = new Point(0, 0);
            btnAdmin.Margin = new Padding(0);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(300, 50);
            btnAdmin.TabIndex = 7;
            btnAdmin.Text = "Admin";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // btnPegawai
            // 
            btnPegawai.BackColor = Color.White;
            btnPegawai.BackgroundImageLayout = ImageLayout.None;
            btnPegawai.FlatStyle = FlatStyle.Flat;
            btnPegawai.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPegawai.ForeColor = Color.Black;
            btnPegawai.Image = (Image)resources.GetObject("btnPegawai.Image");
            btnPegawai.ImageAlign = ContentAlignment.TopLeft;
            btnPegawai.Location = new Point(75, 50);
            btnPegawai.Margin = new Padding(75, 0, 0, 0);
            btnPegawai.Name = "btnPegawai";
            btnPegawai.Size = new Size(225, 50);
            btnPegawai.TabIndex = 10;
            btnPegawai.Text = "Pegawai";
            btnPegawai.UseVisualStyleBackColor = false;
            btnPegawai.Click += btnPegawai_Click;
            // 
            // btnSiswa
            // 
            btnSiswa.BackColor = Color.White;
            btnSiswa.BackgroundImageLayout = ImageLayout.None;
            btnSiswa.FlatStyle = FlatStyle.Flat;
            btnSiswa.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSiswa.ForeColor = Color.Black;
            btnSiswa.Image = (Image)resources.GetObject("btnSiswa.Image");
            btnSiswa.ImageAlign = ContentAlignment.TopLeft;
            btnSiswa.Location = new Point(75, 100);
            btnSiswa.Margin = new Padding(75, 0, 0, 0);
            btnSiswa.Name = "btnSiswa";
            btnSiswa.Size = new Size(225, 50);
            btnSiswa.TabIndex = 9;
            btnSiswa.Text = "Siswa";
            btnSiswa.UseVisualStyleBackColor = false;
            btnSiswa.Click += btnSiswa_Click_1;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Red;
            btnLogOut.FlatStyle = FlatStyle.Popup;
            btnLogOut.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogOut.ForeColor = SystemColors.Control;
            btnLogOut.Image = (Image)resources.GetObject("btnLogOut.Image");
            btnLogOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogOut.Location = new Point(100, 575);
            btnLogOut.Margin = new Padding(100, 320, 0, 0);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(150, 40);
            btnLogOut.TabIndex = 2;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // GuruTransition
            // 
            GuruTransition.Interval = 10;
            GuruTransition.Tick += GuruTransition_Tick;
            // 
            // AdminTransition
            // 
            AdminTransition.Interval = 10;
            AdminTransition.Tick += AdminTransition_Tick;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1262, 673);
            Controls.Add(flowLayoutPanel1);
            ForeColor = Color.White;
            IsMdiContainer = true;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dashboard";
            Load += Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            GuruContainer.ResumeLayout(false);
            AdminContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnDashboard;
        private Label label1;
        private PictureBox pictureBox2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnGuru;
        private FlowLayoutPanel GuruContainer;
        private Button btnKelas;
        private Button btnMapel;
        private FlowLayoutPanel AdminContainer;
        private Button btnAdmin;
        private Button btnSiswa;
        private Button btnPegawai;
        private System.Windows.Forms.Timer GuruTransition;
        private System.Windows.Forms.Timer AdminTransition;
        private Button btnLogOut;
    }
}