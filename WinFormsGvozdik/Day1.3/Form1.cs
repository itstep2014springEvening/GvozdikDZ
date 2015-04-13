using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Day1._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Game.Message("Загадайте число от {0} до {1}?", Game.First, Game.Second);
            while (Game.First + 1 != Game.Second && Game.Cancel == false)
            {
                switch (MessageBox.Show(Game.Str, "Вопрос?", MessageBoxButtons.YesNoCancel))
                {
                    case (DialogResult.Yes):
                        Game.YesAnswer();
                        break;
                    case (DialogResult.No):
                        Game.NoAnswer();
                        break;
                    default:
                        Game.CancelAnswer();
                        break;
                }
            }
            if (Game.Cancel == false)
            {
                string message = String.Format("Вы загадали число: {0}?", Game.First);
                if (DialogResult.OK == MessageBox.Show(message, "Вопрос?", MessageBoxButtons.OKCancel))
                {
                    Game.Message("Вы загадали число: {0}?\nЯ его угадал с {1} попытки", Game.First, Game.Counter);
                }
                else
                {
                    Game.Message("Вы загадали число: {0}?\nЯ его угадал с {1} попытки", Game.Second, Game.Counter + 1);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Close();
        }
    }
    public class Game
    {
        private static uint counter = 0;
        private static uint first = 0;
        private static uint second = 2000;
        private static uint number = second / 2;
        private static bool cancel = false;
        private static string str = String.Format("Ваше число больше {0}", number);

        public static uint Counter
        {
            get { return Game.counter; }
        }
        public static uint First
        {
            get { return Game.first; }
        }
        public static uint Second
        {
            get { return Game.second; }
        }
        public static bool Cancel
        {
            get { return Game.cancel; }
        }
        public static string Str
        {
            get { return Game.str; }
        }

        public static void YesAnswer()
        {
            first = number;
            number = first + (second - first) / 2;
            str = String.Format("Ваше число больше {0}", number);
            counter++;
        }
        public static void NoAnswer()
        {
            second = number;
            number = second - (second - first) / 2;
            str = String.Format("Ваше число больше {0}", number);
            counter++;
        }
        public static void CancelAnswer()
        {
            cancel = true;
        }
        public static void Message(string message, uint firstArg, uint secondArg)
        {
            message = String.Format(message, firstArg, secondArg);
            MessageBox.Show(message);
        }
    }
}
