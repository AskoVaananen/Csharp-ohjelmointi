using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h4t4
{
    class Bike : Vehicle
    {
        public string Gear
        {
            get;
            set;
        }

        public string GearName
        {
            get;
            set;
        }


        public Bike(string name,string model,int year,string color,string gear, string gearname)
            : base(name, model, year, color)
        {
            Gear = gear;
            GearName = gearname;


        }
        public Bike()
        {

        }

        public override string ToString()
        {
            Console.WriteLine("New Bike maded");
            return base.ToString() + " Gear:  " + Gear + " Name of gears:  " + GearName;
        }




    }
}


    
