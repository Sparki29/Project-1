using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please eneter a number: ");

                float amount = float.Parse(Console.ReadLine());

                Console.WriteLine();

                if (amount > 100000)
                {
                    Console.WriteLine("You can buy a plane.");
                }
                else if (amount > 10000)
                {
                    Console.WriteLine("You can buy a car.");
                }
                else if (amount > 10)
                {
                    Console.WriteLine("You can take the bus.");
                }
                else
                {
                    Console.WriteLine("You're too poor to do anything.");
                }
            }
            catch
            {
                Console.WriteLine("Something went wrong. Try again.");
            }

            Console.ReadLine();

        }
    }
}
