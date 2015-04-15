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

namespace Day6KP
{
    public partial class Form1 : Form
    {
        string[] files;

        int imgNum = 0;
        FileInfo fileInfo;
        Image image;
        string adress;
        bool imageZoom = false;
        bool fullScreen = false;

        int height;
        int width;

        public Form1()
        {
            InitializeComponent();
        }

        private void ImageShow()
        {
            fileInfo = new FileInfo(files[imgNum]);
            image = Bitmap.FromFile(files[imgNum]);

            width = image.Width;
            height = image.Height;

            pictureBox1.Image = image;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                adress = textBox1.Text;

                trackBar1.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;

                files = Directory.GetFiles(textBox1.Text, "*.jpg", SearchOption.AllDirectories);

                ImageShow();
            }
            catch (DirectoryNotFoundException dirEx)
            {
                MessageBox.Show(dirEx.Message);
            }
        }

        private void FullScreen()
        {
            if (fullScreen == true)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.ControlBox = false;
                this.WindowState = FormWindowState.Maximized;

            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.ControlBox = true;
                this.StartPosition = FormStartPosition.WindowsDefaultLocation;
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pictureBox1.Width = width / trackBar1.Maximum * trackBar1.Value;
            pictureBox1.Height = height / trackBar1.Maximum * trackBar1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(imgNum == 0)
            {
                imgNum = files.Count() - 1;
            }
            else
            {
                imgNum--;
            }

            ImageShow();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (imgNum < files.Count() - 1)
            {
                imgNum++;
            }
            else
            {
                imgNum = 0;
            }

            ImageShow();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fullScreen = true;
            FullScreen();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            image.RotateFlip(RotateFlipType.Rotate90FlipXY);
            pictureBox1.Image = image;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            image.RotateFlip(RotateFlipType.Rotate270FlipXY);
            pictureBox1.Image = image;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (imageZoom == false)
            {
                imageZoom = true;
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            }
            else
            {
                imageZoom = false;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trackBar1.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            fullScreen = false;
            FullScreen();
        }
    }
    public class Picture
    {
        public string Name { get; set; }
        public string Format { get; set; }
        public string Adress { get; set; }
    }
}
