using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example4
{
    class Program
    {
        static void Main(string[] args)
        {
            // получение атрибута их типа!
            InfoAboutClass.GetAttribute(typeof(Car));
          
            Console.ReadKey();
        }
    }

    // Создание пользовательского атрибута!
    [AttributeUsage (AttributeTargets.Class)]  // указывает, что атрибут буде примен только к классу
    class InfoAboutAttribute : Attribute  // наследуемся от класса Attribute
    {
        public string Desc;
         
    }

    [InfoAbout(Desc="Класс автомобиль")]  // применение атрибута
    class Car
    {  // тело класса
    }

    class InfoAboutClass
    {
        public static void GetAttribute(Type t)
        {   
            // получение сведений об атрибуте 
            InfoAboutAttribute att = (InfoAboutAttribute)Attribute.GetCustomAttribute(t, typeof(InfoAboutAttribute));
            Console.WriteLine("{0}", att.Desc);
        }
    }

}
