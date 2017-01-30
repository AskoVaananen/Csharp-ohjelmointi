using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Chicken : Animal
    {
        public override int Legs
        {
            get
            {
                return 2;
            }
        }

        public override void Talk()
        {
            Console.WriteLine("CotCot!");
        }
    }