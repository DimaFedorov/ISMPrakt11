using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Taxi:Car
    {
        public Taxi(string type, string namecar, string colorcar, int kilometrage, string city, string settlement, int distance) : base(type, namecar, colorcar,
            kilometrage, city, settlement, distance)
        {

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
