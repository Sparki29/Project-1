using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Person[] arrayOfPersons = new Person[10];

            InitializePersons(arrayOfPersons);

            ListMyArray(arrayOfPersons);

            Console.ReadLine();
        }

        private static Person CreatePerson()
        {
            Person newPerson = new Person();

            Console.Write("First name: ");
            newPerson.FirstName = Console.ReadLine();

            Console.Write("Last name: ");
            newPerson.LastName = Console.ReadLine();
            return newPerson;
        }

        private static void InitializePersons(Person[] arrayOfPersons)
        {
            Person p1 = new Person();
            p1.FirstName = "Thomas";
            p1.LastName = "Anderson";

            arrayOfPersons[0] = new Person { FirstName = "Thomas", LastName = "Anderson" };
            arrayOfPersons[1] = new Person { FirstName = "Trinity", LastName = "Anderson" };
            arrayOfPersons[2] = new Person { FirstName = "Little", LastName = "Tom" };
            arrayOfPersons[3] = CreatePerson();
        }

        private static void ListMyArray(Person[] arrayOfPersons)
        {
            foreach (Person p1 in arrayOfPersons)
            {
                if (p1 != null)
                {
                    Console.WriteLine("{0} {1}", p1.FirstName, p1.LastName);
                }
            }
        }
        
    }
}
