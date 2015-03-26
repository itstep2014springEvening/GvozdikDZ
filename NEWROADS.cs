using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;


namespace City
{
    [Serializable]
    public class City
    {
        public string name;
        public List<Road> roads = new List<Road>();
        public City(string name)
        {
            this.name = name;
        }
        public void AddRoad(City city, uint distanceTime)
        {

            this.roads.Add(new Road(city, distanceTime));
            city.roads.Add(new Road(this, distanceTime));

        }

    }
    [Serializable]
    public class Road
    {
        public uint distanceTime;
        public City destination;
        public Road (City destination, uint distanceTime)
        {
            this.destination = new City(destination.name);
            this.distanceTime = distanceTime;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Random random=new Random(123);

            string [] cityNames = new string[] {"Minsk", "Mogilev","Grodno", "Gomel", "Vitebsk", "Brest"};
            Dictionary<string, City> cities = new Dictionary<string,City>();
            foreach (string n in cityNames)
            {
                City newCity = new City(n);

                foreach(KeyValuePair<string, City> x in cities) {
                    newCity.AddRoad(x.Value, (uint) random.Next(1,56));
                }
                cities[n] = newCity;
            }

            System.IO.FileStream fs2 = new FileStream("x.xml", FileMode.Create, FileAccess.ReadWrite);
            BinaryFormatter sf = new BinaryFormatter();

            // write
            sf.Serialize(fs2, cities);

            fs2.Seek(0, SeekOrigin.Begin);

            Dictionary<string, City> B2 = (Dictionary<string, City>)sf.Deserialize(fs2);

            fs2.Close();

            //Console.WriteLine(B2.Name + B2.Age);
            
            /*minsk.roads.Add(new Road(grodno, 320));
            foreach(Road r in minsk.roads)
            {
                Console.WriteLine(r.destination);
            }*/
            //Console.WriteLine(minsk.road.First());
        }
    }
}
