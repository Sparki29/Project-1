using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose an option:");

                Console.WriteLine("1. Option 1");

                Console.WriteLine("2. Option 2");

                Console.WriteLine("3. Option 3");

                Console.WriteLine("4. Exit");

                int chooseOption = int.Parse(Console.ReadLine());

                Console.WriteLine("You chose option {0}", chooseOption);

                if (chooseOption >= 4)
                {
                    break;
                }

            }
        }
    }
}
