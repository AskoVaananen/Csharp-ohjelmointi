using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h3t2
{
    class washingmachine
    {
        public bool IsOn { get; set; }
        public int Watertemperature { get; set; }
        public int Sling { get; set; }
        public bool Wateron { get; set; }

        public override string ToString()
        {
            return "washingmachine status: " + IsOn + "\nTemperature: " + Watertemperature + "\nSling: " + Sling + " Rounds/minute" + "\n" +"Water status: " + Wateron;

        }
    }
}
