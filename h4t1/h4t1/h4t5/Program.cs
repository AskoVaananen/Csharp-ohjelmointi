using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Tehtävässä tulee toteuttaa C#-ohjelma radion perustoimintojen testaamiseen.

Kannettavassa radiossa on vain kolme säädintä: päälle/pois-kytkin, äänen voimakkuuden säädin (arvot 0, 1, 2,..., 9)
ja kuunneltavan kanavan taajuusvalinta (2000.0 - 26000.0). Laadi luokka kannettavan radion toteutukseksi.
Käytä tekemääsi luokkaa pääohjelmasta käsin, eli testaile radion toimivuutta erilaisilla voimakkuuden ja taajuuden arvoilla.
Jätä asetus- ja tulostuslauseet näkyville pääohjelmaan, jotta radio-olion käyttö voidaan todentaa.

*/
namespace h4t5
{
    class Program
    {
        static void Main(string[] args)
        {

            radio radio = new radio();
            Console.WriteLine(radio.ToString());
            radio.IsOn = true;
            radio.Volume = 9;
            radio.Frequency = 25000;
            Console.ReadLine();

            Console.WriteLine(radio.ToString());
            Console.ReadLine();
            radio.Frequency = 1000.0;
            radio.Volume = 15;
            Console.WriteLine(radio.ToString());
            Console.ReadLine();

            radio radio2 = new radio(true, 9, 20000.0);
            Console.WriteLine(radio2.ToString());



            /*
            Console.Write("Give a volume level (0 - 10) ");
            string line = Console.ReadLine();

            int number;
            bool result = int.TryParse(line, out number);
            if (result)
            {
                number = radio.Volume;
                Console.WriteLine("Volume set to: " + radio.Volume);
            }

            Console.Write("Give a frequency (2000.0 - 26000.0 ");
            string freq = Console.ReadLine();

            double hz;
            bool result2 = double.TryParse(freq, out hz);
            if (result2)
            {
                hz = radio.Frequency;
                Console.WriteLine("Frequency set to: " + radio.Frequency);
                
            }

            Console.WriteLine(radio.ToString());
            */




            /* do
             {
                 Console.WriteLine("Volume set to" + " " + radio.Volume + " Level");
                 Console.WriteLine("Set volume level: (0-10) >");

                 string line = Console.ReadLine();
                 int volume;
                 result = int.TryParse(line, out volume);
                 if (result)
                 {
                     radio.Volume = volume;
                 }
             }
             while (result == true);

             bool freq;

             do
             {
                 Console.WriteLine("Frequency set to" + " " + radio.Frequency + " Hz");
                 Console.WriteLine("Set frequency level: (2000.0-26000.0) >");

                 string line = Console.ReadLine();
                 int frequency;
                 freq = int.TryParse(line, out frequency);
                 if (freq)
                 {
                     radio.Frequency = frequency;
                 }
             }
             while (freq == true);
             */

        }        
    }
}
