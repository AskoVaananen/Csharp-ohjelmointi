using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h5t2
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
        public List<songs> songs;









        public void Printdata()
        {
            Console.WriteLine(" CD : ");
            Console.WriteLine("- Artist : " + Artist);
            Console.WriteLine("- Cd Name : " + CdName);
            Console.WriteLine("- Genre : " + Genre);
            Console.WriteLine("- Price : " + Price + "$");




        }




        public cd(string artist, string cdname, string genre, double price)
        {
            Artist = artist;
            CdName = cdname;
            Genre = genre;
            Price = price;
            this.songs = new List<songs>();


        }

    

        public void AddSongs(string name, string time)
        {
            songs.Add(new songs(name, time));
        }
        public override string ToString()
        {
            return "Artist: " + Artist + "\nName: " + CdName + "\nGenre: " + Genre + "\nPrice: " + Price + " $" + "\nSongs: ";


        }

        
}
}
