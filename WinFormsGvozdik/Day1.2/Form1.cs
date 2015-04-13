using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Day1._2
{
    public partial class Form1 : Form
    {
        int firstPointX = 50;
        int firstPointY = 50;
        int height;
        int width;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            height = Size.Height - firstPointX;
            width = Size.Width - firstPointY;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Y < height && e.X < width && e.Y > firstPointY && e.X > firstPointX)
            {
                Text = String.Format("X = {0}, Y = {1}", e.X, e.Y);
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control && e.Button == MouseButtons.Left)
            {
                Close();
                return;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (e.Y > height || e.X > width || e.Y < firstPointY || e.X < firstPointX)
                {
                    Text = "Точка нажатия снаружи прямоугольника";
                }
                if (e.Y < height && e.X < width && e.Y > firstPointY && e.X > firstPointX)
                {
                    Text = "Точка нажатия внутри прямоугольника";
                }
                if (e.Y == height || e.X == width || e.Y == firstPointY || e.X == firstPointX)
                {
                    Text = "Точка нажатия на границе прямоугольника";
                }
            }
            if (e.Button == MouseButtons.Right)
            {
                Text = String.Format("Ширина = {0}, Высота = {1}", Size.Width, Size.Height);
            }
        }
    }
    class Rectangle
    {
        public int FirstPoint { get; set; }
        public int SecondPoint { get; set; }
        public int ThirdPoint { get; set; }
        public int FirthPoint { get; set; }
    }
}
