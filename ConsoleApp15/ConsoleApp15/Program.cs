using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name:");

            string name = Console.ReadLine();

            Console.Write("Please enter your age: ");

            int age = int.Parse(Console.ReadLine());

            Console.Write("What is the year: ");

            int year = int.Parse(Console.ReadLine());

            int bornIn = year - age;

            Console.Clear();

            Console.WriteLine("Hello {0} ! You were born in {1} .",name,bornIn);

            Console.ReadLine();
        }
    }
}
