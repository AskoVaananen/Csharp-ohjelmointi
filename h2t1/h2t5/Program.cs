using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h2t5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] taulukko1 = { 1, 3, 5, 4, 9 };
            int[] taulukko2 = { 2, 10, 44, 6, 8 };


            int[] result = taulukko1.ToList().Concat(taulukko2.ToList()).ToArray(); // näin voi yhdistää kaksi taulukkoa T:stackoverflow
            Array.Sort(result);


            
                foreach (int res in result) // tulostetaan taulukko 
                {
                     
                    Console.WriteLine(res);
                }

            
            

        }
    }
}
