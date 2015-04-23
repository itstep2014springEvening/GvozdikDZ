using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication9
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Car car) 
        {
            InitializeComponent();
            textBox1.Text = car.Name;
        }
        // метод
        public void GetText(string str)
        {
            textBox1.Text = str;
        }
        // свойство
        public string NewText
        {
            set { textBox1.Text = value; }
            get { return textBox1.Text; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
            textBox1.PasswordChar='*';
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '\0';
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
