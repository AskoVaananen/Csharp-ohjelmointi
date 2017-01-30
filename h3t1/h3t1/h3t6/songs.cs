using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h3t6
{
    class songs
    {


        public string Name
        {
            get;
            set;
        }


        public string Time
        {
            get;
            set;
        }

        public songs(string name, string time)
        {
            Name = name;
            Time = time;
        }

        public void Printdata()
        {
            
            Console.WriteLine("--- Name: " + Name + " " + "-" + " " + Time);
            
        }

        public override string ToString()
        {
            return "---Name: " + Name + "\nTime: " + Time;

        }
    }
}
