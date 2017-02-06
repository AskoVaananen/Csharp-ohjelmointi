using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h4t5
{
    class radio
    {
        private const int minVolume = 1;
        private const int maxVolume = 10;
        private int volume = 1;
        private const double minFreq = 2000.0;
        private const double maxFreq = 26000.0;
        private double frequency = 2000.0;

        public bool IsOn
        {
            get;
            set;
        }

        public int Volume
        {

            get
            {
                return volume;
            }


            set
            {


                if (value < minVolume)
                {

                    Console.WriteLine("volume level is too low, set to minimum");
                    volume = minVolume;

                }

                else if (value > maxVolume)

                {

                    Console.WriteLine("volume level is too high, set to maximum");
                    volume = maxVolume;

                }

                else
                {
                    volume = value;
                }
            }
        }


        public double Frequency
        {

            get
            {
                return frequency;
            }


            set
            {


                if (value < minFreq)
                {

                    Console.WriteLine("Frequency is too low, set to minimum");
                    frequency = minFreq;

                }

                else if (value > maxFreq)

                {

                    Console.WriteLine("Frequency level is too high, set to maximum");
                    frequency = maxFreq;

                }

                else
                {
                    frequency = value;
                }
            }
        }
        public radio()
        {

        }
        //constructor

        public radio(bool ison, int volume, double frequency)
        {
            IsOn = ison;
            Volume = volume;
            Frequency = frequency;


        }

        //overriding tostring
        public override string ToString()
        {
            return "Radio status:\n " + " Power: " + IsOn + "\n " + " Volume: " + Volume +
                "\n " + " Frequency: " + Frequency;
        }
    }
}
    



