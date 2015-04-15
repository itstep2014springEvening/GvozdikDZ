using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day5Threads
{
    public partial class Form2 : Form
    {
        uint counterTime = 0;

        Thread opacityThread;

        delegate void OpacityDelegat();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Opacity = .0;
            opacityThread = new Thread(ThreadProcess);
            opacityThread.Start();
        }

        public void ThreadProcess()
        {
            OpacityDelegat opacity = new OpacityDelegat(FormOpacity);
            while (true)
            {
                Invoke(opacity);
                Thread.Sleep(20);
            }
        }

        private void FormOpacity()
        {
            if (counterTime < 100)
            {
                counterTime++;
                this.Opacity += .01;
            }
            else
            {
                this.Close();
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            opacityThread.Abort();
        }
    }
}
