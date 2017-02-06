using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h5t1
{
    class Program
    {
        static void Main(string[] args)
        {
            Persons myFriends = new Persons();
            Person friend1 = new Person { Firstname = "Kirsi", Lastname = "Mainio", SocialSecurityNumber = "010190-111A" };
            Person friend2 = new Person{ Firstname = "Matti", Lastname = "Mainio", SocialSecurityNumber = "010190-111A" };
            Person friend3 = new Person{ Firstname = "Husso", Lastname = "Mainio", SocialSecurityNumber = "010190-111A" };

            myFriends.AddPerson(friend1);

            myFriends.AddPerson(friend2);

            myFriends.AddPerson(friend3);

            myFriends.PrintData();

            Person friend5 = myFriends.FindPerson("010190-111A");
            if (friend5 != null) Console.WriteLine(friend5);
        }
    }
}
