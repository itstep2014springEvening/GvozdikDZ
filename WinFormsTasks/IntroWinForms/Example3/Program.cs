using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example3
{
    static class Program
    {
        // указывает исполняющей среде .NET  запускать программу в отделенном потоке 
        [STAThread]
        static void Main()
        {
            // Метод EnableVisualStyles класса Application позволяет задать 
            // внешний вид  некоторых элементов управления. 
            Application.EnableVisualStyles();
            
            // Задает значение по умолчанию общего для приложения свойства UseCompatibleTextRendering для элементов управления.
            // Свойство UseCompatibleTextRendering предназначено для обеспечения 
            // визуальной совместимости между элементами управления Windows Forms, 
            // которые используют для отрисовки текста 
            Application.SetCompatibleTextRenderingDefault(false);
            
            // Запускает стандартный цикл обработки сообщений приложения в текущем потоке 
            Application.Run(new Form1());  // Form1 - имя главной формы приложения
        }
    }
}
