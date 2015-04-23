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
    public partial class Form1 : Form
    {
        bool timerFlag;

        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HideControls();

            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;

            this.Visible = false;
            Forms.form2.ShowDialog();
            this.Visible = true;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HideControls();

            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;

            this.Visible = false;
            Forms.form3.ShowDialog();
            this.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();

            User tempUser = new User() { Login = textBox1.Text, Pas = textBox2.Text };

            if (Repository.CheckUser(tempUser))
            {
                textBox3.Hide();
                label3.Hide();
                progressBar1.Show();

                timerFlag = true;
            }
            else
            {
                textBox3.Hide();
                label3.Hide();
                progressBar1.Show();

                timerFlag = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HideControls();

            textBox1.Text = "";
            textBox2.Text = "";

            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;

            textBox3.BackColor = Color.Pink;
            label3.BackColor = Color.Pink;



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            if (timerFlag)
            {
                HideControls();

                this.Visible = false;
                Forms.form4.Show();
            }
            else
            {
                progressBar1.Hide();
                textBox3.Show();
                label3.Show();

                textBox1.BackColor = Color.Pink;
                textBox2.BackColor = Color.Pink;
                textBox2.Text = "";
            }
        }

        private void textBox1_GotFocus(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
        }

        private void textBox1_LostFocus(object sender, EventArgs e)
        {
            HideControls();
        }

        private void HideControls()
        {
            progressBar1.Hide();
            textBox3.Hide();
            label3.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '\0';
            if (checkBox1.Checked == false)
            {
                textBox2.PasswordChar = '*';
            }
        }
    }
}
