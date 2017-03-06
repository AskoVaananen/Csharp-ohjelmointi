using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h7t1
{
    class Yritys
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
        public void TallennaHenkilo()
        {
            StreamWriter sw = new StreamWriter("henkilo.txt");

            foreach (string h in henkilot)
            {
                try
                {

                    sw.WriteLine(h);
                }
                catch (UnauthorizedAccessException)
                {
                    Console.WriteLine("Can't open file for writing (UnauthorizedAccessException)");
                }
                catch (IOException)
                {
                    Console.WriteLine("An IO error happened (IOException)");
                }
                catch (Exception)
                {
                    Console.WriteLine("Some other exception happend (Exception)");
                }



            }
        }

        public void TulostaHenkilo()
        {
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader("henkilo.txt"))
                {
                    // Read the stream to a string, and write the string to the console.
                    string line = sr.ReadToEnd();
                    Console.WriteLine(line);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("something happened (Exception)");
            }

        }
    }
}

