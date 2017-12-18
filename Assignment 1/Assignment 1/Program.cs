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
            //- Student {FullName} score is {AverageScore} student
            //-	Student {FullName} is living in {City} address
            //-	Student {FullName} address is {FullAddress} student
            //-	Please override the ToString() method to display detailed information about student.

            Student student = new Student(); //{ firstName = Console.ReadLine(), lastName = Console.ReadLine() };
            Console.Write("Enter first name: ");
            student.firstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            student.lastName = Console.ReadLine();
            Console.Write("Enter student number: ");
            student.studentNumber = Console.ReadLine();
            Console.Write("Enter student age: ");
            student.age = Convert.ToInt32(Console.ReadLine());
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
            //int numberOfScores = Convert.ToInt32(Console.ReadLine());
            //Scores(score1: Convert.ToInt32(Console.ReadLine()),
            //score2: Convert.ToInt32(Console.ReadLine()),
            //score3: Convert.ToInt32(Console.ReadLine()),
            //score4: Convert.ToInt32(Console.ReadLine()));

            //Scores(Convert.ToInt32(student.scores));

            //student.score.Add(Scores(Convert.ToInt32(student.scores)));

            Console.WriteLine("Enter how many scores the student has: ");
            student.scores = Convert.ToInt32(Console.ReadLine());

            List<int> listOfScores = new List<int>();

            for (int i = 0; i < student.scores; i++)
            {
                Console.Write("Enter score : ");
                listOfScores.Add(Convert.ToInt32(Console.ReadLine()));
            }
            student.averageScores = Convert.ToString(listOfScores.Average());

            //Console.WriteLine(FullAddress(address.address, address.street, address.city, address.country));

            student.fullAddress = FullAddress(address.address, address.street, address.city, address.country);

            student.fullName = student.firstName +" "+ student.lastName;

            address.fullName = student.fullName;

            address.fullAddress = student.fullAddress;

            Console.Clear();

            Console.WriteLine(student);

            Console.WriteLine(address);

            Console.ReadLine();
            
        }

        //static Student CreateStudent(string FirstName, string LastName, string StudentNumber)
        //{
        //  return new Student()
        //{
        //  firstName = FirstName,
        //lastName = LastName,
        //studentNumber = StudentNumber
        //};
        //}

        //static int Scores(int scores)
        //{
            //Console.Write("Enter score : ");
            //int score1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter score 2: ");
            //int score2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter score 3: ");
            //int score3 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter score 4: ");
            //int score4 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter how many scores the student has: ");
            //scores = Convert.ToInt32(Console.ReadLine());

            //List<int> list = new List<int>();

                //for (int i = 0; i < scores; i++)
                //{
                    //Console.Write("Enter score : ");
                    //list.Add(Convert.ToInt32(Console.ReadLine()));
                //}
            //return Convert.ToInt32(list.Average().ToString()); //Does not work.
        //}
        
        static string FullAddress(string address, string street, string city, string country)
        {
            return address + " " + street + " " + city + " " + country;
        }
        
        
    }

    class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
    }

    

    class Student : Person
    {
        
        public string studentNumber { get; set; }
        public int age { get; set; }

        public List<int> score = new List<int>();
        
        public int scores { get; set; }
        public string averageScores { get; set; } // method?

        public override string ToString()
        {
            return "Student " + fullName + " score is " + averageScores + ".";
        }

        public string fullAddress { get; set; } // method?
        public string fullName { get; set; } // method?

        
    }

    class Address : Student
    {
        public string address { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string country { get; set; }

        public override string ToString()
        {
            return "Student " + fullName + " is living in " + city + "." + "\r\n"
                + "Student " + fullName + " address is " + fullAddress + ".";
        }
    }
    
}
