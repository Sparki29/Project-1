using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number :");

            Console.WriteLine("Please enter the second number :");

            Console.WriteLine("Please choose and operation :");

            Console.WriteLine("1 for +");

            Console.WriteLine("2 for -");

            Console.WriteLine("3 for *");

            Console.WriteLine("4 for /");

            Console.Write("Your choice is ");

            string operation = Console.ReadLine();

            int result = 0;

            string operationAsString = "";

            if (operation == "1")
                {
                result = firstNumber + secondNumber;

                operationAsString = "+";
                }
            if (operation == "2")
                {
                result = firstNumber - secondNumber;

                operationAsString = "-";
                }
            if (operation == "3")
                {
                result = firstNumber * secondNumber;

                operationAsString = "*";
                }
            if (operation == "4")
                {
                result = firstNumber / secondNumber;

                operationAsString = "/";
                }
        }
    }
}
