using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Car:Vehicle
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
        public override string Go()
        {
            return $"{City},{Settlement},{Distance}";
        }

        public override string GetSettlement()
        {

            return $"{Settlement}";
        }
        public override string ShowInfo()
        {

            return $"{Type}: ({NameCar}, {ColorCar}), {GetMileage()} km";
        }
        public override int GetMileage()
        {
            int sum = 0;
            sum = Distance + Kilometrage;
            if (sum >= 1000000) sum -= 1000000;
            return sum;
        }
    }
}
