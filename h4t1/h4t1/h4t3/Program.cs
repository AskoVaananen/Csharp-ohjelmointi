using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h4t3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Name = "Kirsi Kennel";
            employee.Profession = "teacher";
            employee.Salary = 2200;
            Console.WriteLine(employee.ToString());


            Boss boss = new Boss();

            boss.Name = "Matti kohonen";
            boss.Profession = "boss";
            boss.Salary = 10000;
            boss.Car = "Opel";
            boss.Bonus = 2500;
            Console.WriteLine(boss.ToString());







        }
    }
}
