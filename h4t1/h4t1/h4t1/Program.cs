using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h4t1
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator elevator = new Elevator();
            bool result;

            do
            {
                Console.WriteLine("Elevator is in" + " " + elevator.Floor + " floor");
                Console.WriteLine("Give a floor number (1-5) >");

                string line = Console.ReadLine();
                int floor;
                result = int.TryParse(line, out floor);
                if (result)
                {
                    elevator.Floor = floor;
                }

            }
            while (result);
            Console.WriteLine("press something");
            Console.ReadLine();



        }
    }
}
