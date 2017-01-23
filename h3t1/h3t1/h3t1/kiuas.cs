using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h3t1
{
    class kiuas
    {
        public bool IsOn { get; set; }
        public int Temperature { get; set; }
        public int Humidity { get; set; }


        public override string ToString()
        {
            return "Kiuas status: " + IsOn + "\nTemperature: " + Temperature + "\nHumidity: " + Humidity + "\n";
        }


    }
}
