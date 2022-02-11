using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Car
    {
        public string Type { get; set; }
        public string NameCar { get; set; }
        public string ColorCar { get; set; }
        public int Kilometrage { get; set; }
        public string City { get; set; }
        public string Settlement { get; set; }
        public int Distance { get; set; }

        public Car(string type, string namecar, string colorcar, int kilometrage, string city, string settlement, int distance)
        {
            Type = type;
            NameCar = namecar;
            ColorCar = colorcar;
            Kilometrage = kilometrage;
            City = city;
            Settlement = settlement;
            Distance = distance;
        }
    }
}
