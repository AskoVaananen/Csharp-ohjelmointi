using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h2t6
{
    class Program
    {
        static void Main(string[] args)
        
        {
            Console.WriteLine("Anna merkkijono: >"); // karvalakkimalli
            string original = Console.ReadLine(); //otetaan merkkijono talteen
            string reversed = new string(original.Reverse().ToArray()); // käännetään merkkijono toiseen jonoon tarkistusta varten
            if (original == reversed) // jos on sama
            {
                
                Console.WriteLine("Palindromi!" + " " + reversed);
                Console.ReadLine(); 
            }
            else
            {
                Console.WriteLine("Ei ole palindromi!");
                Console.ReadLine();
            } 
        }
    }
}
