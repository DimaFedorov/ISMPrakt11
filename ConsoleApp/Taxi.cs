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
    }
}
