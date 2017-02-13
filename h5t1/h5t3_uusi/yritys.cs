using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h5t3_uusi
{
    class yritys
    {
        Stack<string> henkilot = new Stack<string>();



        public void AddEmployee(string name)
        {
            henkilot.Push(name);

        }
        public void DelEmployee()
        {

            string temp = (henkilot.Pop()); // third
        }
        public void PrintData()
        {

            // print all
            foreach (string s in henkilot)
            {
                Console.WriteLine(s);

                //string temp = henkilot.Pop();
                //Console.WriteLine("temp is {0}", temp); // temp is third
                //Console.WriteLine("Count is {0}", henkilot.Count); // count is 2




            }
        }
    }
}
