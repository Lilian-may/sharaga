using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using fgefwgiefgewui.Properties;
using static System.Net.Mime.MediaTypeNames;

namespace fgefwgiefgewui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Pass the filepath and filename to the StreamWriter Constructor
            StreamWriter sw = new StreamWriter("Resources\\docs\\nums.txt");

            for (int i = 10; i <= 99; ++i)
            {
                if (i % 10 == (i % 100) / 10)
                {
                    textBox1.Text += Convert.ToString(i) + " ";
                }
            }

            for (int i = 1000; i <= 9999; ++i) {
                if (i % 10 + (i % 100) / 10 == (i % 1000) / 100 + (i % 10000) / 1000)
                {
                    textBox3.Text += Convert.ToString(i) + " ";
                    //write
                    sw.WriteLine("\n{0}", i);
                }
            }
            //Close the file
            sw.Close();


            int n = 0, txtb = Convert.ToInt32(textBox2.Text);
            textBox2.Text = "";
            for (int i = 2; i < txtb; ++i)
            {
                if (txtb % i == 0)
                {
                    textBox2.Text += Convert.ToString(i) + " ";
                    ++n;
                }
                if (i == txtb - 1)
                {
                    textBox2.Text += "\n" + Convert.ToString(n);
                }
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
