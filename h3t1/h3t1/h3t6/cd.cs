using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h3t6
{
    class cd
    {
        public string Artist
        {
            get;
            set;
        }


        public string CdName
        {
            get;
            set;
        }

        public string Genre
        {
            get;
            set;
        }
        public double Price
        {
            get;
            set;
        }

        public string Songs
        {
            get;
            set;
        }

       





        public void Printdata()
        {
            Console.WriteLine(" CD : ");
            Console.WriteLine("- Artist : " + Artist);
            Console.WriteLine("- Cd Name : " + CdName);
            Console.WriteLine("- Genre : " + Genre);
            Console.WriteLine("- Price : " + Price);
           



        }

       


        public cd(string artist, string cdname, string genre, double price)
        {
            Artist = artist;
            CdName = cdname;
            Genre = genre;
            Price = price;


        }

        public override string ToString()
        {
            return "Artist: " + Artist + "\n Name: " + CdName + "\nGenre: " + Genre + "\nPrice: " + Price + "\nSongs:\n";

        }
    }
}
