using Project_akhir_PBO.Context;

namespace Project_akhir_PBO
{
    public partial class Home : Form
    {
        userContext? user;

        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user = new userContext();

            bool status = user.loginQuery(username: UsernameBox.Text, password: PasswordBox.Text);
            
            if (status == true)
            {
                Dashboard dashboard = new Dashboard(user);
                dashboard.Show();
                this.Hide();    
            } else
            {
                MessageBox.Show("Akun tidak valid");
            }

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UsenameBox_Enter(object sender, EventArgs e)
        {
            if (UsernameBox.Text == "Username")
            {
                UsernameBox.Text = "";
                UsernameBox.ForeColor = Color.Black;
            }
        }

        private void UsenameBox_Leave(object sender, EventArgs e)
        {
            if (UsernameBox.Text == "")
            {
                UsernameBox.Text = "Username";
                UsernameBox.ForeColor = Color.Silver;
            }
        }

        private void PasswordBox_Enter(object sender, EventArgs e)
        {
            if (PasswordBox.Text == "Password")
            {
                PasswordBox.Text = "";
                PasswordBox.ForeColor = Color.Black;
            }
        }

        private void PasswordBox_Leave(object sender, EventArgs e)
        {
            if (PasswordBox.Text == "")
            {
                PasswordBox.Text = "Password";
                PasswordBox.ForeColor = Color.Silver;
            }
        }
    }
}
