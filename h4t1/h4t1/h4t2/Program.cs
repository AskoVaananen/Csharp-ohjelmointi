using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h4t2
{
    class Program
    {
        static void Main(string[] args)
        {
            Amplifier amplifier = new Amplifier();
            bool result;

            do
            {
                Console.WriteLine("Volume set to" + " " + amplifier.Volume + " dB");
                Console.WriteLine("Set volume level: (0-100) >");

                string line = Console.ReadLine();
                int volume;
                result = int.TryParse(line, out volume);
                if (result)
                {
                    amplifier.Volume = volume;
                }

            }
            while (result);
            Console.WriteLine("press something");
            Console.ReadLine();



        }
    }
}