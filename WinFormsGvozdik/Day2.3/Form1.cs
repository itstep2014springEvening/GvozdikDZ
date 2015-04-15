using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;
using Word = Microsoft.Office.Interop.Word;

namespace Day2_3
{
    public partial class Form1 : Form
    {
        Dictionary<string, uint> prices = new Dictionary<string, uint>();

        public Form1()
        {
            InitializeComponent();
        }

        void Form1_Load(object sender, EventArgs e)
        {
            readXml(@"Tariff.xml");
            btCalc.Enabled = false;
        }

        private void numSquare_ValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void btCalc_Click(object sender, EventArgs e)
        {
            wordapp = new Word.Application();
            wordapp.Visible = true;
            Word.Paragraph wordparagraph;
            Word.Document doc = new Word.Document();
            object MyTemplate = Type.Missing;
            object NewTemplate = false;
            object DocumentType = Word.WdNewDocumentType.wdNewBlankDocument;

            object Visible = true;
            doc = wordapp.Documents.Add( ref MyTemplate,
                                         ref NewTemplate,
                                         ref DocumentType,
                                         ref Visible );
            object pargf = Type.Missing;
            wordparagraph = doc.Content.Paragraphs.Add(ref pargf);
            wordparagraph.Range.Font.Bold = 1;
            wordparagraph.Range.Font.Size = 14;
            wordparagraph.Range.Text = "Квитанция на оплату коммунальных услуг";
            wordparagraph.Range.InsertParagraphAfter();

            for (int i = 0; i < 10; i++)
            {
                wordparagraph.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                wordparagraph.Range.InsertParagraphAfter();
                wordparagraph.Range.Font.Size = 10;
                wordparagraph.Range.Text = tbTotal.Lines.ElementAt(i);
            }
        }

        private Word.Application wordapp;

        void readXml(string pathToXml)
        {
            try
            {
                XPathDocument doc = new XPathDocument(pathToXml);
                XPathNavigator nav = doc.CreateNavigator();
                XPathNodeIterator iterator = nav.Select("/tariff");
                while (iterator.MoveNext())
                {
                    prices.Add("overhaul", readObligatoryAttribute(iterator, "overhaul"));
                    prices.Add("cleaning", readObligatoryAttribute(iterator, "cleaning"));
                    prices.Add("lift", readObligatoryAttribute(iterator, "lift"));
                    prices.Add("electricity", readObligatoryAttribute(iterator, "electricity"));
                    prices.Add("hotwater", readObligatoryAttribute(iterator, "hotwater"));
                    prices.Add("coldwater", readObligatoryAttribute(iterator, "coldwater"));
                    prices.Add("gas", readObligatoryAttribute(iterator, "gas"));
                    prices.Add("heating", readObligatoryAttribute(iterator, "heating"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }
        uint readObligatoryAttribute(XPathNodeIterator iterator, string name)
        {
            XPathNodeIterator it = iterator.Current.Select("@" + name);
            if (it.MoveNext())
            {
                return UInt32.Parse(it.Current.Value);
            }
            else
            {
                throw new InvalidTariff(String.Format("Obligatory attribute not found in {0}", iterator.Current.Name));
            }
        }

        private void Calculate()
        {
            List<CheckBox> cbAll = new List<CheckBox>() { cbOverhaul, cbClean, cbLift, cbElec, cbHotW, cbColdW, cbGas, cbHeating };
            string[] message = new string[10];
            uint result = 0;
            for (int i = 0; i < cbAll.Count; i++)
            {
                if (cbAll[i].Checked)
                {
                    switch (i)
                    {
                        case 0:
                            foreach (KeyValuePair<string, uint> kvp in prices)
                            {
                                if (kvp.Key == "overhaul")
                                {
                                    result += Convert.ToUInt32(numSquare.Value) * kvp.Value;
                                    message[i] = (String.Format("Отчисления на капремонт при площади квартиры {0} кв.м., составят - {1} руб.", numSquare.Value, Convert.ToString(Convert.ToUInt32(numSquare.Value) * kvp.Value)));
                                }
                            }
                            break;
                        case 1:
                            foreach (KeyValuePair<string, uint> kvp in prices)
                            {
                                if (kvp.Key == "cleaning")
                                {
                                    result += Convert.ToUInt32(numRoomer.Value) * kvp.Value;
                                    message[i] = (String.Format("Плата за уборку при количестве жителей в квартире: {0}, составит - {1} руб.", numRoomer.Value, Convert.ToString(Convert.ToUInt32(numRoomer.Value) * kvp.Value)));
                                }
                            }
                            break;
                        case 2:
                            foreach (KeyValuePair<string, uint> kvp in prices)
                            {
                                if (kvp.Key == "lift")
                                {
                                    result += Convert.ToUInt32(numFloor.Value) * kvp.Value;
                                    message[i] = (String.Format("Плата за лифт при нахождении квартирв на {0} этаже, составит - {1} руб.", numFloor.Value, Convert.ToString(Convert.ToUInt32(numFloor.Value) * kvp.Value)));
                                }
                            }
                            break;
                        case 3:
                            foreach (KeyValuePair<string, uint> kvp in prices)
                            {
                                if (kvp.Key == "electricity")
                                {
                                    result += Convert.ToUInt32(numElectricity.Value) * kvp.Value;
                                    message[i] = (String.Format("Плата за электричество при значении счетчика: {0}, составит - {1} руб.", numElectricity.Value, Convert.ToString(Convert.ToUInt32(numElectricity.Value) * kvp.Value)));
                                }
                            }
                            break;
                        case 4:
                            foreach (KeyValuePair<string, uint> kvp in prices)
                            {
                                if (kvp.Key == "hotwater")
                                {
                                    result += Convert.ToUInt32(numHotW.Value) * kvp.Value;
                                    message[i] = (String.Format("Плата за горячую воду при значении счетчика: {0}, составит - {1} руб.", numHotW.Value, Convert.ToString(Convert.ToUInt32(numHotW.Value) * kvp.Value)));
                                }
                            }
                            break;
                        case 5:
                            foreach (KeyValuePair<string, uint> kvp in prices)
                            {
                                if (kvp.Key == "coldwater")
                                {
                                    result += Convert.ToUInt32(numColdW.Value) * kvp.Value;
                                    message[i] = (String.Format("Плата за холодную воду при значении счетчика: {0}, составит - {1} руб.", numColdW.Value, Convert.ToString(Convert.ToUInt32(numColdW.Value) * kvp.Value)));
                                }
                            }
                            break;
                        case 6:
                            foreach (KeyValuePair<string, uint> kvp in prices)
                            {
                                if (kvp.Key == "gas")
                                {
                                    result += Convert.ToUInt32(numGas.Value) * kvp.Value;
                                    message[i] = (String.Format("Плата за газ при значении счетчика: {0}, составит - {1} руб.", numGas.Value, Convert.ToString(Convert.ToUInt32(numGas.Value) * kvp.Value)));
                                }
                            }
                            break;
                        case 7:
                            foreach (KeyValuePair<string, uint> kvp in prices)
                            {
                                if (kvp.Key == "heating")
                                {
                                    result += Convert.ToUInt32(numHeating.Value) * kvp.Value;
                                    message[i] = (String.Format("Плата за отопление при значении счетчика: {0}, составит - {1} руб.", numHeating.Value, Convert.ToString(Convert.ToUInt32(numHeating.Value) * kvp.Value)));
                                }
                            }
                            break;
                    }
                    message[8] = null;
                    for (int j = 0; j < 133; j++)
                    {
                        message[8] += "-";
                    }
                    message[9] = (String.Format("ИТОГО: {0} руб.", Convert.ToString(result)));
                }
            }

            string[] tbStr = new string[10];
            int strCounter = 0;

            foreach (string str in message)
            {
                if (str != null)
                {
                    tbStr[strCounter] = str;
                    strCounter++;
                }
            }

            if (strCounter == 0)
            {
                btCalc.Enabled = false;
            }
            else
            {
                btCalc.Enabled = true;
            }

            tbTotal.Lines = tbStr;

        }
    }
    class InvalidTariff : ApplicationException
    {
        public InvalidTariff()
        {

        }
        public InvalidTariff(string msg)
            : base(msg)
        {

        }
    }
}
