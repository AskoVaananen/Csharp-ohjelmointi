using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h4t4
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            

            vehicle.Name = "Ferrari";
            vehicle.Model = "Enzo";
            vehicle.Year = 2016;
            vehicle.Color = "Red";

            Console.WriteLine(vehicle.ToString());
            Console.ReadLine();


            Boat boat = new Boat();

            boat.Name = "Yamarin";
            boat.Model = "L500";
            boat.Year = 1999;
            boat.Color = "Green";
            boat.Type = "Motorboat";
            boat.Seats = 10;

            Console.WriteLine(boat.ToString());
            Console.ReadLine();

            Bike bike = new Bike();

            bike.Name = "Trek";
            bike.Model = "X-caliber";
            bike.Year = 2017;
            bike.Color = "Green";
            bike.Gear = "21-gears";
            bike.GearName = "Shimano";

            Console.WriteLine(bike.ToString());
            Console.ReadLine();

            Bike bike1 = new Bike();

            bike1.Name = "Scott";
            bike1.Model = "Cheapest";
            bike1.Year = 1942;
            bike1.Color = "Black";
            bike1.Gear = "No Gears";
            bike1.GearName = "-";

            Console.WriteLine(bike1.ToString());
            Console.ReadLine();






        }
    }
}