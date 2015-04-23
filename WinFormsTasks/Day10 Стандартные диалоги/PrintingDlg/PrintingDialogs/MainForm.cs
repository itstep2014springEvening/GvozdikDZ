using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    public partial class MainForm : Form
    {
        int currePage;

        public MainForm()
        {
            InitializeComponent();
        }

      
        private void настройкаПринтераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.PrinterSettings = printDialog1.PrinterSettings;
                printDocument1.Print();
            }
        }

        private void настройкиСтраницыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pageSetupDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.DefaultPageSettings = pageSetupDialog1.PageSettings;
                printPreviewControl1.Document = printDocument1;
            }
        }


        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
            printDocument1.PrinterSettings.ToPage = 1;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           
            Graphics g = e.Graphics;

            Image image = Image.FromFile("Pic.gif");

            float X=printDocument1.DefaultPageSettings.Margins.Left;
            float Y = printDocument1.DefaultPageSettings.Margins.Top;

            g.DrawString(textBox1.Text, new Font("Arial", 14), new SolidBrush(Color.Black), new PointF(X,Y));

            g.DrawImage(image, X+50, Y+50);

            if (printDocument1.PrinterSettings.ToPage < printDocument1.PrinterSettings.Copies)
                e.HasMorePages = true;
            else e.HasMorePages = false ;

            printDocument1.PrinterSettings.ToPage++;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            printPreviewControl1.Document = printDocument1;
        }
    }
}
