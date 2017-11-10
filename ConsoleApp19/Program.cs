using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<Person> personStack = new Stack<Person>();
            personStack.Push(CreatePerson());
            personStack.Push(CreatePerson());
            personStack.Push(CreatePerson());

            Console.WriteLine();
            Console.WriteLine("Elements in stack: {0}", personStack.Count);
            Console.WriteLine();

            foreach (Person p in personStack)
            {
                Console.WriteLine("{0} {1}", p.FirstName, p.LastName);
            }

            Console.WriteLine();
            Person outPerson = personStack.Pop();
            Console.WriteLine("{0} {1} is out", outPerson.FirstName, outPerson.LastName);
            Console.WriteLine();
            Console.WriteLine("Elements in stack: {0}", personStack.Count);
            Console.WriteLine();

            foreach (Person p in personStack)
            {
                Console.WriteLine("{0} {1}", p.FirstName, p.LastName);
            }

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
    }
}
