using System;
using System.Windows.Forms;  // добавление пространства имен
               // библиотеку добавляем через ссылки 
               // References->Add References->Assemblies->Framework->System.Windows.Forms->OK


// Для того чтобы убрать появление окна консоли необходимо:
// Выбрать проект -> Properties->Application->OutputType->Windows Application

namespace Example1SimpleForm
{
    class Program
    {
        static void Main()
        {
            Form form = new Form();  // создание объекта класса Form (создание окна)
            form.Text = "Приложение Windows Forms"; // изменение строки заголовка окна
            form.Width *= 2;                        // увеличение ширина окна в 2 раза
            

            Application.Run(form); 
            // Метод Application Run не возвращает управление программе, пока пользователь 
            // не закроет переданный этому методу объект Form. Порядок таков: если ApplicationRun 
            // возвращает управление программе после отображения формы, Main завершается, 
            // программа прекращает работу и в процессе очистки системы окно уничтожается. 

        }
    }
}
