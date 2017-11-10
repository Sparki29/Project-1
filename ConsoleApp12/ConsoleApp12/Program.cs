using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myElement = new string[3];

            myElement[0] = Console.ReadLine();

            myElement[1] = Console.ReadLine();

            myElement[2] = Console.ReadLine();

            for(int counter = 0; counter < 3; counter++)
            {
                Console.WriteLine(myElement[counter]);
            }

            Console.ReadLine();
        }
    }
}
