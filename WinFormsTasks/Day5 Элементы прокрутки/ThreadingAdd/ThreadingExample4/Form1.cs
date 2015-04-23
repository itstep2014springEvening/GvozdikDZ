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

namespace ThreadingExample4
{

    delegate void Help(int Num);
    public partial class Form1 : Form
    {
        Help helper;
        Thread thread;
        public Form1()
        {
            InitializeComponent();
            helper = new Help(UpdateForm);
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            thread = new Thread(GetNum);
            thread.Start();
        }

        void UpdateForm(int Num)
        {
            buttonTest1.Text = Num.ToString();
        }

        void GetNum()
        {
            for (int i = 0; i < 100000; i++)
            {
                Object [] mas=new object[1];
                mas[0]=i;
                Invoke(new Help(UpdateForm), mas);
            }
        }
        
        private void btnPause_Click(object sender, EventArgs e)
        {
           
              thread.Resume();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            thread.Suspend();
        }

    }
}
