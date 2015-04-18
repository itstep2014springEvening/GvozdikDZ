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

namespace ThreadingExample111
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // запуск потока!
        private void btnStart_Click(object sender, EventArgs e)
        {
            // создание нового потока, который будет выполнять в фоне метод ThreadProcess
            Thread th = new Thread(ThreadProcess);
            // запуск потока 
            th.Start();
            // отображение текста из главного потока!
            myTextBox.Text = "Информация из основного потока!";
        }

        // метод, который выполняется в дополнительном потоке!
        private void ThreadProcess()
        {  // приостановка дополнительного потока (для имитации задержки!)
            Thread.Sleep(2000);
            //отображение текста из дополнительного потока!
            myTextBox.Text = "Информация из дополнительного потока!";
        }
    }
}
