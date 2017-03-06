using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h7t1
{
    class Program
    {
        /* 
         Muokkaa tehtävää 3 harjoitukset 6:ssa niin että työntekijät pystytään tallentamaan erikseen tiedostoon listauksen ja lisäämisen lisäksi, tallennetut henkilöt pitää pystyä
         myös lukemaan tiedostosta erikseen. Pääohjelmassa tekstipohjainen käyttöliittymä kaikkiin toimintoihin.
         
        */
        static void Main(string[] args)
        {
            Yritys henkilot = new Yritys();

            while (true)
            {
                int valikko = 0;
                Console.WriteLine("1. Palkkaa. 2. Erota. 3. Listaa 4. Tallenna henkilöt 5. Tulosta tallennetut henkilöt 0. Lopeta:");
                Console.WriteLine("Give a selection");
                bool status = int.TryParse(Console.ReadLine(), out valikko);

                switch (valikko)


                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:

                        Console.WriteLine("Give a new employee");
                        string name = Console.ReadLine();
                        henkilot.AddEmployee(name);
                        break;


                    case 2:

                        Console.WriteLine("Delete latest employee");
                        henkilot.DelEmployee();
                        break;

                    case 3:

                        Console.WriteLine("List all employees");
                        henkilot.PrintData();
                        break;

                    case 4:
                        
                        Console.WriteLine("Save all employees");
                        henkilot.TallennaHenkilo();
                        break;

                    case 5:

                        Console.WriteLine("Print saved employees");
                        henkilot.TulostaHenkilo();
                        break;

                }
            }
        }
    }
}

