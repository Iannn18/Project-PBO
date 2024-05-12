using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_akhir_PBO
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        bool menuExpanded = false;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void GuruTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpanded == false)
            {
                ContainerGuru.Height += 10;
                if (ContainerGuru.Height >= 150)
                {
                    GuruTransition.Stop();
                    menuExpanded = true;
                }
            }
            else
            {
                ContainerGuru.Height -= 10;
                if (ContainerGuru.Height <= 40)
                {
                    GuruTransition.Stop();
                    menuExpanded = false;
                }
            }
        }
    }
}
