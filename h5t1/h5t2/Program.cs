using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h5t2
{


    class Program
    {
        static void Main(string[] args)
        {

            cd cd = new cd("Nightwish", "Endless Forms Most Beautiful", "Symphonic metal", 19.9);
            cd cd1 = new cd("Eppu Normaali", "Parhaat", "Rock", 20.1);
            cd.AddSongs("Nemo", "1.11");
            cd.AddSongs("kappale 2", "2.16");
            cd.AddSongs("kappale 3", "5.16");
            cd.AddSongs("kappale 4", "4.16");
            cd.AddSongs("kappale 5", "3.16");

            cd1.AddSongs("Vihreän joen rannalla", "1.11");
            cd1.AddSongs("Lisää Eppuja 2", "2.16");
            cd1.AddSongs("Lisää Eppuja 3", "5.16");
            cd1.AddSongs("Lisää Eppuja 4", "4.16");
            cd1.AddSongs("Lisää Eppuja 5", "3.16");





            Console.WriteLine(cd.ToString());
            cd.songs.ForEach(Console.WriteLine);
            Console.ReadLine();
            Console.WriteLine(cd1.ToString());
            cd1.songs.ForEach(Console.WriteLine);


            Console.ReadLine();

        }
    }
}
