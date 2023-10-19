using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaysOfTheWeek
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

        private void button1_Click(object sender, EventArgs e)
        {
            string[] arr = { "это понедельник", "это вторник", "это среда", "это четверг", "это пятница", "это суббота", "это воскресенье", "такого дня нет" };
            //int input = Convert.ToInt32(textBox1.Text);
            switch (Convert.ToInt32(textBox1.Text))
            {
                case 1:
                    label1.Text = arr[0];
                    break;
                case 2:
                    label1.Text = arr[1];
                    break;
                case 3:
                    label1.Text = arr[2];
                    break;
                case 4:
                    label1.Text = arr[3];
                    break;
                case 5:
                    label1.Text = arr[4];
                    break;
                case 6:
                    label1.Text = arr[5];
                    break;
                case 7:
                    label1.Text = arr[6];
                    break;
                default:
                    label1.Text = arr[7];
                    break;
            }
        }
    }
}
