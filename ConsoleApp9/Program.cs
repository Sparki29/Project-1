using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter X: ");

            int X = int.Parse(Console.ReadLine());

            Console.Write("Please enter Y: ");

            int Y = int.Parse(Console.ReadLine());

            if (X < Y)
            {
                for (int i = X; i <= Y; i++)
                {
                    Console.WriteLine(i);
                    
                }
            }
            else
            {
                for (int i = X; i >= Y; i++)
                {
                    Console.WriteLine(i);
                    
                }
            }

            Console.ReadLine();
        }
    }
}
