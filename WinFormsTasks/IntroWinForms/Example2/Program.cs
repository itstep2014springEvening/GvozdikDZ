using System;
using System.Windows.Forms;
using System.Drawing;

namespace Example2SimpleForm
{
    class Program
    {
        static void Main()
        {
            MyForm form = new MyForm();
            Application.Run(form);
        }
    }
    // создание  класса, наследующего класс Form
    class MyForm:Form
    { 
        public TextBox textBox;
        public Label label;
        public Button button;
        public MyForm()
      {
          this.Text = "Приложение Windows Forms";   // изменение строки заголовка окна
          this.Width *= 2;

          label = new Label();                      // создание элемента - "Надпись"
          label.Text = "Элемент Label";
          label.Location = new Point(30, 20);       // установка положения надписи
          label.ForeColor = Color.Red;              // установка цвета надписи
          Controls.Add(label);                      // добавление надписи в коллекцию 
                                                    // элементов управления (контролов) окна

          textBox = new TextBox();                  // создание элемента "Редактируемое текстовое поле" 
          textBox.Text = "Элемент TextBox";         // занесение текста в редактируемое поле
          textBox.Width = 150; textBox.Height = 25; // изменение ширины и высоты редактируемого поля
          textBox.Location = new Point(30,50);      // установка положения редактируемого поля
          // для использования структуры Point необходимо добавить using System.Drawing;
          // и добавить библиотеку через Add References

          Controls.Add(textBox);                    // добавление редактируемого поля в коллекцию 
                                                    // элементов управления (контролов) окна

          button = new Button();                    // создание элемента "Кнопка"
          button.Location = new Point(30, 80);      // установка положения кнопки
          button.Text = "Элемент Button";           // изменение подписи кнопки
          button.ForeColor = Color.Blue;            // установка цвета кнопки
          button.Click += new EventHandler(button_Click); // добавление обработчика события по событию Click

          Controls.Add(button);                    // добавление кнопки в коллекцию 
                                                    // элементов управления (контролов) окна
      }
        // обработчик события по событию Click (нажатию по кнопке)
        void button_Click(object sender, EventArgs e)
        {
            button.ForeColor = Color.Green;       // изменение цвета подписи кнопки       
            textBox.Text = "Произошло событие";   // изменение текста в редактируемом поле
            this.Height *= 2;                     // изменение высоты главной формы
        }

      
    }
}
