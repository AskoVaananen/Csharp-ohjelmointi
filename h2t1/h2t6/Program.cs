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
            StringBuilder temp = new StringBuilder(); // alustetaan väliaikainen merkkijono josta poistetaan merkkejä joten voi katsoa onko jokin lause palindromi.
            foreach (char x in original)

            {
                if ( (x >= 'a' && x <= 'z')) // "Tavalliset" merkit määritetty

                {
                    temp.Append(x); // lisää kaikki tavalliset merkit alkuperäisestä väliaikaiseen merkkijonoon
                }
            }
            string muutettu_jono = temp.ToString(); // väliaikainen jono merkkijonoon "muutettu_jono" josta on siis poistettu kaikki ylimääräinen


                    string reversed = new string(muutettu_jono.Reverse().ToArray()); // käännetään merkkijono toiseen jonoon tarkistusta varten

                    if (muutettu_jono == reversed) // jos on sama
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
    

