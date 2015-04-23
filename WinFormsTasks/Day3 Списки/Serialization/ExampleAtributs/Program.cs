using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleAtributs
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleHuman Petr = new SimpleHuman("Петр", "Иванов");
            Student Ivan = new Student("Иван", "Немиров");
            
            HumanPrinter HP = new HumanPrinter();
            HP.Show(Petr);   // Объект Petr выводится без
                             // трансформации текста
           
            HP.Show(Ivan);   // Объект Ivan выводится с
                             // трансформацией текста
            
            Console.ReadKey();
        }
    }

   
        interface IHuman
        {
            string getFName { get; } // Получить Фамилию Человека
            string getSName { get; } // Получить Имя Человека
        }

       //  Пользовательский атрибут трансформации текста в верхний/нижний регистр
        public sealed class TextTransformAttribute : System.Attribute
        {
            public bool isUpperCase; // true - в верхний регистр,
                                     // false - в нижний
        }

        class SimpleHuman : IHuman
        {
            string FName, SName;
            public SimpleHuman(string FNm, string SNm)
            {
                FName = FNm;
                SName = SNm;
            }
            public string getFName
            {
                get { return FName; }
            }
            public string getSName
            {
                get { return SName; }
            }
        }


     //   Класс "Студент" также хранит Фамилию и Имя
     //   с помощью атрибута TextTransform формируем метаданные
     //   с информацией о том, что Фамилия и Имя должны переводиться
     //   в верхний регистр.
        [TextTransform(isUpperCase = true)]
        class Student : IHuman
        {
            string FName, SName;
            public Student(string FNm, string SNm)
            {
                FName = FNm;
                SName = SNm;
            }
            public string getFName
            {
                get { return FName; }
            }
            public string getSName
            {
                get { return SName; }
            }
        }

        class HumanPrinter
        {
            public void Show(IHuman H)
            {
                string firstName = H.getFName;
                string surrName = H.getSName;
                // ----- Проверка, на атрибут TextTransform ---------------------
                Type T = H.GetType();
                TextTransformAttribute[] TTA = (TextTransformAttribute[])T.GetCustomAttributes( typeof(TextTransformAttribute), false);
                
                if (TTA.Length != 0)
                {
                    // ----- атрибут TextTransform обнаружен, переводим в нужный регистр ----
                    firstName = (TTA[0].isUpperCase) ?  firstName.ToUpper() : firstName.ToLower();
                    surrName = (TTA[0].isUpperCase) ?   surrName.ToUpper() : surrName.ToLower();
                }
                
                // ----- Вывод на экран -----------------------------------------
                Console.WriteLine("----------");
                Console.WriteLine("Фамилия : {0}", firstName);
                Console.WriteLine("Имя : {0}", surrName);
            }
        }
}
