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
            Home.ActiveForm.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
