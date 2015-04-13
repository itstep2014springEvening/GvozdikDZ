using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day4
{
    public partial class Form1 : Form
    {
        List<string> seconds;
        uint chooseTime;
        uint currentTime;

        byte R;
        byte G;
        byte B;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            seconds = new List<string>() { "60", "50", "40", "30", "20", "10", "5" };
            comboBox1.DataSource = seconds;
            trackBar1.Enabled = false;
            trackBar2.Enabled = false;
            trackBar3.Enabled = false;
            button2.Enabled = false;
            button1.Focus();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            R = (byte)rnd.Next(255);
            G = (byte)rnd.Next(255);
            B = (byte)rnd.Next(255);
            Color color = Color.FromArgb(R, G, B);
            pictureBox1.BackColor = color;

            trackBar1.Value = 0;
            trackBar2.Value = 0;
            trackBar3.Value = 0;

            pictureBox2.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);

            textBox8.Text = trackBar1.Value.ToString();
            textBox9.Text = trackBar2.Value.ToString();
            textBox10.Text = trackBar3.Value.ToString();
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;
            textBox7.Text = null;
            textBox11.Text = null;
            textBox12.Text = null;
            textBox13.Text = null;

            chooseTime = Convert.ToUInt32(seconds[comboBox1.SelectedIndex]);
            progressBar1.Maximum = (int)chooseTime;
            progressBar1.Value = 0;
            currentTime = 0;
            comboBox1.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = true;
            trackBar1.Enabled = true;
            trackBar2.Enabled = true;
            trackBar3.Enabled = true;

            button2.Focus();

            timer1.Interval = 1000;
            timer1.Start();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            progressBar1.Value = 0;

            textBox11.Text = R.ToString();
            textBox12.Text = G.ToString();
            textBox13.Text = B.ToString();

            comboBox1.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = false;
            trackBar1.Enabled = false;
            trackBar2.Enabled = false;
            trackBar3.Enabled = false;

            GameResult();

            button1.Focus();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox8.Text = trackBar1.Value.ToString();
            textBox9.Text = trackBar2.Value.ToString();
            textBox10.Text = trackBar3.Value.ToString();
            pictureBox2.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value); ;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentTime++;
            progressBar1.Value = (int)currentTime;
            if (currentTime == chooseTime)
            {
                timer1.Stop();

                progressBar1.Value = 0;

                textBox11.Text = R.ToString();
                textBox12.Text = G.ToString();
                textBox13.Text = B.ToString();

                comboBox1.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = false;
                trackBar1.Enabled = false;
                trackBar2.Enabled = false;
                trackBar3.Enabled = false;

                if (DialogResult.OK == MessageBox.Show("Время вышло!"))
                {
                    GameResult();
                    button1.Focus();
                }
            }
        }
        private void GameResult()
        {
            byte rRes = (byte)Math.Abs(R - trackBar1.Value);
            byte gRes = (byte)Math.Abs(G - trackBar2.Value);
            byte bRes = (byte)Math.Abs(B - trackBar3.Value);

            double rResPerc = R > (byte)trackBar1.Value ? 100 - (double)rRes / ((double)R - (double)trackBar1.Minimum + 1) * 100 : 100 - (double)rRes / ((double)trackBar1.Maximum + 1 - (double)R) * 100;
            double gResPerc = G > (byte)trackBar2.Value ? 100 - (double)gRes / ((double)G - (double)trackBar2.Minimum + 1) * 100 : 100 - (double)gRes / ((double)trackBar2.Maximum + 1 - (double)G) * 100;
            double bResPerc = B > (byte)trackBar3.Value ? 100 - (double)bRes / ((double)B - (double)trackBar3.Minimum + 1) * 100 : 100 - (double)bRes / ((double)trackBar3.Maximum + 1 - (double)B) * 100;

            double averPerc = (rResPerc + gResPerc + bResPerc) / 3;

            textBox1.Text = Convert.ToString(rRes);
            textBox2.Text = Convert.ToString(gRes);
            textBox3.Text = Convert.ToString(bRes);

            textBox4.Text = String.Format("{0:0.00}", rResPerc);
            textBox5.Text = String.Format("{0:0.00}", gResPerc);
            textBox6.Text = String.Format("{0:0.00}", bResPerc);
            textBox7.Text = String.Format("{0:0.00}", averPerc);

        }
    }
}
