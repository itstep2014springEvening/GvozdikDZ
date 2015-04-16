using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day6KP
{
    public partial class Form1 : Form
    {
        PicturePanel picturePanel1 = new PicturePanel();

        string[] files;

        FileInfo fileInfo;
        Image originalImage, image;
        Size imageSize;
        Color defaultBackColor;

        int imgNum = 0;
        int tbMiddle = 10;
        string adress;
        bool imageZoom = false;
        bool fullScreen = false;

        int pbHeight;
        int formLeft, formTop, formWidth, formHeight;

        public Form1()
        {
            InitializeComponent();

            this.Controls.Add(picturePanel1);

            picturePanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            picturePanel1.Location = new System.Drawing.Point(0, 0);
            picturePanel1.Name = "picturePanel";
            picturePanel1.Size = new System.Drawing.Size(869, 516);
            picturePanel1.TabIndex = 10;
            picturePanel1.DoubleClick += new System.EventHandler(picturePanel1_DoubleClick);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FindFiles();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            image = originalImage;
            image = new Bitmap(image, new Size(trackBar1.Value * picturePanel1.Height * imageSize.Width / imageSize.Height / 10, trackBar1.Value * picturePanel1.Height / 10));
            picturePanel1.BackgroundImage = image;
            picturePanel1.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(imgNum == 0)
            {
                imgNum = files.Count() - 1;
            }
            else
            {
                imgNum--;
            }

            ImageShow();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (imgNum < files.Count() - 1)
            {
                imgNum++;
            }
            else
            {
                imgNum = 0;
            }

            ImageShow();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fullScreen = true;
            FullScreen();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            image.RotateFlip(RotateFlipType.Rotate90FlipXY);
            picturePanel1.BackgroundImage = image;
            picturePanel1.Invalidate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            image.RotateFlip(RotateFlipType.Rotate270FlipXY);
            picturePanel1.BackgroundImage = image;
            picturePanel1.Invalidate();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Scale();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            defaultBackColor = picturePanel1.BackColor;
            trackBar1.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button8.Enabled = false;
        }

        private void picturePanel1_DoubleClick(object sender, EventArgs e)
        {
            fullScreen = false;
            FullScreen();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("Имя файла: {0}\nПуть к файлу: {1}\nРазмер файла: {2} байт\nФайл создан: {3}", fileInfo.Name, fileInfo.Directory, fileInfo.Length, fileInfo.CreationTime));
        }

        private void FindFiles()
        {
            try
            {
                adress = textBox1.Text;

                try
                {
                    files = Directory.GetFiles(textBox1.Text, "*.jpg", SearchOption.AllDirectories);

                    ImageShow();
                }
                catch (UnauthorizedAccessException)
                {

                }
                if (files != null)
                {
                    trackBar1.Enabled = true;
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    button5.Enabled = true;
                    button6.Enabled = true;
                    button8.Enabled = true;
                }
            }
            catch (Exception dirEx)
            {
                MessageBox.Show(dirEx.Message);
            }
        }
        private void Scale()
        {
            trackBar1.Value = tbMiddle;

            if (imageZoom == false)
            {
                trackBar1.Enabled = false;
                imageZoom = true;
                if (originalImage.Height > picturePanel1.Height)
                {
                    image = new Bitmap(image, new Size(imageSize.Width * picturePanel1.Height / imageSize.Height, picturePanel1.Height));
                }
                picturePanel1.BackgroundImage = image;
                picturePanel1.Invalidate();
            }
            else
            {
                trackBar1.Enabled = true;
                imageZoom = false;
                image = originalImage;
                picturePanel1.BackgroundImage = image;
                picturePanel1.Invalidate();
            }
        }

        private void FullScreen()
        {
            if (fullScreen == true)
            {
                formLeft = this.Left;
                formTop = this.Top;
                formWidth = this.Width;
                formHeight = this.Height;

                picturePanel1.BackColor = Color.Black;

                pbHeight = picturePanel1.Height;

                this.FormBorderStyle = FormBorderStyle.None;
                this.ControlBox = false;
                groupBox2.Hide();

                picturePanel1.Height = this.Height;

                this.WindowState = FormWindowState.Maximized;
                fullScreen = false;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.ControlBox = true;

                groupBox2.Show();

                this.Left = formLeft;
                this.Top = formTop;
                this.Width = formWidth;
                this.Height = formHeight;

                picturePanel1.BackColor = defaultBackColor;

                this.StartPosition = FormStartPosition.WindowsDefaultLocation;
                this.WindowState = FormWindowState.Normal;

                picturePanel1.Height = pbHeight;
            }
        }

        private void ImageShow()
        {
            fileInfo = new FileInfo(files[imgNum]);
            this.Text = fileInfo.Name;
            image = originalImage = Bitmap.FromFile(files[imgNum]);
            imageSize = image.Size;
            picturePanel1.BackgroundImage = image;
            picturePanel1.Invalidate();
            imageZoom = false;
            Scale();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                FindFiles();
            }
        }
    }

    internal class PicturePanel : Panel
    {
        public PicturePanel()
        {
            this.DoubleBuffered = true;
            this.AutoScroll = true;
            this.BackgroundImageLayout = ImageLayout.Center;
        }
        public override Image BackgroundImage
        {
            get { return base.BackgroundImage; }
            set
            {
                base.BackgroundImage = value;
                if (value != null) this.AutoScrollMinSize = value.Size;
            }
        }
    }
}
