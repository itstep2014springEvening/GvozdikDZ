using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// для работы с библиотекой OpenGL 
using Tao.OpenGl;
// для работы с библиотекой FreeGLUT 
using Tao.FreeGlut;
// для работы с элементом управления SimpleOpenGLControl 
using Tao.Platform.Windows; 

namespace Rectangle
{
    public class Nangle
    {
        public float r;
        public uint n;
        public float alpha;
        public int centerX;
        public int centerY;
        public Nangle(float _r, uint _n, float _alpha, int _centerX, int _centerY)
        {
            r =_r;
            n =_n;
            alpha = _alpha;
            centerX = _centerX;
            centerY = _centerY;
        }

        public void Draw()
        {
            Gl.glPushMatrix();

            Gl.glTranslated(centerX, centerY, 0);
            //Gl.glRotated(alpha, 0, 0, 1);


            Gl.glBegin(Gl.GL_LINE_LOOP);

            // первая вершина будет находиться в начале координат 
            for (int i = 0; i < n; ++i)
            {
                float x, y, newAlpha;
                newAlpha = (float)(alpha * Math.PI / 180);
                x = (float)(r * Math.Cos(alpha + (2 * Math.PI * i) / n));
                y = (float)(r * Math.Sin(alpha + (2 * Math.PI * i) / n));
                Gl.glVertex3d(x, y, 0);
                Gl.glColor3d(0, 255, 0);
            }

            // завершаем режим рисования 
            Gl.glEnd();

            Gl.glPopMatrix();
        }
    }
    public class Gear
    {
        public float rIn;
        public float rOut;
        public uint n;
        public float alpha;
        public float clawSize;
        public float centerX;
        public float centerY;
        public Gear(float _rIn, float _rOut, uint _n, float _alpha, float _clawSize, float _centerX, float _centerY)
        {
            rIn = _rIn;
            rOut = _rOut;
            n = _n;
            alpha = _alpha;
            clawSize = _clawSize;;
            centerX = _centerX;
            centerY = _centerY;
        }

        public void Draw()
        {
            Gl.glPushMatrix();

            Gl.glTranslated(0, 0, -10);


            Gl.glBegin(Gl.GL_LINE_LOOP);

            // первая вершина будет находиться в начале координат 
            for (int i = 0; i < n; ++i)
            {
                float x, y, newAlpha;
                newAlpha = (float)(alpha * Math.PI / 180);
                x = (float)(rIn * Math.Cos(newAlpha + (2 * Math.PI * i) / n));
                y = (float)(rIn * Math.Sin(newAlpha + (2 * Math.PI * i) / n));
                Gl.glVertex3d(x, y, 0);
                x = (float)(rOut * Math.Cos(newAlpha + (2 * Math.PI * i) / n));
                y = (float)(rOut * Math.Sin(newAlpha + (2 * Math.PI * i) / n));
                Gl.glVertex3d(x, y, 4);
                x = (float)(rOut * Math.Cos(clawSize + newAlpha + (2 * Math.PI * i) / n));
                y = (float)(rOut * Math.Sin(clawSize + newAlpha + (2 * Math.PI * i) / n));
                Gl.glVertex3d(x, y, 4);
                x = (float)(rIn * Math.Cos(clawSize + newAlpha + (2 * Math.PI * i) / n));
                y = (float)(rIn * Math.Sin(clawSize + newAlpha + (2 * Math.PI * i) / n));
                Gl.glVertex3d(x, y, 0);
            }

            // завершаем режим рисования 
            Gl.glEnd();

            Gl.glPopMatrix();
        }
    }
    public partial class Form1 : Form
    {
        Gear gear = new Gear(10, 11, 10, 0, (float)(Math.PI/10), 15, 15);
        public Form1()
        {
            InitializeComponent();
            AnT.InitializeContexts();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // инициализация Glut 
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_SINGLE);

            // очистка окна 
            Gl.glClearColor(255, 255, 255, 1);

            // установка порта вывода в соответствии с размерами элемента anT 
            Gl.glViewport(0, 0, AnT.Width, AnT.Height);

            // настройка проекции 
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();

            // теперь необходимо корректно настроить 2D ортогональную проекцию 
            // в зависимости от того, какая сторона больше 
            // мы немного варьируем то, как будет сконфигурированный настройки проекции 
            Glu.gluPerspective(120, 2, 0.1, 50);
            /*if ((float)AnT.Width <= (float)AnT.Height)
            {
                Glu.gluOrtho2D(0.0, 30.0 * (float)AnT.Height / (float)AnT.Width, 0.0, 30.0);
            }
            else
            {
                Glu.gluOrtho2D(0.0, 30.0 * (float)AnT.Width / (float)AnT.Height, 0.0, 30.0);
            }
            */
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
            //Glu.gluLookAt(0, 0, 0, 0, 0, 30, 0, 0, 1);
            UpdateTimer.Start();
        }
        private void UpdateTimer_Tick(object sender, System.EventArgs e)
        {
            // если мы дошли до последнего элемента массива 
            if (gear.alpha >= 360)
                gear.alpha = 0; // переходим к начальному элементу 

            // функция визуализации 
            Draw();

            // переход к следующему элементу массива 
            gear.alpha += 0.1f;
        }

        private void AnT_Load(object sender, System.EventArgs e)
        {

        }

        void Draw()
        {
            // очищаем буфер цвета 
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);

            // очищаем текущую матрицу 
            Gl.glLoadIdentity();
            // устанавливаем текущий цвет - красный 
            Gl.glColor3f(255, 0, 0);
            gear.Draw();

            // дожидаемся конца визуализации кадра 
            Gl.glFlush();

            // посылаем сигнал перерисовки элемента AnT. 
            AnT.Invalidate();
        }
    }
}
