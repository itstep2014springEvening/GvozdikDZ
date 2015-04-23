namespace WindowsFormsApplication11
{
    partial class MainForm
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
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.фаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкаПринтераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиСтраницыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.печатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // printDialog1
            // 
            this.printDialog1.AllowCurrentPage = true;
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.ShowHelp = true;
            this.printDialog1.ShowNetwork = false;
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.AutoZoom = false;
            this.printPreviewControl1.Document = this.printDocument1;
            this.printPreviewControl1.Location = new System.Drawing.Point(28, 48);
            this.printPreviewControl1.Name = "printPreviewControl1";
            this.printPreviewControl1.Size = new System.Drawing.Size(483, 457);
            this.printPreviewControl1.TabIndex = 0;
            this.printPreviewControl1.Zoom = 0.39007698887938408D;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.фаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(844, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // фаToolStripMenuItem
            // 
            this.фаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкаПринтераToolStripMenuItem,
            this.настройкиСтраницыToolStripMenuItem,
            this.печатьToolStripMenuItem});
            this.фаToolStripMenuItem.Name = "фаToolStripMenuItem";
            this.фаToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.фаToolStripMenuItem.Text = "Файл";
            // 
            // настройкаПринтераToolStripMenuItem
            // 
            this.настройкаПринтераToolStripMenuItem.Name = "настройкаПринтераToolStripMenuItem";
            this.настройкаПринтераToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.настройкаПринтераToolStripMenuItem.Text = "Настройка принтера";
            this.настройкаПринтераToolStripMenuItem.Click += new System.EventHandler(this.настройкаПринтераToolStripMenuItem_Click);
            // 
            // настройкиСтраницыToolStripMenuItem
            // 
            this.настройкиСтраницыToolStripMenuItem.Name = "настройкиСтраницыToolStripMenuItem";
            this.настройкиСтраницыToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.настройкиСтраницыToolStripMenuItem.Text = "Настройки страницы";
            this.настройкиСтраницыToolStripMenuItem.Click += new System.EventHandler(this.настройкиСтраницыToolStripMenuItem_Click);
            // 
            // печатьToolStripMenuItem
            // 
            this.печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            this.печатьToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.печатьToolStripMenuItem.Text = "Печать";
            this.печатьToolStripMenuItem.Click += new System.EventHandler(this.печатьToolStripMenuItem_Click);
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.printDocument1;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(539, 48);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(280, 200);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Язык программирования C#";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 545);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.printPreviewControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Печать Документа (Диалоги)";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewControl printPreviewControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem фаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкаПринтераToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиСтраницыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem печатьToolStripMenuItem;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

