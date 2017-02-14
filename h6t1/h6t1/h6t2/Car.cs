using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h6t1
{
    class Car
    {

        public int Count
        {
            get; set;
        }
        public string Name
        {
            get; set;
        }

        public Car(string name)
        {
            Name = name;
            Count = 0;

        }
   
        
        public void AddCar()
        {
            Count++;

        }

    }
}
