using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = "";

            char[] Dobromir = Console.ReadLine().ToCharArray();

            foreach (char a in Dobromir)
            {
                if (a == 'A'|| a == 'B'|| a == 'C')
                {
                 result = result + '2';
                }
                if (b == 'D'|| b =='E'|| b == 'F')
                {
                    result = result + '3';   //Not finished need to find out how to make the rest of the alphabet
                    //with different string in the same foreach()
                }
            }

            Console.ReadLine();
        }
    }
}
