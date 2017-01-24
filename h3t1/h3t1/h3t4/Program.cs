using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h3t4
{
    class Program
    {
        static void Main(string[] args)
        {

            vehicle vehicle = new vehicle();
            Console.WriteLine("You created new vehicle" + vehicle.Name);

            vehicle.Name = "Jeep";
            vehicle.Speed = 100;
            vehicle.Tyres = 4;

            vehicle.PrintData();
            Console.ReadLine();

            vehicle.Accelerate();
            vehicle.Accelerate();
            vehicle.Brake();

            Console.WriteLine(vehicle.ToString());
            Console.ReadLine();

            vehicle bus = new vehicle();
            Console.WriteLine("You created new vehicle");
            bus.Name = "Volvo";
            bus.Speed = 40;
            bus.Tyres = 10;

            bus.PrintData();
            Console.ReadLine();
            bus.Accelerate();
            bus.Brake();

            Console.WriteLine(bus.ToString());
            Console.ReadLine();



        }
    }
}
