using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h3t2
{
    /*
     * Tehtävänäsi on ohjelmoida pesukoneen toiminta. Samoin kuin edellinen tehtävä: mitä ominaisuuksia ja toimintoja tekisit Pesukone-luokkaan?
     */
    class Program
    {
        static void Main(string[] args)
        {
            washingmachine washingmachine = new washingmachine();

            washingmachine.IsOn = true;
            washingmachine.Watertemperature = 60;
            washingmachine.Wateron = true;
            washingmachine.Sling = 600;

            Console.WriteLine(washingmachine.ToString());
            Console.ReadLine();

            washingmachine.IsOn = false;
            washingmachine.Watertemperature = 20;
            washingmachine.Wateron = false;
            washingmachine.Sling = 200;

            Console.WriteLine(washingmachine.ToString());
            Console.ReadLine();
        }
    }
}
