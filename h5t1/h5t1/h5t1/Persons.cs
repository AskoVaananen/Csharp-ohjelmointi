using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h5t1
{
    class Persons 
    {
        private List<Person> persons;

        public Persons()
        {
            persons = new List<Person>();
        }

        public void AddPerson(Person person)
        {
            persons.Add(person);
        }
        public void PrintData()
        {
            foreach (Person person in persons)
            {
                Console.WriteLine(person.ToString());
            }
        }
        public Person FindPerson(string socialSecurityNumber)
        {
            foreach (Person person in persons)
            {
                if (socialSecurityNumber.Equals(person.SocialSecurityNumber))
                 return person;
                

                
            }
            return null;
        }
            
        public Person GetPerson(int index)
        {
            if (index < persons.Count)
                return persons.ElementAt(index);

            else return null;
        }

    }
}
