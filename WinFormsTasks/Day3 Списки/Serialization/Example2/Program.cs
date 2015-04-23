
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

class Program
{
    public static void Main()
    {

        // коллекция для сериализации
        List<CBook> books = new List<CBook>()
		{ new CBook(1, "Война и мир", 2.6),
		  new CBook(2, "Отцы и дети", 5.1),
		  new CBook(3, "Анна Каренина", 7.3)
		};
                
        using (FileStream file = new FileStream("file.txt", FileMode.Create))
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            binFormat.Serialize(file, books);// сериализация коллекции
        }

        List<CBook> newbooks; // коллекция для десериализации
      
        using (FileStream file = new FileStream("file.txt", FileMode.Open))
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            newbooks = (List<CBook>)binFormat.Deserialize(file);  // сериализация коллекции
         }

        foreach (CBook book in newbooks) // вывод на экран коллекции
        {
            Console.WriteLine(book.ToString());

        }

        Console.ReadKey(true);
    }
}

[Serializable]
class CBook
{
    int id;
    string name;
    double price;
    public CBook(int ID, string Name, double Price)
    { id = ID; name = Name; price = Price; }
    public override string ToString()
    { return string.Format("{0}. {1},{2}", id, name, price); }
}
