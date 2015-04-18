namespace Example3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора форм. 
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Очистка всех используемых ресурсов. 
        /// </summary>
        /// <param name="disposing">true, если ресурсы нужно освободить; иначе, false.</param>
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
        /// Метод необходим для работы конструктора форм - не изменяйте 
        /// содержимое этого метода средствами редактора кода. 
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Text = "Form1";
        }

        #endregion
    }
}

