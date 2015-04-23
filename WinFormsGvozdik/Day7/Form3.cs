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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BackColorWhite();
            if (textBox1.Text != "" && textBox6.Text != "" && textBox2.Text == textBox3.Text && textBox2.Text != "")
            {
                User tempUser = new User() { Login = textBox1.Text, Pas = textBox2.Text, FirstName = textBox4.Text, LastName = textBox5.Name, Email = textBox6.Text };
                Repository.AddNewUser(tempUser);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                if (textBox1.Text == "")
                {
                    textBox1.BackColor = Color.Pink;
                }
                if (textBox6.Text == "")
                {
                    textBox6.BackColor = Color.Pink;
                }
                if (textBox2.Text != textBox3.Text || textBox2.Text == "")
                {
                    textBox2.BackColor = Color.Pink;
                    textBox3.BackColor = Color.Pink;
                    textBox2.Text = "";
                    textBox3.Text = "";
                }
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
            textBox6.BackColor = Color.White;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

            BackColorWhite();
        }

        private void BackColorWhite()
        {
            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
            textBox4.BackColor = Color.White;
            textBox5.BackColor = Color.White;
            textBox6.BackColor = Color.White;
        }
    }
}
