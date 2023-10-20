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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Teatr
{
    public partial class FormPes : Form
    {
        static string path = @"D:\Visual Studio\Teatr\test.txt";
        public FormPes()
        {
            listBox2 = new ListBox();
            InitializeComponent();
            string[] all = new string[File.ReadAllLines(path).Length];
            all = File.ReadAllLines(path);

            for (int i = 0; i < all.Length; i++)
            {
                for (int j = 0; j < all[i].Length; j++)
                {
                    if (all[i][j] == '.' && all[i][j + 1] == ' ') { listBox2.Items.Add(all[i]); break; }
                }
            }
        }
        private void rjButton2_Click(object sender, EventArgs e)
        {
            string[] all = new string[File.ReadAllLines(path).Length];
            all = File.ReadAllLines(path);
            int count = 1;
            List<string> lines = File.ReadAllLines(path).ToList();
            File.WriteAllLines(path, lines.GetRange(0, lines.Count - 1).ToArray());
            StreamWriter writer = new StreamWriter(path, true);
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                writer.WriteLine($"{count++}) {listBox1.Items[i]}");
            }
            writer.WriteLine("p");
            writer.Close();
            this.Close();

        }
        private void rjButton1_Click(object sender, EventArgs e)
        {
            string result = $"{textBox1.Text} {textBox2.Text}";
            listBox1.Items.Add(result);
        }
        private void rjButton3_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
    }
}
