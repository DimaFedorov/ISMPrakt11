using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Train:Vehicle
    {
        public string Type { get; set; }
        public string NameTrain { get; set; }
        public string ColorTrain { get; set; }
        public int Kilometrage { get; set; }
        public string City { get; set; }
        public string Settlement { get; set; }
        public int Distance { get; set; }

        public Train(string type, string nametrain, string colortrain, int kilometrage, string city, string settlement, int distance)
        {
            Type = type;
            NameTrain = nametrain;
            ColorTrain = colortrain;
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

            return $"{Type}: ({NameTrain}, {ColorTrain}), {GetMileage()} km";
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
