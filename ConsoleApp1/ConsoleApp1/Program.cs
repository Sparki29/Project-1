using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your age: ");

            string myAgeAsString = Console.ReadLine();

            int myAgeAsInt = 0;

            try
            {

                myAgeAsInt = int.Parse(myAgeAsString);

                Console.Write("My Age Is ");

                Console.WriteLine(myAgeAsInt);

                int myAgeNextYear = myAgeAsInt + 1;

                Console.Write("Next year I will be ");

                Console.Write(myAgeNextYear);
            }

            catch
            {
                Console.WriteLine("Please run again and enter a number.");
            }

            Console.Read();

        }
    }
}
