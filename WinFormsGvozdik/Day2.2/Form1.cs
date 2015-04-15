using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Day2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            ButtonMove();
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            ButtonMove();
        }
        private void ButtonMove()
        {
            Random rnd = new Random();
            button1.Left = rnd.Next(0, this.ClientSize.Width);
            button1.Top = rnd.Next(0, this.ClientSize.Height);
        }
    }
}
