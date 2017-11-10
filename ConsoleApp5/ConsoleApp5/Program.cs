using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a max number (0 for exit): ");

            int maxNumber = int.Parse(Console.ReadLine());
            
            int counter = 1;

            while(counter < maxNumber)
            {
                Console.WriteLine(counter);

                counter = counter + 2;

                Console.ReadLine();

                if (maxNumber == 0)
                {
                    break;
                }
            }

        }
    }
}
