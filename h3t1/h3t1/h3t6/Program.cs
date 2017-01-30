using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h3t6
{

   
    class Program
    {
        static void Main(string[] args)
        {

            cd cd = new cd("Nightwish", "Endless Forms Most Beautiful", "Symphonic metal", 19.9);

            songs[] song = new songs[11];
            song[0] = new songs("Shudder Before the Beautiful", "06:29");
            song[1] = new songs("Weak Fantasy", "05:23");
            song[2] = new songs("Elan", "04:45");
            song[3] = new songs("Yours Is an Empty hope", "05:34");
            song[4] = new songs("Our Decades in the Sun", "06:37");
            song[5] = new songs("My Walden", "04:38");
            song[6] = new songs("Endless Forms Most Beautiful", "05:07");
            song[7] = new songs("Edema Ruh", "05:15");
            song[8] = new songs("Apenglow", "04:45");
            song[9] = new songs("The Eyes of Sharbat Gula", "06:03");
            song[10] = new songs("The Greatest Show on Earth", "24:00");


            Console.WriteLine(cd.ToString());

            for (int i = 0; i < song.Length; i++)
            {
                song[i].Printdata();
            }

            Console.ReadLine();

        }
    }
}
