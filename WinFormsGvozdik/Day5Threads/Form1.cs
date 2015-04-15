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

namespace Day5
{
    public partial class Form1 : Form
    {
        List<Car> cars = new List<Car>();
        List<string> roadsNumber = new List<string>() { "1", "2", "3", "4", "5", "6", "7" };
        List<bool> carsFinish = new List<bool>() { false, false, false, false, false, false, false };
        List<string> carModels = new List<string>() { "Audi", "BMW", "VW", "Dodge", "Pontiac", "Chevrolet", "Opel", "Peugeot", "Citroen", "Renault", "Saab" };
        List<string> counterFinish = new List<string>() { "Победил", "Вторым прибыл", "Третьим прибыл", "Четвертым прибыл", "Пятым прибыл", "Шестым прибыл", "Седьмым прибыл" };
        string winnerMessage = "";

        List<Thread> carsThread = new List<Thread>();
        delegate void CarSpeed(int index);

        Car firstCar;
        Color winerColor;

        int locationY = 40;
        int carCounter = 0;
        bool pauseFlag = false;
        bool yellowFlag = false;

        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = roadsNumber;
            comboBox2.DataSource = carModels;
            comboBox2.SelectedIndex = rnd.Next(carModels.Count);

            button2.Enabled = false;
            button3.Enabled = false;

            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 0;
            progressBar2.Style = ProgressBarStyle.Marquee;
            progressBar2.MarqueeAnimationSpeed = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pause();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Add();
        }

        void Form1_Finish(object sender, EventArgs e)
        {
            Car car = (Car)sender;
            winnerMessage += String.Format(counterFinish[carCounter] + " автомобиль " + car.CarName + " на " + car.CarRoad + " дорожке!\n");
        }

        private void Add()
        {
            cars.Add(new Car() { CarName = comboBox2.Text, CarRoad = comboBox1.Text, Location = new Point(20, locationY), Text = comboBox2.Text });
            carsThread.Add(new Thread(ThreadProcess));
            cars.Last().Finish += Form1_Finish;
            this.Controls.Add(cars.Last());
            cars.Last().BringToFront();
            cars.Last().BackColor = Color.White;
            firstCar = cars.Last();
            yellowFlag = true;

            locationY += 30;

            roadsNumber.Remove(comboBox1.Text);

            comboBox2.SelectedIndex = rnd.Next(carModels.Count);

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
                comboBox2.SelectedIndex = rnd.Next(carModels.Count);
            }
        }

        private void ThreadProcess(object index)
        {
            CarSpeed carSpeed = new CarSpeed(MoveCar);
            while (true)
            {
                Invoke(carSpeed, new object[] { index });
                Thread.Sleep(100);
            }
        }

        private void MoveCar(int i)
        {
            winerColor = Color.FromArgb((byte)rnd.Next(255), (byte)rnd.Next(255), (byte)rnd.Next(255));

            if (carsFinish[i] == false)
            {
                if(yellowFlag == true)
                {
                    firstCar.BackColor = Color.Yellow;
                    yellowFlag = false;
                }
                if (firstCar.Left < cars[i].Left)
                {
                    Car secondCar = firstCar;
                    firstCar = cars[i];
                    firstCar.BackColor = Color.Yellow;
                    secondCar.BackColor = Color.White;
                }

                cars[i].Left += rnd.Next(1, 10) + trackBar1.Value;

                if ((cars[i].Left + cars[i].Width) >= pictureBox2.Left)
                {
                    if (carCounter == 0)
                    {
                        cars[i].BackColor = Color.Yellow;
                    }
                    else
                    {
                        cars[i].BackColor = winerColor;
                    }
                    carsThread[i].Abort();
                    cars[i].OnFinish();
                    carsFinish[i] = true;
                    carCounter++;
                }
            }

            if (carCounter == cars.Count)
            {
                button3.Enabled = false;

                progressBar1.MarqueeAnimationSpeed = 0;
                progressBar2.MarqueeAnimationSpeed = 0;

                MessageBox.Show(winnerMessage);
                return;
            }
        }

        private void Start()
        {
            if (cars.Count > 1)
            {
                for (int i = 0; i < carsThread.Count; i++)
                {
                    carsThread[i].Start(i);
                }
                button1.Enabled = false;
                button2.Enabled = true;
                button3.Enabled = true;
                trackBar1.Enabled = false;
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                button4.Enabled = false;

                progressBar1.MarqueeAnimationSpeed = 30;
                progressBar2.MarqueeAnimationSpeed = 30;
            }
            else
            {
                MessageBox.Show("Добавьте хотя бы две машины!");
            }
        }

        private void Pause()
        {
            if (pauseFlag)
            {
                for (int i = 0; i < carsThread.Count; i++)
                {
                    carsThread[i].Resume();
                }

                button3.Text = "Пауза";
                pauseFlag = false;

                progressBar1.MarqueeAnimationSpeed = 30;
                progressBar2.MarqueeAnimationSpeed = 30;
            }
            else
            {
                for (int i = 0; i < carsThread.Count; i++)
                {
                    carsThread[i].Suspend();
                }

                button3.Text = "Продолжить";
                pauseFlag = true;

                progressBar1.MarqueeAnimationSpeed = 0;
                progressBar2.MarqueeAnimationSpeed = 0;
            }
        }

        private void Stop()
        {
            for (int i = 0; i < carsThread.Count; i++)
            {
                if (carsThread[i].ThreadState == ThreadState.Suspended)
                {
                    carsThread[i].Resume();
                    carsThread[i].Abort();
                }
                else
                {
                    carsThread[i].Abort();
                }
            }
            carsThread = new List<Thread>();

            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            button3.Text = "Пауза";
            trackBar1.Enabled = true;
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            button4.Enabled = true;

            progressBar1.MarqueeAnimationSpeed = 0;
            progressBar2.MarqueeAnimationSpeed = 0;

            carCounter = 0;
            locationY = 40;
            pauseFlag = false;
            yellowFlag = false;
            winnerMessage = "";

            carsFinish = new List<bool>() { false, false, false, false, false, false, false };

            comboBox1.DataSource = null;
            comboBox1.DataSource = roadsNumber = new List<string>() { "1", "2", "3", "4", "5", "6", "7" };

            while(cars.Count != 0)
            {
                this.Controls.Remove(cars.Last());
                cars.Remove(cars.Last());
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            for(int i = 0; i < carsThread.Count; i++)
            {
                if(carsThread[i].ThreadState != ThreadState.Stopped)
                {
                    carsThread[i].Abort();
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
