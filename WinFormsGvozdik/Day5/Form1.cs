using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day5
{
    public partial class Form1 : Form
    {
        List<Car> cars = new List<Car>();
        List<string> roadsNumber = new List<string>() { "1", "2", "3", "4", "5", "6", "7" };
        List<string> carModels = new List<string>() { "Audi", "BMW", "VW", "Dodge", "Pontiac", "Chevrolet", "Opel", "Peugeot", "Renault" };
        Random rnd = new Random();

        int locationY = 40;

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 100;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = roadsNumber;
            comboBox2.DataSource = carModels;
            button2.Enabled = false;
            button3.Enabled = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cars.Count > 1)
            {
                button1.Enabled = false;
                button2.Enabled = true;
                button3.Enabled = true;
                trackBar1.Enabled = false;
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                button4.Enabled = false;

                timer1.Start();
            }
            else
            {
                MessageBox.Show("Добавьте хотя бы две машины!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            trackBar1.Enabled = true;
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            button4.Enabled = true;

            locationY = 40;
            comboBox1.DataSource = null;
            comboBox1.DataSource = roadsNumber = new List<string>() { "1", "2", "3", "4", "5", "6", "7" };

            while(cars.Count != 0)
            {
                this.Controls.Remove(cars.Last());
                cars.Remove(cars.Last());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            cars.Add(new Car() { CarName = comboBox2.Text, CarRoad = comboBox1.Text, Location = new Point(20, locationY), Text = comboBox2.Text });
            cars.Last().Finish += Form1_Finish;
            this.Controls.Add(cars.Last());
            locationY += 30;

            roadsNumber.Remove(comboBox1.Text);

            if (roadsNumber.Count != 0)
            {
                comboBox1.DataSource = null;
                comboBox1.DataSource = roadsNumber;
                comboBox1.SelectedIndex = 0;
            }
            else
            {
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                button4.Enabled = false;
                comboBox1.DataSource = null;
                comboBox1.DataSource = roadsNumber = new List<string>() { "1", "2", "3", "4", "5", "6", "7" };
            }
        }

        void Form1_Finish(object sender, EventArgs e)
        {
            Car car = (Car)sender;
            MessageBox.Show("Win" + car.CarRoad);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < cars.Count; i++)
            {
               
                cars[i].Left += rnd.Next(1, 10) + trackBar1.Value;
                if((cars[i].Left + cars[i].Width) >= pictureBox2.Left)
                {    
                    timer1.Stop();
                    cars[i].OnFinish();
                }
            }
            
        }
    }
    class Car : Button
    {
        public string CarName { get; set; }
        public string CarRoad { get; set; }
        public event EventHandler Finish;

        public void OnFinish()
        {
            if(Finish != null)
            {
                Finish(this, EventArgs.Empty);
            }
        }
    }
}
