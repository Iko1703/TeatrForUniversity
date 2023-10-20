using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Teatr
{
    public partial class Formdelete : Form
    {
        static string path = @"D:\Visual Studio\Teatr\test.txt";
        public Formdelete()
        {
            InitializeComponent();
            string[] all = new string[File.ReadAllLines(path).Length];
            all = File.ReadAllLines(path);

            for (int i = 0; i < all.Length; i++)
            {
                for (int j = 0; j < all[i].Length; j++)
                {
                    if (all[i][j] == '.' && all[i][j + 1] == ' ') { listBox1.Items.Add(all[i]); break; }
                }
            }


        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            string need = textBox1.Text;
            string[] all = new string[File.ReadAllLines(path).Length];
            all = File.ReadAllLines(path);
            File.WriteAllText(path, string.Empty);
            for (int i = 0; i < all.Length; i++)
            {
                StreamWriter writer = new StreamWriter(path, true);

                if (all[i] == need)
                {
                    while (all[i] != "p")
                    {
                        i++;
                    }                   
                }
                writer.WriteLine(all[i]);
                writer.Close();
            }
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            string[] all = new string[File.ReadAllLines(path).Length];
            all = File.ReadAllLines(path);
            string sel = listBox1.SelectedItem.ToString();

            for (int i = 0; i < all.Length; i++)
            {
                if (all[i] == sel)
                {
                    while (all[i] != "p")
                    {

                        listBox2.Items.Add(all[i]);
                        i++;
                    }
                    break;
                }
            }
            textBox1.Text = listBox1.SelectedItem.ToString();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = listBox2.SelectedItem.ToString();
        }
    }
}
