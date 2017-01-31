using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h4t2
{
    class Amplifier
    {

        private const int minVolume = 1;
        private const int maxVolume = 100;
        private int volume = 1;

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
        }
    }


    

