namespace Day2_3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbMain = new System.Windows.Forms.Label();
            this.gbFlatParam = new System.Windows.Forms.GroupBox();
            this.numFloor = new System.Windows.Forms.NumericUpDown();
            this.numRoomer = new System.Windows.Forms.NumericUpDown();
            this.numSquare = new System.Windows.Forms.NumericUpDown();
            this.lbFloor = new System.Windows.Forms.Label();
            this.lbRoomer = new System.Windows.Forms.Label();
            this.lbSquare = new System.Windows.Forms.Label();
            this.gbServices = new System.Windows.Forms.GroupBox();
            this.numGas = new System.Windows.Forms.NumericUpDown();
            this.numColdW = new System.Windows.Forms.NumericUpDown();
            this.numHotW = new System.Windows.Forms.NumericUpDown();
            this.numElectricity = new System.Windows.Forms.NumericUpDown();
            this.numHeating = new System.Windows.Forms.NumericUpDown();
            this.cbHeating = new System.Windows.Forms.CheckBox();
            this.cbGas = new System.Windows.Forms.CheckBox();
            this.cbColdW = new System.Windows.Forms.CheckBox();
            this.cbHotW = new System.Windows.Forms.CheckBox();
            this.cbElec = new System.Windows.Forms.CheckBox();
            this.cbLift = new System.Windows.Forms.CheckBox();
            this.cbClean = new System.Windows.Forms.CheckBox();
            this.cbOverhaul = new System.Windows.Forms.CheckBox();
            this.lbCounters = new System.Windows.Forms.Label();
            this.gbTotal = new System.Windows.Forms.GroupBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.btCalc = new System.Windows.Forms.Button();
            this.gbFlatParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFloor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRoomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSquare)).BeginInit();
            this.gbServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numColdW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHotW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numElectricity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeating)).BeginInit();
            this.gbTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMain
            // 
            this.lbMain.AutoSize = true;
            this.lbMain.Location = new System.Drawing.Point(152, 9);
            this.lbMain.Name = "lbMain";
            this.lbMain.Size = new System.Drawing.Size(284, 13);
            this.lbMain.TabIndex = 0;
            this.lbMain.Text = "Добро пожаловать в программу рассчета квартплаты";
            // 
            // gbFlatParam
            // 
            this.gbFlatParam.Controls.Add(this.numFloor);
            this.gbFlatParam.Controls.Add(this.numRoomer);
            this.gbFlatParam.Controls.Add(this.numSquare);
            this.gbFlatParam.Controls.Add(this.lbFloor);
            this.gbFlatParam.Controls.Add(this.lbRoomer);
            this.gbFlatParam.Controls.Add(this.lbSquare);
            this.gbFlatParam.Location = new System.Drawing.Point(12, 25);
            this.gbFlatParam.Name = "gbFlatParam";
            this.gbFlatParam.Size = new System.Drawing.Size(200, 102);
            this.gbFlatParam.TabIndex = 1;
            this.gbFlatParam.TabStop = false;
            this.gbFlatParam.Text = "Параметры квартиры";
            // 
            // numFloor
            // 
            this.numFloor.Location = new System.Drawing.Point(74, 71);
            this.numFloor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFloor.Name = "numFloor";
            this.numFloor.Size = new System.Drawing.Size(120, 20);
            this.numFloor.TabIndex = 2;
            this.numFloor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFloor.ValueChanged += new System.EventHandler(this.numSquare_ValueChanged);
            // 
            // numRoomer
            // 
            this.numRoomer.Location = new System.Drawing.Point(74, 45);
            this.numRoomer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRoomer.Name = "numRoomer";
            this.numRoomer.Size = new System.Drawing.Size(120, 20);
            this.numRoomer.TabIndex = 1;
            this.numRoomer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRoomer.ValueChanged += new System.EventHandler(this.numSquare_ValueChanged);
            // 
            // numSquare
            // 
            this.numSquare.Location = new System.Drawing.Point(74, 19);
            this.numSquare.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSquare.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSquare.Name = "numSquare";
            this.numSquare.Size = new System.Drawing.Size(120, 20);
            this.numSquare.TabIndex = 0;
            this.numSquare.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSquare.ValueChanged += new System.EventHandler(this.numSquare_ValueChanged);
            // 
            // lbFloor
            // 
            this.lbFloor.AutoSize = true;
            this.lbFloor.Location = new System.Drawing.Point(6, 73);
            this.lbFloor.Name = "lbFloor";
            this.lbFloor.Size = new System.Drawing.Size(33, 13);
            this.lbFloor.TabIndex = 2;
            this.lbFloor.Text = "Этаж";
            // 
            // lbRoomer
            // 
            this.lbRoomer.AutoSize = true;
            this.lbRoomer.Location = new System.Drawing.Point(6, 47);
            this.lbRoomer.Name = "lbRoomer";
            this.lbRoomer.Size = new System.Drawing.Size(44, 13);
            this.lbRoomer.TabIndex = 1;
            this.lbRoomer.Text = "Жилцы";
            // 
            // lbSquare
            // 
            this.lbSquare.AutoSize = true;
            this.lbSquare.Location = new System.Drawing.Point(6, 21);
            this.lbSquare.Name = "lbSquare";
            this.lbSquare.Size = new System.Drawing.Size(54, 13);
            this.lbSquare.TabIndex = 0;
            this.lbSquare.Text = "Площадь";
            // 
            // gbServices
            // 
            this.gbServices.Controls.Add(this.numGas);
            this.gbServices.Controls.Add(this.numColdW);
            this.gbServices.Controls.Add(this.numHotW);
            this.gbServices.Controls.Add(this.numElectricity);
            this.gbServices.Controls.Add(this.numHeating);
            this.gbServices.Controls.Add(this.cbHeating);
            this.gbServices.Controls.Add(this.cbGas);
            this.gbServices.Controls.Add(this.cbColdW);
            this.gbServices.Controls.Add(this.cbHotW);
            this.gbServices.Controls.Add(this.cbElec);
            this.gbServices.Controls.Add(this.cbLift);
            this.gbServices.Controls.Add(this.cbClean);
            this.gbServices.Controls.Add(this.cbOverhaul);
            this.gbServices.Controls.Add(this.lbCounters);
            this.gbServices.Location = new System.Drawing.Point(12, 133);
            this.gbServices.Name = "gbServices";
            this.gbServices.Size = new System.Drawing.Size(200, 239);
            this.gbServices.TabIndex = 2;
            this.gbServices.TabStop = false;
            this.gbServices.Text = "Услуги";
            // 
            // numGas
            // 
            this.numGas.Location = new System.Drawing.Point(114, 165);
            this.numGas.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numGas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numGas.Name = "numGas";
            this.numGas.Size = new System.Drawing.Size(80, 20);
            this.numGas.TabIndex = 6;
            this.numGas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numGas.ValueChanged += new System.EventHandler(this.numSquare_ValueChanged);
            // 
            // numColdW
            // 
            this.numColdW.Location = new System.Drawing.Point(114, 139);
            this.numColdW.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numColdW.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numColdW.Name = "numColdW";
            this.numColdW.Size = new System.Drawing.Size(80, 20);
            this.numColdW.TabIndex = 5;
            this.numColdW.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numColdW.ValueChanged += new System.EventHandler(this.numSquare_ValueChanged);
            // 
            // numHotW
            // 
            this.numHotW.Location = new System.Drawing.Point(114, 113);
            this.numHotW.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numHotW.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHotW.Name = "numHotW";
            this.numHotW.Size = new System.Drawing.Size(80, 20);
            this.numHotW.TabIndex = 4;
            this.numHotW.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHotW.ValueChanged += new System.EventHandler(this.numSquare_ValueChanged);
            // 
            // numElectricity
            // 
            this.numElectricity.Location = new System.Drawing.Point(114, 87);
            this.numElectricity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numElectricity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numElectricity.Name = "numElectricity";
            this.numElectricity.Size = new System.Drawing.Size(80, 20);
            this.numElectricity.TabIndex = 3;
            this.numElectricity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numElectricity.ValueChanged += new System.EventHandler(this.numSquare_ValueChanged);
            // 
            // numHeating
            // 
            this.numHeating.Location = new System.Drawing.Point(114, 191);
            this.numHeating.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numHeating.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHeating.Name = "numHeating";
            this.numHeating.Size = new System.Drawing.Size(80, 20);
            this.numHeating.TabIndex = 7;
            this.numHeating.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHeating.ValueChanged += new System.EventHandler(this.numSquare_ValueChanged);
            // 
            // cbHeating
            // 
            this.cbHeating.AutoSize = true;
            this.cbHeating.Location = new System.Drawing.Point(6, 192);
            this.cbHeating.Name = "cbHeating";
            this.cbHeating.Size = new System.Drawing.Size(81, 17);
            this.cbHeating.TabIndex = 11;
            this.cbHeating.Text = "Отопление";
            this.cbHeating.UseVisualStyleBackColor = true;
            this.cbHeating.CheckedChanged += new System.EventHandler(this.numSquare_ValueChanged);
            // 
            // cbGas
            // 
            this.cbGas.AutoSize = true;
            this.cbGas.Location = new System.Drawing.Point(6, 166);
            this.cbGas.Name = "cbGas";
            this.cbGas.Size = new System.Drawing.Size(44, 17);
            this.cbGas.TabIndex = 10;
            this.cbGas.Text = "Газ";
            this.cbGas.UseVisualStyleBackColor = true;
            this.cbGas.CheckedChanged += new System.EventHandler(this.numSquare_ValueChanged);
            // 
            // cbColdW
            // 
            this.cbColdW.AutoSize = true;
            this.cbColdW.Location = new System.Drawing.Point(6, 140);
            this.cbColdW.Name = "cbColdW";
            this.cbColdW.Size = new System.Drawing.Size(102, 17);
            this.cbColdW.TabIndex = 9;
            this.cbColdW.Text = "Холодная вода";
            this.cbColdW.UseVisualStyleBackColor = true;
            this.cbColdW.CheckedChanged += new System.EventHandler(this.numSquare_ValueChanged);
            // 
            // cbHotW
            // 
            this.cbHotW.AutoSize = true;
            this.cbHotW.Location = new System.Drawing.Point(6, 114);
            this.cbHotW.Name = "cbHotW";
            this.cbHotW.Size = new System.Drawing.Size(94, 17);
            this.cbHotW.TabIndex = 8;
            this.cbHotW.Text = "Горячая вода";
            this.cbHotW.UseVisualStyleBackColor = true;
            this.cbHotW.CheckedChanged += new System.EventHandler(this.numSquare_ValueChanged);
            // 
            // cbElec
            // 
            this.cbElec.AutoSize = true;
            this.cbElec.Location = new System.Drawing.Point(6, 88);
            this.cbElec.Name = "cbElec";
            this.cbElec.Size = new System.Drawing.Size(102, 17);
            this.cbElec.TabIndex = 7;
            this.cbElec.Text = "Электричество";
            this.cbElec.UseVisualStyleBackColor = true;
            this.cbElec.CheckedChanged += new System.EventHandler(this.numSquare_ValueChanged);
            // 
            // cbLift
            // 
            this.cbLift.AutoSize = true;
            this.cbLift.Location = new System.Drawing.Point(6, 65);
            this.cbLift.Name = "cbLift";
            this.cbLift.Size = new System.Drawing.Size(53, 17);
            this.cbLift.TabIndex = 6;
            this.cbLift.Text = "Лифт";
            this.cbLift.UseVisualStyleBackColor = true;
            this.cbLift.CheckedChanged += new System.EventHandler(this.numSquare_ValueChanged);
            // 
            // cbClean
            // 
            this.cbClean.AutoSize = true;
            this.cbClean.Location = new System.Drawing.Point(6, 42);
            this.cbClean.Name = "cbClean";
            this.cbClean.Size = new System.Drawing.Size(116, 17);
            this.cbClean.TabIndex = 5;
            this.cbClean.Text = "Уборка подъезда";
            this.cbClean.UseVisualStyleBackColor = true;
            this.cbClean.CheckedChanged += new System.EventHandler(this.numSquare_ValueChanged);
            // 
            // cbOverhaul
            // 
            this.cbOverhaul.AutoSize = true;
            this.cbOverhaul.Location = new System.Drawing.Point(6, 19);
            this.cbOverhaul.Name = "cbOverhaul";
            this.cbOverhaul.Size = new System.Drawing.Size(134, 17);
            this.cbOverhaul.TabIndex = 4;
            this.cbOverhaul.Text = "Капитальный ремонт";
            this.cbOverhaul.UseVisualStyleBackColor = true;
            this.cbOverhaul.CheckedChanged += new System.EventHandler(this.numSquare_ValueChanged);
            // 
            // lbCounters
            // 
            this.lbCounters.AutoSize = true;
            this.lbCounters.Location = new System.Drawing.Point(114, 69);
            this.lbCounters.Name = "lbCounters";
            this.lbCounters.Size = new System.Drawing.Size(56, 13);
            this.lbCounters.TabIndex = 3;
            this.lbCounters.Text = "Счетчики:";
            // 
            // gbTotal
            // 
            this.gbTotal.Controls.Add(this.tbTotal);
            this.gbTotal.Controls.Add(this.btCalc);
            this.gbTotal.Location = new System.Drawing.Point(218, 25);
            this.gbTotal.Name = "gbTotal";
            this.gbTotal.Size = new System.Drawing.Size(419, 347);
            this.gbTotal.TabIndex = 3;
            this.gbTotal.TabStop = false;
            this.gbTotal.Text = "Итоги";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(6, 18);
            this.tbTotal.Multiline = true;
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(407, 294);
            this.tbTotal.TabIndex = 1;
            // 
            // btCalc
            // 
            this.btCalc.Location = new System.Drawing.Point(338, 318);
            this.btCalc.Name = "btCalc";
            this.btCalc.Size = new System.Drawing.Size(75, 23);
            this.btCalc.TabIndex = 0;
            this.btCalc.Text = "Рассчитать";
            this.btCalc.UseVisualStyleBackColor = true;
            this.btCalc.Click += new System.EventHandler(this.btCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 378);
            this.Controls.Add(this.gbTotal);
            this.Controls.Add(this.gbServices);
            this.Controls.Add(this.gbFlatParam);
            this.Controls.Add(this.lbMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Расчет квартплаты";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbFlatParam.ResumeLayout(false);
            this.gbFlatParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFloor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRoomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSquare)).EndInit();
            this.gbServices.ResumeLayout(false);
            this.gbServices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numColdW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHotW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numElectricity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeating)).EndInit();
            this.gbTotal.ResumeLayout(false);
            this.gbTotal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMain;
        private System.Windows.Forms.GroupBox gbFlatParam;
        private System.Windows.Forms.GroupBox gbServices;
        private System.Windows.Forms.GroupBox gbTotal;
        private System.Windows.Forms.Button btCalc;
        private System.Windows.Forms.NumericUpDown numFloor;
        private System.Windows.Forms.NumericUpDown numRoomer;
        private System.Windows.Forms.NumericUpDown numSquare;
        private System.Windows.Forms.Label lbFloor;
        private System.Windows.Forms.Label lbRoomer;
        private System.Windows.Forms.Label lbSquare;
        private System.Windows.Forms.NumericUpDown numGas;
        private System.Windows.Forms.NumericUpDown numColdW;
        private System.Windows.Forms.NumericUpDown numHotW;
        private System.Windows.Forms.NumericUpDown numElectricity;
        private System.Windows.Forms.NumericUpDown numHeating;
        private System.Windows.Forms.CheckBox cbHeating;
        private System.Windows.Forms.CheckBox cbGas;
        private System.Windows.Forms.CheckBox cbColdW;
        private System.Windows.Forms.CheckBox cbHotW;
        private System.Windows.Forms.CheckBox cbElec;
        private System.Windows.Forms.CheckBox cbLift;
        private System.Windows.Forms.CheckBox cbClean;
        private System.Windows.Forms.CheckBox cbOverhaul;
        private System.Windows.Forms.Label lbCounters;
        private System.Windows.Forms.TextBox tbTotal;
    }
}

