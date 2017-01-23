using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h2t4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random oikea = new Random(); // random muuttujan alustus
            int oikea_vastaus = oikea.Next(1, 100); // antaa satunnaisen luvun 1-100 väliltä
            int arvaus = 0;
            int summa = 0;

            Console.WriteLine("Arvaa luku 1 ja 100 väliltä > ");
            arvaus = Convert.ToInt32(Console.ReadLine());

            while (arvaus != oikea_vastaus) // niin kauan kuin arvaus on väärin
            {
                summa++; // saadaan summattua arvaukset joka kerta kun looppi pyörähtää
                
                if (arvaus < oikea_vastaus)
                {
                    Console.WriteLine("oikea arvaus on suurempi kuin arvaamasi numero  " + arvaus + " " + "arvaa uudestaan ");
                    arvaus = Convert.ToInt32(Console.ReadLine());
                }

                else if (arvaus > oikea_vastaus)
                {
                    Console.WriteLine("oikea arvaus on pienempi kuin arvaamasi numero  " + arvaus + " " + "arvaa uudestaan ");
                    arvaus = Convert.ToInt32(Console.ReadLine());

                }
            }
            
            
                Console.WriteLine("arvasit oikein! oikea vastaus oli" + " " + arvaus +"." + " " + "Arvasit " + summa + " " + "kertaa!");
                
                
                Console.ReadLine();
            }
    }
    
        }
        

