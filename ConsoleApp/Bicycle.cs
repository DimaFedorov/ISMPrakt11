using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Bicycle
    {
        public string Type { get; set; }
        public string NameBicycle { get; set; }
        public string ColorBicycle { get; set; }
        public int Kilometrage { get; set; }
        public string City { get; set; }
        public string Settlement { get; set; }
        public int Distance { get; set; }
        public Bicycle(string type, string namebicycle, string colorbicycle, int kilometrage, string city, string settlement, int distance)
        {
            Type = type;
            NameBicycle = namebicycle;
            ColorBicycle = colorbicycle;
            Kilometrage = kilometrage;
            City = city;
            Settlement = settlement;
            Distance = distance;
        }
    }
}
