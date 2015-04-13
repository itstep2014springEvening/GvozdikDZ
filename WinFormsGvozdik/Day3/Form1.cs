using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day3
{
    public partial class Form1 : Form
    {

        List<Mobile> phones;
        List<Option> options;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            phones = new List<Mobile>() { new Mobile (){ Picture="samsung.jpg", Model="Samsung", OS="Android", Price="300", Processor="ARM", Options = new List<Option>(){new Option(){ Name="WI-FI" }, new Option(){ Name="GPS" }, new Option(){ Name="SMS" }}},
                                                       new Mobile (){ Picture="iphone.jpg", Model="Iphone", OS="IOS", Price="800", Processor="Cortex", Options = new List<Option>(){new Option(){ Name="GPS" }}},
                                                       new Mobile (){ Picture="nokia.jpg", Model="Nokia", OS="Windows Phone", Price="200", Processor="ARM", Options = new List<Option>(){new Option(){ Name="WI-FI" }}},
                                                       new Mobile (){ Picture="sony.jpg", Model="Sony", OS="Android", Price="500", Processor="ARM", Options = new List<Option>(){new Option(){ Name="WI-FI" }}},
                                                       new Mobile (){ Picture="alcatel.jpg", Model="Alcatel", OS="Alcatel", Price="1", Processor="ARM", Options = new List<Option>(){new Option(){ Name="2Sim" }}},
                                                       new Mobile (){ Picture="nokiasymb.jpg", Model="Nokia E60", OS="Symbian", Price="150", Processor="ARM", Options = new List<Option>(){new Option(){ Name="WI-FI" }}} };
            options = new List<Option>() { new Option() { Name = "WI-FI" }, new Option() { Name = "GPS" }, new Option() { Name = "SMS" }, new Option() { Name = "HDPA" }, new Option() { Name = "Камера" }, new Option() { Name = "Автофокус" }, new Option() { Name = "Сенсор" } };
            listBox1.DataSource = phones;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;
            pictureBox1.ImageLocation = phones[listBox1.SelectedIndex].Picture;
            textBox1.Text = textBox5.Text = phones[listBox1.SelectedIndex].Model;
            textBox2.Text = textBox6.Text = phones[listBox1.SelectedIndex].OS;
            textBox3.Text = textBox7.Text = phones[listBox1.SelectedIndex].Processor;
            textBox4.Text = textBox9.Text = phones[listBox1.SelectedIndex].Price;
            textBox8.Text = phones[listBox1.SelectedIndex].Picture;
            listBox2.DataSource = phones[listBox1.SelectedIndex].Options;
            checkedListBox1.DataSource = options;

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }  

            foreach (Option o in phones[listBox1.SelectedIndex].Options)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    if (o.Name.Trim() == checkedListBox1.Items[i].ToString().Trim())
                    {
                        checkedListBox1.SetItemChecked(i, true);
                    }
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
        
            phones[listBox1.SelectedIndex].Model = textBox5.Text;
            phones[listBox1.SelectedIndex].OS = textBox6.Text;
            phones[listBox1.SelectedIndex].Processor = textBox7.Text;
            phones[listBox1.SelectedIndex].Picture = textBox8.Text;
            phones[listBox1.SelectedIndex].Price = textBox9.Text;
            listBox1.DataSource = null;
            listBox1.DataSource = phones;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Option temp = options.FirstOrDefault(p => p.Name == textBox10.Text.Trim());
            if (temp == null && textBox10.Text.Trim() != "")
            {
                options.Add(new Option() { Name = textBox10.Text.Trim() });
            }
            
            checkedListBox1.DataSource = null;
            checkedListBox1.DataSource = options;
            foreach (Option o in phones[listBox1.SelectedIndex].Options)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    if (o.Name.Trim() == checkedListBox1.Items[i].ToString().Trim())
                    {
                        checkedListBox1.SetItemChecked(i, true);
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedIndex == -1) return;

            options.Remove(options[checkedListBox1.SelectedIndex]);
            checkedListBox1.DataSource = null;
            checkedListBox1.DataSource = options;

            foreach (Option o in phones[listBox1.SelectedIndex].Options)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    if (o.Name.Trim() == checkedListBox1.Items[i].ToString().Trim())
                    {
                        checkedListBox1.SetItemChecked(i, true);
                    }
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            List<Option> tempOption = new List<Option>();
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if(checkedListBox1.GetItemChecked(i))
                {
                    tempOption.Add(new Option() { Name = checkedListBox1.Items[i].ToString() });
                }
            }
            phones.Add(new Mobile() { Picture = textBox8.Text, Model = textBox5.Text, OS = textBox6.Text, Price = textBox9.Text, Processor = textBox7.Text, Options = tempOption });
            listBox1.DataSource = null;
            listBox1.DataSource = phones;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;
            phones.Remove(phones[listBox1.SelectedIndex]);
            listBox1.DataSource = null;
            listBox1.DataSource = phones;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            phones.Clear();
            listBox1.DataSource = null;
        }

      
    }
    class Mobile
    {
        public string Picture { get; set; }
        public string Model { get; set; }
        public string OS { get; set; }
        public string Processor { get; set; }
        public string Price { get; set; }
        public List<Option> Options { get; set; }

       
        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3}", Model, OS, Processor, Price);
        }
    }
    class Option
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1}", Name, Description);
        }
    }
}
