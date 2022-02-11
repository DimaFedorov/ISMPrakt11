using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public abstract class Vehicle
    {
        public abstract string Go();
        public abstract int GetMileage();
        public abstract string ShowInfo();
        public abstract string GetSettlement();
    }
}
