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

namespace Day2_3
{
    public partial class Form1 : Form
    {
        string[] tbStr = new string[10];
        public Form1()
        {
            InitializeComponent();
        }

        private void cbOverhaul_CheckedChanged(object sender, EventArgs e)
        {
            Rent.Square = (uint)numSquare.Value;
            Rent.OverhaulCalc();
            numcbFunc(cbOverhaul.Checked, 0, "капремонт", Rent.OverhaulCost);
        }

        private void cbClean_CheckedChanged(object sender, EventArgs e)
        {
            Rent.Roomer = (uint)numRoomer.Value;
            Rent.CleaningCalc();
            numcbFunc(cbClean.Checked, 1, "уборку", Rent.CleaningCost);
        }

        private void cbLift_CheckedChanged(object sender, EventArgs e)
        {
            Rent.Floor = (uint)numFloor.Value;
            Rent.LiftCalc();
            numcbFunc(cbLift.Checked, 2, "лифт", Rent.LiftCost);
        }

        private void cbElec_CheckedChanged(object sender, EventArgs e)
        {
            Rent.Electricity = (uint)numElecricity.Value;
            Rent.ElectricityCalc();
            numcbFunc(cbElec.Checked, 3, "электричество при значении счетчика: ", Rent.Electricity, Rent.ElectricityCost);
        }

        private void cbHotW_CheckedChanged(object sender, EventArgs e)
        {
            Rent.HotWater = (uint)numHotW.Value;
            Rent.HotWaterCalc();
            numcbFunc(cbHotW.Checked, 4, "горячую воду при значении счетчика: ", Rent.HotWater, Rent.HotWaterCost);
        }

        private void cbColdW_CheckedChanged(object sender, EventArgs e)
        {
            Rent.ColdWater = (uint)numColdW.Value;
            Rent.ColdWaterCalc();
            numcbFunc(cbColdW.Checked, 5, "холодную воду при значении счетчика: ", Rent.ColdWater, Rent.ColdWaterCost);
        }

        private void cbGas_CheckedChanged(object sender, EventArgs e)
        {
            Rent.Gas = (uint)numGas.Value;
            Rent.GasCalc();
            numcbFunc(cbGas.Checked, 6, "газ при значении счетчика: ", Rent.Gas, Rent.GasCost);
        }

        private void cbHeating_CheckedChanged(object sender, EventArgs e)
        {
            Rent.Heating = (uint)numHeating.Value;
            Rent.HeatingCalc();
            numcbFunc(cbHeating.Checked, 7, "отопление при значении счетчика: ", Rent.Heating, Rent.HeatingCost);
        }

        private void numSquare_ValueChanged(object sender, EventArgs e)
        {
            Rent.Square = (uint)numSquare.Value;
            Rent.OverhaulCalc();
            numcbFunc(cbOverhaul.Checked, 0, "капремонт", Rent.OverhaulCost);
        }

        private void numRoomer_ValueChanged(object sender, EventArgs e)
        {
            Rent.Roomer = (uint)numRoomer.Value;
            Rent.CleaningCalc();
            numcbFunc(cbClean.Checked, 1, "уборку", Rent.CleaningCost);
        }

        private void numFloor_ValueChanged(object sender, EventArgs e)
        {
            Rent.Floor = (uint)numFloor.Value;
            Rent.LiftCalc();
            numcbFunc(cbLift.Checked, 2, "лифт", Rent.LiftCost);
        }

        private void numElecricity_ValueChanged(object sender, EventArgs e)
        {
            Rent.Electricity = (uint)numElecricity.Value;
            Rent.ElectricityCalc();
            numcbFunc(cbElec.Checked, 3, "электричество при значении счетчика: ", Rent.Electricity, Rent.ElectricityCost);
        }

        private void numHotW_ValueChanged(object sender, EventArgs e)
        {
            Rent.HotWater = (uint)numHotW.Value;
            Rent.HotWaterCalc();
            numcbFunc(cbHotW.Checked, 4, "горячую воду при значении счетчика: ", Rent.HotWater, Rent.HotWaterCost);
        }

        private void numColdW_ValueChanged(object sender, EventArgs e)
        {
            Rent.ColdWater = (uint)numColdW.Value;
            Rent.ColdWaterCalc();
            numcbFunc(cbColdW.Checked, 5, "холодную воду при значении счетчика: ", Rent.ColdWater, Rent.ColdWaterCost);
        }

        private void numGas_ValueChanged(object sender, EventArgs e)
        {
            Rent.Gas = (uint)numGas.Value;
            Rent.GasCalc();
            numcbFunc(cbGas.Checked, 6, "газ при значении счетчика: ", Rent.Gas, Rent.GasCost);
        }

        private void numHeating_ValueChanged(object sender, EventArgs e)
        {
            Rent.Heating = (uint)numHeating.Value;
            Rent.HeatingCalc();
            numcbFunc(cbHeating.Checked, 7, "отопление при значении счетчика: ", Rent.Heating, Rent.HeatingCost);
        }

        private void btCalc_Click(object sender, EventArgs e)
        {
            totalCost();
            int strCounter = 0;
            string[] outPutTbStr = new string[10];
            foreach(string s in tbStr)
            {
                if (s != null)
                {
                    outPutTbStr[strCounter] = s;
                    strCounter++;
                }
            }
            if (strCounter == 0)
            {
                outPutTbStr = new string[2] { "Введите значения и отметьте интересующие пункты.", "Нажмите кнопку \"Рассчитать\"" };
            }
            tbTotal.Lines = outPutTbStr;
        }

        void numcbFunc(bool cbChecked, int elementNumber, string str, uint valCount, double valCost)
        {
            if (cbChecked && valCost != 0)
            {
                tbStr[elementNumber] = String.Format("Плата за {0} {1} составит - {2} руб.", str, valCount, valCost);
            }
            else
            {
                tbStr[elementNumber] = null;
            }
        }

        void numcbFunc(bool cbChecked, int elementNumber, string str, double valCost)
        {
            if (cbChecked && valCost != 0)
            {
                tbStr[elementNumber] = String.Format("Плата за {0} составит - {1} руб.", str, valCost);
            }
            else
            {
                tbStr[elementNumber] = null;
            }
        }

        void totalCost()
        {
            double totalCost = 0;

            if (cbHeating.Checked)
            {
                totalCost += Rent.HeatingCost;
            }
            if (cbGas.Checked)
            {
                totalCost += Rent.GasCost;
            }
            if (cbColdW.Checked)
            {
                totalCost += Rent.ColdWaterCost;
            }
            if (cbHotW.Checked)
            {
                totalCost += Rent.HotWaterCost;
            }
            if (cbElec.Checked)
            {
                totalCost += Rent.ElectricityCost;
            }
            if (cbLift.Checked)
            {
                totalCost += Rent.LiftCost;
            }
            if (cbClean.Checked)
            {
                totalCost += Rent.CleaningCost;
            }
            if (cbOverhaul.Checked)
            {
                totalCost += Rent.OverhaulCost;
            }
            if (totalCost != 0)
            {
                tbStr[8] = null;
                for (uint i = 0; i < 133; i++)
                {
                    tbStr[8] += "-";
                }
                tbStr[9] = String.Format("Итого: {0} руб.", totalCost);
            }
            else
            {
                tbStr[8] = null;
                tbStr[9] = null;
            }
        }

        void Form1_Load(object sender, EventArgs e)
        {
            readXml(@"Tariff.xml");
            string[] outPutTbStr = new string[2]{"Введите значения и отметьте интересующие пункты.", "Нажмите кнопку \"Рассчитать\""};
            tbTotal.Lines = outPutTbStr;
        }
        void readXml(string pathToXml)
        {
            try
            {
                XPathDocument doc = new XPathDocument(pathToXml);
                XPathNavigator nav = doc.CreateNavigator();
                XPathNodeIterator iterator = nav.Select("/tariff");
                while (iterator.MoveNext())
                {
                    Rent.OverhaulPrice = readObligatoryAttribute(iterator, "overhaul");
                    Rent.CleaningPrice = readObligatoryAttribute(iterator, "cleaning");
                    Rent.LiftPrice = readObligatoryAttribute(iterator, "lift");
                    Rent.ElectricityPrice = readObligatoryAttribute(iterator, "electricity");
                    Rent.HotWaterPrice = readObligatoryAttribute(iterator, "hotwater");
                    Rent.ColdWaterPrice = readObligatoryAttribute(iterator, "coldwater");
                    Rent.GasPrice = readObligatoryAttribute(iterator, "gas");
                    Rent.HeatingPrice = readObligatoryAttribute(iterator, "heating");
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
    }
    public static class Rent
    {
        private static uint square, roomer, floor;

        public static uint Square
        {
            get { return Rent.square; }
            set { Rent.square = value; }
        }

        public static uint Roomer
        {
            get { return Rent.roomer; }
            set { Rent.roomer = value; }
        }

        public static uint Floor
        {
            get { return Rent.floor; }
            set { Rent.floor = value; }
        }

        private static uint electricity, hotWater, coldWater, gas, heating;

        public static uint Electricity
        {
            get { return Rent.electricity; }
            set { Rent.electricity = value; }
        }

        public static uint HotWater
        {
            get { return Rent.hotWater; }
            set { Rent.hotWater = value; }
        }

        public static uint ColdWater
        {
            get { return Rent.coldWater; }
            set { Rent.coldWater = value; }
        }

        public static uint Gas
        {
            get { return Rent.gas; }
            set { Rent.gas = value; }
        }

        public static uint Heating
        {
            get { return Rent.heating; }
            set { Rent.heating = value; }
        }

        private static double overhaulCost, cleaningCost, liftCost, electricityCost, hotWaterCost, coldWaterCost, gasCost, heatingCost;

        public static double OverhaulCost
        {
            get { return Rent.overhaulCost; }
            set { Rent.overhaulCost = value; }
        }

        public static double CleaningCost
        {
            get { return Rent.cleaningCost; }
            set { Rent.cleaningCost = value; }
        }

        public static double LiftCost
        {
            get { return Rent.liftCost; }
            set { Rent.liftCost = value; }
        }

        public static double ElectricityCost
        {
            get { return Rent.electricityCost; }
            set { Rent.electricityCost = value; }
        }

        public static double HotWaterCost
        {
            get { return Rent.hotWaterCost; }
            set { Rent.hotWaterCost = value; }
        }

        public static double ColdWaterCost
        {
            get { return Rent.coldWaterCost; }
            set { Rent.coldWaterCost = value; }
        }

        public static double GasCost
        {
            get { return Rent.gasCost; }
            set { Rent.gasCost = value; }
        }

        public static double HeatingCost
        {
            get { return Rent.heatingCost; }
            set { Rent.heatingCost = value; }
        }

        private static double overhaulPrice, cleaningPrice, liftPrice, electricityPrice, hotWaterPrice, coldWaterPrice, gasPrice, heatingPrice;

        public static double OverhaulPrice
        {
            get { return Rent.overhaulPrice; }
            set { Rent.overhaulPrice = value; }
        }

        public static double CleaningPrice
        {
            get { return Rent.cleaningPrice; }
            set { Rent.cleaningPrice = value; }
        }

        public static double LiftPrice
        {
            get { return Rent.liftPrice; }
            set { Rent.liftPrice = value; }
        }

        public static double ElectricityPrice
        {
            get { return Rent.electricityPrice; }
            set { Rent.electricityPrice = value; }
        }

        public static double HotWaterPrice
        {
            get { return Rent.hotWaterPrice; }
            set { Rent.hotWaterPrice = value; }
        }

        public static double ColdWaterPrice
        {
            get { return Rent.coldWaterPrice; }
            set { Rent.coldWaterPrice = value; }
        }

        public static double GasPrice
        {
            get { return Rent.gasPrice; }
            set { Rent.gasPrice = value; }
        }

        public static double HeatingPrice
        {
            get { return Rent.heatingPrice; }
            set { Rent.heatingPrice = value; }
        }

        public static void OverhaulCalc()
        {
            overhaulCost = (double)(overhaulPrice * square);
        }
        public static void CleaningCalc()
        {
            cleaningCost = (double)(cleaningPrice * roomer);
        }
        public static void LiftCalc()
        {
            liftCost = (double)(liftPrice * floor);
        }
        public static void ElectricityCalc()
        {
            electricityCost = (double)(electricityPrice * electricity);
        }
        public static void HotWaterCalc()
        {
            hotWaterCost = (double)(hotWaterPrice * hotWater);
        }
        public static void ColdWaterCalc()
        {
            coldWaterCost = (double)(coldWaterPrice * coldWater);
        }
        public static void GasCalc()
        {
            gasCost = (double)(gasPrice * gas);
        }
        public static void HeatingCalc()
        {
            heatingCost = (double)(heatingPrice * heating);
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
