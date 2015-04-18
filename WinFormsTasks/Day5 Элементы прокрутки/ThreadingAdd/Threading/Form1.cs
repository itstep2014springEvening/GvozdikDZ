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

namespace Threading
{
   
    /* ссылки
    https://msdn.microsoft.com/ru-ru/library/ms171728%28v=vs.110%29.aspx

    */

   // создание делегата для вызова  метода SetText      
   delegate void SetTextCallback(string text);
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
           string text = "Информация из дополнительного потока!";

           // проверка! свойство InvokeRequired возвращает значение false, 
           // если метод Invoke не требуется (вызов происходит из того же потока) 
         
           if (this.myTextBox.InvokeRequired)
           {
               // создание объекта делегата для вызова метода SetText
               // который получает доступ к элементу формы главного потока!
                SetTextCallback d = new SetTextCallback(SetText);
                // вызов метода SetText с передачей параметра 
               this.Invoke(d, new object[] { text + " (Invoke)" });
           }
            else
            {
             
                this.myTextBox.Text = text + " (No Invoke)";
            }
        }
        // функция вывода на экран текста!
        private void SetText(string text)
        {
            this.myTextBox.Text = text;
        }

       

    }
  }

