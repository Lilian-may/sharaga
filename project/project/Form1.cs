using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
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
            button1.Hide();
            button1.Refresh();
            ///this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            Thread thread = new Thread(dance);
            thread.Start();
        }

        private void dance()
        {
            int init = 0;
            string[] listimage = {
            "Resources\\images\\kit2.png",
            "Resources\\images\\kit1.png",
            "Resources\\images\\kit3.png"        };
            SoundPlayer simpleSound = new SoundPlayer(@"Resources\music\background_sound.wav");
            simpleSound.PlayLooping(); //!!!!!!!!!!!!!!!!!!!!!!!!!!!НЕ ЗАБУДЬ УБАВИТЬ ЗВУК НА КОМПЕ!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            while (true)
            {
                pictureBox1.Image = Image.FromFile(listimage[(init + 2) % 3]);
                pictureBox2.Image = Image.FromFile(listimage[(init + 1) % 3]);
                pictureBox3.Image = Image.FromFile(listimage[(init + 3) % 3]);
                //pictureBox1.Refresh();
                //pictureBox2.Refresh();
                Thread.Sleep(225);

                init = (init + 1) % 3;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
