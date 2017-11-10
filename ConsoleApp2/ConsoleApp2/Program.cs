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
            bool isInputValid = true;

            Console.Write("Please enter the first number: ");

            float firstNumber = 0;

            //if (!float.TryParse(Console.ReadLine(), out firstNumber))
            //{
            //    Console.WriteLine("First Number is not number.");

            //    isInputValid = false;
            //}

            try
            {
                firstNumber = float.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("First number is not number.");
            }

            Console.Write("Please enter the second number: ");

            float secondNumber = 0;

            //if (!float.TryParse(Console.ReadLine(), out secondNumber))
            //{
            //    Console.WriteLine("Second number is not number.");

            //    isInputValid = false;
            //}

            try
            {
                secondNumber = float.Parse(Console.ReadLine());

            }
            catch
            {
                Console.WriteLine("Second number is not number.");
            }

            if (isInputValid)
            {

                Console.WriteLine("Please choose an operation:");

                Console.WriteLine("1 for +");

                Console.WriteLine("2 for -");

                Console.WriteLine("3 for *");

                Console.WriteLine("4 for /");

                Console.Write("Your choice is: ");

                try
                {

                    string operation = Console.ReadLine(); //string operation = Console.ReadKey(); Console.WriteLine();
                    
                    double result = 0;

                    //string operationAsString = "";

                    if (operation == "1")
                    {
                        result = firstNumber + secondNumber;

                        //operationAsString = "+"; wrong cause ConsoleKey.Add;
                    }
                    if (operation == "2")
                    {
                        result = firstNumber - secondNumber;

                        //operationAsString = "-"; wrong cause ConsoleKey.Subtract;
                    }
                    if (operation == "3")
                    {
                        result = firstNumber * secondNumber;

                        //operationAsString = "*"; wrong cause ConsoleKey.Multiply;
                    }
                    if (operation == "4")
                    {
                        result = firstNumber / secondNumber;

                        //operationAsString = "/"; wrong cause ConsoleKey.Divide;
                    }

                    Console.Write("The result is: ");

                    Console.WriteLine(result);

                }

                catch
                {
                    Console.WriteLine("Something went wrong. Start program again.");
                }
            }

            Console.ReadLine();

        }
    }
}
