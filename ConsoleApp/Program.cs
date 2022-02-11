using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Vehicle[] vehicles = new Vehicle[4];
            vehicles[0] = new Car("Car", "Tesla", "Білий", 53000, "Житомир", "Київ", 150);
            vehicles[1] = new Taxi("Taxi", "Toyota", "Чорний", 5555, "Житомир", "Львів", 450);
            vehicles[2] = new Train("Train", "InterCity", "Червоний", 999950, "Житомир", "Рівне", 250);
            vehicles[3] = new Bicycle("Bicycle", "KTM", "Сірий", 500, "Житомир", "Одеса", 500);

            int totalmileage = 0;

            for (int i = 0; i < vehicles.Length; i++)
            {
                totalmileage += vehicles[i].GetMileage();
                Console.WriteLine($"{vehicles[i].ShowInfo()}");
            }

            Console.WriteLine($"\nСписок відвіданих населених пунктів:");
            for (int i = 0; i < vehicles.Length; i++)
            {
                Console.WriteLine($"{vehicles[i].GetSettlement()}");
            }

            Console.WriteLine($"\nОбщий пробіг всіх транспортних засобів: {totalmileage}");
            Console.ReadKey();
        }
    }
}
