using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Student student = new Student();
            Console.Write("Enter student first name: ");
            student.firstName = Console.ReadLine();
            Console.Write("Enter student last name: ");
            student.lastName = Console.ReadLine();
            Console.Write("Enter student number: ");
            student.studentNumber = Console.ReadLine();
            Console.Write("Enter student age: ");
            try
            {
                student.age = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid information given. Press any key to close program.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            Console.Write("Enter student address: ");

            Address address = new Address();
            address.address = Console.ReadLine();
            Console.Write("Enter street: ");
            address.street = Console.ReadLine();
            Console.Write("Enter city: ");
            address.city = Console.ReadLine();
            Console.Write("Enter country: ");
            address.country = Console.ReadLine();

            address.firstName = student.firstName;
            address.lastName = student.lastName;

            Console.Write("Enter how many scores the student has: ");
            try
            {
                student.scores = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid information given. Press any key to close program.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            List<int> listOfScores = new List<int>();

            for (int i = 0; i < student.scores; i++)
            {
                try
                {
                    Console.Write("Enter score : ");
                    listOfScores.Add(Convert.ToInt32(Console.ReadLine()));
                }
                catch
                {
                    Console.WriteLine("Invalid information given. Press any key to close program.");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }

            student.averageScores = Convert.ToString(listOfScores.Average());

            student.fullAddress = FullAddress(address.address, address.street, address.city, address.country);

            student.fullName = student.firstName +" "+ student.lastName;

            address.fullName = student.fullName;

            address.fullAddress = student.fullAddress;

            Console.Clear();

            Console.WriteLine(student);

            Console.WriteLine(address);

            Console.ReadKey();
            
        }
        
        static string FullAddress(string address, string street, string city, string country)
        {
            return address + " " + street + " " + city + " " + country;
        }
        
    }
    
}
