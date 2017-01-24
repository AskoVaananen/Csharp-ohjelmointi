using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h3t3
{
    class television
    {
        public bool IsOn { get;
                            set; }


        public int Volume { get;
                            set; }

        public int Channel { get;
                             set; }

        public void AdjustVolumeUp()
        {
            Volume += 1;
            Console.WriteLine("Volume adjusted one level higher");

        }

        public void ChangeChannelUp()
        {
            Channel += 1;
            Console.WriteLine("Channel adjusted one level higher");

        }
        public void AdjustVolumeDown()
        {
            Volume -= 1;
            Console.WriteLine("Volume adjusted one level lower");

        }

        public void ChangeChannelDown()
        {
            Channel -= 1;
            Console.WriteLine("Channel adjusted one level lower");
        }

        public override string ToString()
        {
            return "Television status: " + IsOn + "\nChannel: " + Channel + "\nVolume: " + Volume;

        }

    }
}
