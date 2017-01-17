using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h2t1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pisteet = new int[5];
            for (int i = 0; i < pisteet.Length; i++)
            {
                Console.WriteLine("Anna pisteet");
                pisteet[i] = int.Parse(Console.ReadLine());
            }
            int summa = 0;
            Array.Sort(pisteet);
            for (int i = 1; i < pisteet.Length - 1; i++)
            {

               summa += (pisteet[i]);
               
            }

            Console.Write("pisteet ovat = " + summa);

            Console.ReadLine();

        }

    }
}
