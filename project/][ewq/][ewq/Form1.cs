using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace __ewq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text), y = double.Parse(textBox2.Text), z = double.Parse(textBox3.Text);
            double u = Math.Pow(Math.Tan(x + y), 2) - (Math.Pow(Math.E, y - z) * Math.Sqrt(Math.Cos(Math.Pow(x, 2)) + Math.Sin(Math.Pow(z, 2))));
            textBox4.Text = "Лаб. Раб. N1 ст. гр. ИСП-24 Кузьмин.А.О, Грязнов.Н.С, Стрельцов.Е.В, Лобанов.Я.В" + Environment.NewLine + $"X = {x}" + Environment.NewLine + $"Y = {y}" + Environment.NewLine + $"Z = {z}" + Environment.NewLine + $"Результат U = {u}";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
