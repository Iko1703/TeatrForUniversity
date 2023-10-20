using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teatr
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            label2.Hide();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1" && textBox2.Text == "1")
            {
                Form1 start = new Form1();
                this.Hide();
                start.ShowDialog();
                this.Close();

            }
            else
            {
                label2.Show();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
