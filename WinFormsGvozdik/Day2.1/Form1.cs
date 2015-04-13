using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Day2_1
{
    public partial class Form1 : Form
    {
        List<Gasoline> gasoline;
        List<Kafe> kafe;
        CheckCalc cb1 = new CheckCalc();
        CheckCalc cb2 = new CheckCalc();
        CheckCalc cb3 = new CheckCalc();
        CheckCalc cb4 = new CheckCalc();
        CheckCalc cb5 = new CheckCalc();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gasoline = new List<Gasoline> { new Gasoline { Name = "Аи-92", Price = "10000" }, 
                                            new Gasoline { Name = "А-95", Price = "11000" }, 
                                            new Gasoline { Name = "А-98", Price = "13000" }, 
                                            new Gasoline { Name = "ДТ", Price = "12000" } };
            kafe = new List<Kafe> { new Kafe { Name = "Хот-дог", Price = "5500" }, 
                                    new Kafe { Name = "Гамбургер", Price = "6000" }, 
                                    new Kafe { Name = "Чизбургер", Price = "7000" },
                                    new Kafe { Name = "Картошка", Price = "4500" },
                                    new Kafe { Name = "Кока-кола", Price = "4000" } };

            comboBox1.DataSource = gasoline;
            radioButton1.PerformClick();
            textBox9.ReadOnly = true;
            textBox10.ReadOnly = true;
            textBox11.ReadOnly = true;
            textBox12.ReadOnly = true;
            textBox13.ReadOnly = true;
            textBox4.Text = kafe[0].Price;
            textBox5.Text = kafe[1].Price;
            textBox6.Text = kafe[2].Price;
            textBox7.Text = kafe[3].Price;
            textBox8.Text = kafe[4].Price;
            textBox9.Text = "1";
            textBox10.Text = "1";
            textBox11.Text = "1";
            textBox12.Text = "1";
            textBox13.Text = "1";
            textBox15.Text = "0";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = gasoline[comboBox1.SelectedIndex].Price;
            textBox2_TextChanged(sender, e);
            textBox3_TextChanged(sender, e);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox14.Text = textBox3.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * Convert.ToDouble(gasoline[comboBox1.SelectedIndex].Price));
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox14.Text = textBox3.Text;
            textBox2.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) / Convert.ToDouble(gasoline[comboBox1.SelectedIndex].Price));
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox9.ReadOnly = false;
                textBox15.Text = cb1.Sum(textBox15.Text, textBox4.Text);
            }
            else
            {
                textBox9.ReadOnly = true;
                textBox15.Text = cb1.Sub(textBox15.Text, textBox4.Text);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox10.ReadOnly = false;
                textBox15.Text = Convert.ToString(Convert.ToDouble(textBox15.Text) + Convert.ToDouble(textBox5.Text) * Convert.ToDouble(textBox10.Text));
            }
            else
            {
                textBox10.ReadOnly = true;
                textBox15.Text = Convert.ToString(Convert.ToDouble(textBox15.Text) - Convert.ToDouble(textBox5.Text) * Convert.ToDouble(textBox10.Text));
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                textBox11.ReadOnly = false;
                textBox15.Text = Convert.ToString(Convert.ToDouble(textBox15.Text) + Convert.ToDouble(textBox6.Text) * Convert.ToDouble(textBox11.Text));
            }
            else
            {
                textBox11.ReadOnly = true;
                textBox15.Text = Convert.ToString(Convert.ToDouble(textBox15.Text) - Convert.ToDouble(textBox6.Text) * Convert.ToDouble(textBox11.Text));
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                textBox12.ReadOnly = false;
                textBox15.Text = Convert.ToString(Convert.ToDouble(textBox15.Text) + Convert.ToDouble(textBox7.Text) * Convert.ToDouble(textBox12.Text));
            }
            else
            {
                textBox12.ReadOnly = true;
                textBox15.Text = Convert.ToString(Convert.ToDouble(textBox15.Text) - Convert.ToDouble(textBox7.Text) * Convert.ToDouble(textBox12.Text));
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                textBox13.ReadOnly = false;
                textBox15.Text = Convert.ToString(Convert.ToDouble(textBox15.Text) + Convert.ToDouble(textBox8.Text) * Convert.ToDouble(textBox13.Text));
            }
            else
            {
                textBox13.ReadOnly = true;
                textBox15.Text = Convert.ToString(Convert.ToDouble(textBox15.Text) - Convert.ToDouble(textBox8.Text) * Convert.ToDouble(textBox13.Text));
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (textBox15.Text != "" && textBox9.Text != "")
            {
                textBox15.Text = cb1.Sum(textBox15.Text, textBox4.Text);
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox15.Text != "" && textBox10.Text != "")
            {
                textBox15.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) * Convert.ToDouble(textBox10.Text));
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (textBox15.Text != "" && textBox11.Text != "")
            {
                textBox15.Text = Convert.ToString(Convert.ToDouble(textBox6.Text) * Convert.ToDouble(textBox11.Text));
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            if (textBox15.Text != "" && textBox12.Text != "")
            {
                textBox15.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * Convert.ToDouble(textBox12.Text));
            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            if (textBox15.Text != "" && textBox13.Text != "")
            {
                textBox15.Text = Convert.ToString(Convert.ToDouble(textBox8.Text) * Convert.ToDouble(textBox13.Text));
            }
        }
    }
    class Gasoline
    {
        public string Name { get; set; }
        public string Price { get; set; }

        public override string ToString()
        {
            return String.Format("{0}", Name);
        }
    }
    class Kafe
    {
        public string Name { get; set; }
        public string Price { get; set; }

        public override string ToString()
        {
            return String.Format("{0}", Price);
        }
    }
    class CheckCalc
    {
        public string Sum(string first, string second)
        {
            return Convert.ToString(Convert.ToDouble(first) + Convert.ToDouble(second));
        }
        public string Sub(string first, string second)
        {
            return Convert.ToString(Convert.ToDouble(first) - Convert.ToDouble(second));
        }
    }
}
