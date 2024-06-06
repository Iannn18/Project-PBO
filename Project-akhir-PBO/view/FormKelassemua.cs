using System;
using System.Windows.Forms;

namespace Project_akhir_PBO
{
    public partial class FormKelassemua : Form
    {
        private Mapeltugas formMapeltugas;
        public FormKelassemua()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                string dataToShow = clickedButton.Text;

                if (formMapeltugas == null)
                {
                    formMapeltugas = new Mapeltugas();
                    formMapeltugas.FormClosed += Mapeltugas_FormClosed;
                    formMapeltugas.MdiParent = this.MdiParent; // Set MdiParent to the parent of FormKelas1
                    formMapeltugas.Dock = DockStyle.Fill;
                    formMapeltugas.Show();
                }
                else
                {
                    formMapeltugas.Activate();
                }

                this.Close();
            }
        }
        private void Mapeltugas_FormClosed(object sender, FormClosedEventArgs e)
        {
            formMapeltugas = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void FormKelassemua_Load(object sender, EventArgs e)
        {

        }
    }
}
