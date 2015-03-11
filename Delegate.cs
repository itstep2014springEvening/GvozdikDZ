using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database //В базе данных хранятся данные сотрудников - полное имя, дата рождения, стаж работы, пол. 
    //Задание: выявить всех пенсионеров. выявить всех пенсионеров мужчин с низким стажем. 
    //Выявить людей у которых день рождения в ближайшие 7 дней. Выявить людей со стажем более 40 лет.
{
    class Program
    {
        enum Gender { male, female };
     

        struct Employee
        {
            public string name;
            public DateTime birth;
            public DateTime employed;
            public Gender gender;
            public Employee (string name_, DateTime birth_, DateTime employed_, Gender gender_)
            {
                name = name_;
                birth = birth_;
                employed = employed_;
                gender = gender_;
            }
            public static bool IsVeteran(Employee e)
            {
                return (DateTime.UtcNow.Subtract(e.employed)).TotalDays / 365.2422 > 40;
            }
        }
        class Helper
        {
            public static void prinIf(Employee[] emp, TestEmployee test)
            {
                foreach (Employee e in emp)
                {
                    if (test(e))
                        Console.WriteLine(e.name);
                }
            
            }

        }
        delegate bool TestEmployee(Employee e);

        static void Main(string[] args)
        {
            TestEmployee test = new TestEmployee(Employee.IsVeteran);
            Employee[] employes = { (new Employee("Alfred", new DateTime( 1968, 2,12), new DateTime( 1988, 2,12), Gender.male)), 
                                      (new Employee("Ann", new DateTime( 1971, 5,10), new DateTime( 1991, 2,12), Gender.female)),
                                  (new Employee("Bob", new DateTime( 1945, 2,28), new DateTime( 1965, 2,12), Gender.male)),
                                  (new Employee("Alice", new DateTime( 1991, 3,3), new DateTime( 2011, 2,12), Gender.female)),
                                  (new Employee("Katrin", new DateTime( 1988, 9,11), new DateTime( 2008, 2,12), Gender.female))};


            Helper.prinIf(employes, test);
            
            
                
                //.UtcNow.Subtract)).TotalSeconds;

        }
    }
} 
