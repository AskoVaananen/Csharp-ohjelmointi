using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h3t3
{
    class Program
    {
        static void Main(string[] args)
        {
            television television = new television();

            television.IsOn = true;
            television.Volume = 0;
            television.Channel = 0;

            Console.WriteLine(television.ToString());
            Console.ReadLine();

            television.AdjustVolumeUp();
            television.AdjustVolumeUp();
            television.AdjustVolumeUp();

            Console.WriteLine(television.ToString());
            Console.ReadLine();

            television.AdjustVolumeDown();
            television.AdjustVolumeDown();
            television.AdjustVolumeDown();

            Console.WriteLine(television.ToString());
            Console.ReadLine();

            television.ChangeChannelUp();
            television.ChangeChannelUp();

            television.ChangeChannelDown();
            television.IsOn = false;

            Console.WriteLine(television.ToString());
            Console.ReadLine();
        }
    }
}
