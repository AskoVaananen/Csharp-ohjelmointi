using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Tehtävänäsi on ohjelmoida kiukaan toiminta.
 * Kiuas pitää pystyä laittamaan päälle ja pois, sekä sen lämpötilaa että sen antamaa kosteutta pitää pystyä säätämään (arvoja ei ole rajattu).

UML
Suunnittele Kiuas-luokan ominaisuudet ja toiminnot UML-luokkakaaviona.

Ohjelmointi
Toteuta Kiuas-luokan ohjelmointi sekä pääohjelma, jolla luot olion Kiuas-luokasta.
Säädä kiuas-oliota erilaisilla arvoilla, jätä Console.WriteLine()-tulostuslauseet ohjelmaasi, jotta kiuas-olion käyttäminen jää näkyville.
 */


namespace h3t1
{
    class Program
    {
        static void Main(string[] args)
        {
            kiuas kiuas = new kiuas();
            kiuas.IsOn = true;
            kiuas.Temperature = 80;
            kiuas.Humidity = 75;

            //Console.WriteLine("kiuas status: {0}", kiuas.IsOn);
            //Console.WriteLine("humidity: {0}", kiuas.Humidity);
            //Console.WriteLine("temperature: {0}", kiuas.Temperature);

            Console.WriteLine(kiuas.ToString());

            kiuas.IsOn = false;
            kiuas.Temperature = 50;
            kiuas.Humidity = 50;

            //Console.WriteLine("kiuas status: {0}", kiuas.IsOn);
            //Console.WriteLine("humidity: {0}", kiuas.Humidity);
            //Console.WriteLine("temperature: {0}", kiuas.Temperature);

            Console.WriteLine(kiuas.ToString());
            Console.ReadLine();


        }
    }
}
