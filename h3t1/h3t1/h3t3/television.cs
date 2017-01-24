using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h3t3
{
    class television
    {
        public bool IsOn { get; set; }
        public int Volume { get; set; }
        public int Channel { get; set; }

        public void AdjustVolumeUp()
        {
            Volume += 1;

        }

        public void ChangeChannelUp()
        {
            Channel += 1;

        }
        public void AdjustVolumeDown()
        {
            Volume -= 1;

        }

        public void ChangeChannelDown()
        {
            Channel -= 1;

        }

        public override string ToString()
        {
            return "Television status: " + IsOn + "\nChannel: " + Channel + "\nVolume: " + Volume;

        }

    }
}
