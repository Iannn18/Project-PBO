namespace Project_akhir_PBO
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard Kontol = new Dashboard();
            Kontol.ShowDialog();
        }
    }
}