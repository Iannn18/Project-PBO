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
    public int tinggi= 75;
        public Dashboard()
        {
            InitializeComponent();
        }
        bool GuruExpand = false;
        bool AdminExpand = false;

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnMapel_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void btnGuru_Click(object sender, EventArgs e)
        {
            GuruTransition.Start();
        }

        private void GuruTransition_Tick(object sender, EventArgs e)
        {
            if (GuruExpand == false)
            {
                GuruContainer.Height += tinggi;
                    GuruTransition.Stop();
                GuruExpand = true;
            }
            else
            {
                GuruContainer.Height -= tinggi;
                GuruTransition.Stop();
                GuruExpand = false;
            }
        }

        private void AdminTransition_Tick(object sender, EventArgs e)
        {
            if (AdminExpand == false)
            {
                AdminContainer.Height += tinggi;
                    AdminTransition.Stop();
                AdminExpand = true;
            }
            else
            {
                AdminContainer.Height -= tinggi;
                    AdminTransition.Stop();
                AdminExpand = false;
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminTransition.Start();
        }
    }
}
