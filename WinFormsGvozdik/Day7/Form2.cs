using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User tempUser = new User() { Email = textBox1.Text, Pas = textBox2.Text };
            if (Repository.ChangePas(tempUser))
            {
                if (textBox2.Text == textBox3.Text && textBox2.Text != "")
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    textBox2.BackColor = Color.Pink;
                    textBox3.BackColor = Color.Pink;
                }
            }
            else
            {
                textBox1.BackColor = Color.Pink;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void textBox1_GotFocus(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
        }
    }
}
