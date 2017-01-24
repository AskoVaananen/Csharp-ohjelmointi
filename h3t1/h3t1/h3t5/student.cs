using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h3t5
{
    class student
    {
        public string FirstName
        {
            get;
            set;
        }


        public string LastName
        {
            get;
            set;
        }

        public string StudentId
        {
            get;
            set;
        }
        public string Group
        {
            get;
            set;
        }

        public int Age
        {
            get;
            set;
        }

        public void Printdata()
        {
            Console.WriteLine(" Student information : ");
            Console.WriteLine("- Name : " + FirstName);
            Console.WriteLine("- Lastname : " + LastName);
            Console.WriteLine("- Student ID : " + StudentId);
            Console.WriteLine("- Group : " + Group);
            Console.WriteLine("- Age : " + Age);
            Console.WriteLine();



        }


        public void IncreaseAge()
        {
            Age += 1;
            Console.WriteLine("Age increased 1 unit \n");

        }

        public student(string firstname, string lastname, string studentid, string group, int age)
        {
            FirstName = firstname;
            LastName = lastname;
            StudentId = studentid;
            Group = group;
            Age = age;

        }



    }
}
