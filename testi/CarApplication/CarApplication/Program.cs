using System;

namespace CarApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a one car instance
            Car datsun = new Car();
            datsun.Model = "Datsun 100A";
            //datsun.Color = "red";
            datsun.Engine = 1.0;
            datsun.Speed = 0;
            datsun.FuzzyDices = true;
            datsun.DoorCount = 2;
            // display car data
            datsun.PrintData();
            Console.ReadLine();
            // accelerate, change car's speed value
            datsun.Accelerate();
            // display car data again, notice changed speed value!
            datsun.PrintData();
            Console.ReadLine();


            Car toyota = new Car("brown");
            toyota.Model = "corolla";
            toyota.Engine = 10.0;
            toyota.Speed = 200;
            toyota.FuzzyDices = false;
            toyota.DoorCount = 50;
            toyota.PrintData();
            Console.ReadLine();
            

        }
    }
}