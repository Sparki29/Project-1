using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Please enter a number: ");

                int firstNumber = int.Parse(Console.ReadLine());

                Console.Write("Please enter a second number: ");

                int secondNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Please choose an operation: ");

                Console.Write("Your choice is: ");

                string operation = Console.ReadLine();

                double result = 0;

                if (operation == "1")
                {
                    result = firstNumber + secondNumber;
                }
                if (operation == "2")
                {
                    result = firstNumber - secondNumber;
                }
                if (operation == "3")
                {
                    result = firstNumber * secondNumber;
                }
                if (operation == "4")
                {
                    result = firstNumber / secondNumber;
                }
                if (operation == "5")
                {
                    result = secondNumber + firstNumber;
                }
                if (operation == "6")
                {
                    result = secondNumber - secondNumber;
                }
                if (operation == "7")
                {
                    result = secondNumber * firstNumber;
                }
                if (operation == "8")
                {
                    result = secondNumber / firstNumber;
                }

                Console.Write("The result is: ");

                Console.WriteLine(result);
            }

            //Program not finished need to use classes to assign the operations

            Console.ReadLine();
        }
    }
}
