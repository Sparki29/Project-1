using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 1;

            while (a <= 10)
            {
                int b = 1; //need to declare b inside the loop else a nother conter is needed (ex. int c = 1;)

                while (b <= 10)
                {
                    Console.WriteLine("{0} x {1} = {2}", a, b, a * b); // text in "{}" is considered as a placeholder
                                                                       //and the vallue of the numbers after 
                                                                       //is assigned to the corresponding placeholders
                    
                    b++;
                    
                }

                a++;
                
            }
            Console.ReadLine();
        }
    }
}
