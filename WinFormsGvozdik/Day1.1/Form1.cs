using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Day1._1
{
    public partial class Form1 : Form
    {
        string message;
        int counter = 0;

        public Form1()
        {
            InitializeComponent();
            Message("Привет!", false);
            Message("Это резюме!", false);
            Message("Меня зовут Message!", false);
            Message("Это последний Message!", true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Message(string msg, bool lastMsg)
        {
            if (lastMsg == false)
            {
                counter++;
                Clipboard.SetText(msg);
                message += Clipboard.GetText();
                MessageBox.Show(msg);
            }
            else
            {
                counter++;
                Clipboard.SetText(msg);
                message += Clipboard.GetText();
                MessageBox.Show(msg, Convert.ToString(message.Length / counter));
            }
        }
    }
}
