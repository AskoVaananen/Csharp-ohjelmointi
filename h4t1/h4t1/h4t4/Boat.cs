using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h4t4
{
    class Boat : Vehicle
    {
        public string Type
        {
            get;
            set;
        }

        public int Seats
        {
            get;
            set;
        }


        public Boat(string name, string model, int year, string color, string type, int seats)
            : base(name, model, year, color)
        {
            Type = type;
            Seats = seats;


        }
        public Boat()
        {

        }

        public override string ToString()
        {
            Console.WriteLine("New Boat maded");
            return base.ToString() + " Type:  " + Type + " Number of seats:  " + Seats;
        }




    }
}
    

