using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Teatr
{
    public partial class FormCreate : Form
    {
        static string path = @"D:\Visual Studio\Teatr\test.txt";
        public FormCreate()
        {
            InitializeComponent();
            textBox5.Text = $"{textBox1.Text} - {textBox2.Text}, {textBox3.Text}, {textBox4.Text}";
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox5.Text = $"{textBox1.Text} - {textBox2.Text}, {textBox3.Text}, {textBox4.Text}";
        }
        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            textBox5.Text = $"{textBox1.Text} - {textBox2.Text}, {textBox3.Text}, {textBox4.Text}";
        }
        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            textBox5.Text = $"{textBox1.Text} - {textBox2.Text}, {textBox3.Text}, {textBox4.Text}";
        }
        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
            textBox5.Text = $"{textBox1.Text}-  {textBox2.Text}, {textBox3.Text}, {textBox4.Text}";
        }



        private void rjButton1_Click(object sender, EventArgs e)
        {
            string[] all = new string[File.ReadAllLines(path).Length];
            all = File.ReadAllLines(path);
            int count = 1;
            for (int i = 0; i < all.Length; i++)
            {
                for (int j = 0; j < all[i].Length; j++)
                {
                    if (all[i][j] == '.' && all[i][j + 1] == ' ') { count++; break; }
                }
            }
            StreamWriter writer = new StreamWriter(path, true);
            writer.WriteLine($"{count}. {textBox5.Text}");
            writer.WriteLine("Пьесы:");
            writer.WriteLine("p");
            writer.Close();
            this.Close();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
