using System;
using System.Windows.Forms;

namespace Project_akhir_PBO
{
    public partial class FormKelassemua : Form
    {
        private FormKelas2 formKelas2;

        public FormKelassemua()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFormKelas2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFormKelas2();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            OpenFormKelas2();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFormKelas2();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFormKelas2();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            OpenFormKelas2();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            OpenFormKelas2();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFormKelas2();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFormKelas2();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            OpenFormKelas2();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            OpenFormKelas2();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            OpenFormKelas2();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            OpenFormKelas2();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            OpenFormKelas2();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            OpenFormKelas2();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            OpenFormKelas2();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            OpenFormKelas2();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            OpenFormKelas2();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            OpenFormKelas2();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            OpenFormKelas2();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            OpenFormKelas2();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFormKelas2();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenFormKelas2();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenFormKelas2();
        }

        private void OpenFormKelas2()
        {
            if (formKelas2 == null)
            {
                formKelas2 = new FormKelas2();
                formKelas2.FormClosed += FormKelas2_FormClosed;
                formKelas2.MdiParent = this.MdiParent; // Set MdiParent to the parent of FormKelas1
                formKelas2.Dock = DockStyle.Fill;
                formKelas2.Show();
            }
            else
            {
                formKelas2.Activate();
            }

            this.Close();
        }

        private void FormKelas2_FormClosed(object? sender, FormClosedEventArgs e)
        {
            formKelas2 = null;
        }
    }
}
