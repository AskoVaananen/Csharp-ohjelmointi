using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h3t5
{

    /*
     * Suunnittele UML-editorilla Opiskelija-luokka, joka sisältää opiskelijalle tyypillisiä tietoja ja toimintoja. 
     * Tee uusi projekti. Ohjelmoi Opiskelija-luokka sekä toteuta pääohjelma, joka luo muutamia opiskelijoita ja tallentaa opiskelijat taulukkoon
     * (esim. 5 opiskelijaa). Tulosta taulukossa olevien opiskelijoiden tiedot käyttämällä toistorakennetta. 

     */
    class Program
    {
        static void Main(string[] args)
        {

            student[] students = new student[5];
            students[0] = new student("Asko", "Väänänen", "H8688", "TTV15S6", 22);
            students[1] = new student("Matti", "Kohonen", "H8628", "TTV15S6", 21);
            students[2] = new student("Jesse", "Siekkinen", "H1234", "TTV15S6", 20);
            students[3] = new student("Aatu", "Muukka", "K2288", "TTV15S6", 19);
            students[4] = new student("Ville", "Vahtokari", "H3456", "TTV15S6", 88);

    
            for (int i = 0; i < students.Length; i++)
            {
                students[i].Printdata();
            }

            Console.ReadLine();
            Console.WriteLine("Happy Birthdat Jesse!\n");
            students[2].IncreaseAge();

            Console.WriteLine("Happy Birthdat Aatu!\n");
            students[3].IncreaseAge();

            Console.ReadLine();

            for (int i = 0; i < students.Length; i++)
            {
                students[i].Printdata();
            }

            Console.ReadLine();
        }
    }
}
