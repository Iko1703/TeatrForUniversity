using MySqlX.XDevAPI.Common;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Teatr
{
    public partial class Form1 : Form
    {


        static string path = @"D:\Visual Studio\Teatr\test.txt";
        public Form1()
        {
            InitializeComponent();
            listBox2.Hide();
            textBox1.Hide();
            rjButton4.Hide();

            WMP.URL = @"D:\Visual Studio\Teatr\Ghoul.mp3";

            WMP.settings.volume = 10;
            WMP.controls.play();
        }


        public void addincheck(string text)
        {
            listBox1.Items.Add(text);
        }
        public void addintest(string text)
        {
            StreamWriter writer = new StreamWriter(path, true);
            writer.WriteLine(text);
            writer.WriteLine("p");
            writer.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            listBox1.Items.Clear();
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

        private void button2_Click(object sender, EventArgs e)
        {
            FormPes formPes = new FormPes();
            formPes.ShowDialog();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            FormCreate create = new FormCreate();
            create.ShowDialog();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Formdelete formdelete = new Formdelete();
            formdelete.ShowDialog();

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] all = new string[File.ReadAllLines(path).Length];
            all = File.ReadAllLines(path);

            string sel = listBox1.SelectedItem.ToString();
            listBox1.Items.Clear();
            for (int i = 0; i < all.Length; i++)
            {
                if (all[i] == sel)
                {
                    while (all[i] != "p")
                    {

                        listBox1.Items.Add(all[i]);
                        i++;
                    }
                    break;
                }
            }

        }
        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            double max = 0;
            int rm = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string result = "";
                string x = listBox1.Items[i].ToString();
                for (int j = x.Length - 5; j < x.Length - 2; j++)
                {
                    result += x[j];
                }
                if (max <= Convert.ToDouble(result))
                {
                    max = Convert.ToDouble(result);
                    rm = i;

                }
            }
            string real = listBox1.Items[rm].ToString();
            listBox1.Items.Clear();
            listBox1.Items.Add(real);
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listBox2.Items.Add(listBox1.Items[i].ToString());
            }
            listBox1.Items.Clear();
            int n = listBox2.Items.Count;
            for (int g = 0; g < n; g++)
            {
                double max = 0;
                int rm = 0;
                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    string result = "";
                    string x = listBox2.Items[i].ToString();
                    for (int j = x.Length - 3; j > x.Length - 6; j--)
                    {
                        result += x[j];
                    }
                    if (max <= Convert.ToDouble(result))
                    {
                        max = Convert.ToDouble(result);
                        rm = i;

                    }
                }
                string real = listBox2.Items[rm].ToString();
                listBox1.Items.Add(real);
                listBox2.Items.Remove(real);

            }

        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            textBox1.Show();
            rjButton4.Show();
            listBox2.Items.Clear();
            listBox2.Show();
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string famil = "";
                string x = listBox1.Items[i].ToString();
                for (int j = 0; j < x.Length; j++)
                {
                    if (x[j] == ':')
                    {
                        j += 1;
                        while (x[j] != ',')
                        {

                            famil += x[j];
                            j++;

                        }

                        break;
                    }

                }
                listBox2.Items.Add(famil);
            }

        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            string result = textBox1.Text;
            result += ",";
            int rm = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string famil = "";
                string x = listBox1.Items[i].ToString();
                for (int j = 0; j < x.Length; j++)
                {
                    if (x[j] == ':')
                    {
                        j += 1;
                        while (x[j] != ',')
                        {
                            j++;
                            famil += x[j];

                        }

                        break;
                    }

                }
                if (result == famil)
                {
                    rm = i;
                }
            }
            string real = listBox1.Items[rm].ToString();
            listBox1.Items.Clear();
            listBox1.Items.Add(real);
            string[] all = new string[File.ReadAllLines(path).Length];
            all = File.ReadAllLines(path);

            string sel = listBox1.Items[0].ToString();
            listBox1.Items.Clear();
            for (int i = 0; i < all.Length; i++)
            {
                if (all[i] == sel)
                {
                    while (all[i] != "p")
                    {

                        listBox1.Items.Add(all[i]);
                        i++;
                    }
                    break;
                }
            }

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            string x = listBox2.SelectedItem.ToString();
            string result = "";
            int y = x.Length;
            for (int i = 1; i < y; i++)
            {
                result += x[i];
            }
            textBox1.Text = result;

        }
        public WMPLib.WindowsMediaPlayer WMP = new WMPLib.WindowsMediaPlayer();
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            WMP.settings.volume = 10;


        }

        private void button4_Click_1(object sender, EventArgs e)
        {



        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WMP.settings.volume = 0;
        }
    }
}
