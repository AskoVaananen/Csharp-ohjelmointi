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

            songs[] song = new songs[10];
            song[0] = new songs("Shudder Before the Beautiful", "06:29");
            song[1] = new songs("Shudder Before the Beautiful", "06:29");
            song[2] = new songs("Shudder Before the Beautiful", "06:29");
            song[3] = new songs("Shudder Before the Beautiful", "06:29");
            song[4] = new songs("Shudder Before the Beautiful", "06:29");
            song[5] = new songs("Shudder Before the Beautiful", "06:29");
            song[6] = new songs("Shudder Before the Beautiful", "06:29");
            song[7] = new songs("Shudder Before the Beautiful", "06:29");
            song[8] = new songs("Shudder Before the Beautiful", "06:29");
            song[9] = new songs("Shudder Before the Beautiful", "06:29");
            

            Console.WriteLine(cd.ToString());

            for (int i = 0; i < song.Length; i++)
            {
                song[i].Printdata();
            }

            Console.ReadLine();

        }
    }
}
