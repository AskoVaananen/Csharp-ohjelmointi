using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h3t4
{
    class vehicle
    {

        // properties
        public string Name
        {
            get;
            set;
        }


        public int Speed
        {
            get;
            set;
        }

        public int Tyres
        {
            get;
            set;
        }


        public void Accelerate()
        {
            Speed += 10;
            Console.WriteLine(" You increased speed + 10 units\n" + " Speed is now: " + Speed);
            

        }
        // methods
        public void Brake()
        {
            Speed -= 10;
            Console.WriteLine(" You lowered speed - 10 units\n" + " Speed is now:" + Speed);
        }


        public void PrintData()
        {
            Console.WriteLine("Vehicle data : ");
            Console.WriteLine("- Name : " + Name);
            Console.WriteLine("- Tyres : " + Tyres);
            Console.WriteLine("- Speed : " + Speed);


        }

        public override string ToString()
        {
            return "Vehicle name: " + Name + "\nTyres: " + Tyres + "\nSpeed: " + Speed;

        }


    }
}
