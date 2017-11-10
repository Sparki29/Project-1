using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Please enter a maximum number (0 for exit): ");

            int maxNumber = int.Parse(Console.ReadLine());

            int counter = 0;

            while (counter <= maxNumber)
            {
                Console.WriteLine(counter);

                counter++;

                Console.ReadLine();

                if (maxNumber == 0)
                {
                    break;
                }
            }
        }
    }







}
