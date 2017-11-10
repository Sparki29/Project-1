using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the secret number: ");

            int secretNumber = int.Parse(Console.ReadLine());

            Console.Clear();

            int numberOfTries = 1;

            while (true)
            {
                Console.Write("Guess the secret number: ");

                int guessNumber = int.Parse(Console.ReadLine());

                if (secretNumber == guessNumber)
                {
                    Console.WriteLine("You guessed the secret number!");

                    Console.WriteLine("Number of tries: {0}", numberOfTries);

                    break;
                }
                else
                {
                    numberOfTries++;

                    if (guessNumber < secretNumber)
                    {
                        
                        Console.WriteLine("The secret number is bigger than what you chose.");

                        Console.WriteLine("Number of tries {0}", numberOfTries);
                    }

                    else
                    {
                        
                        Console.WriteLine("The secret number is smaller than what you chose.");

                        Console.WriteLine("Number of tries {0}", numberOfTries);
                    }
                    
                }
            }

            Console.ReadLine();
        }
    }
}
