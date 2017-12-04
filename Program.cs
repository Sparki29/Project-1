using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    class Program
    {
        static void Main(string[] args)
        {
            //- Student {FullName} score is {AverageScore}
            //-	Student {FullName} is living in {City}
            //-	Student {FullName} address is {FullAddress}
            //-	Please override the ToString() method to display detailed information about student.

            
        }

        static Student CreateStudent(string FirstName, string LastName, string StudentNumber)
        {
            return new Student()
            {
                firstName = FirstName,
                lastName = LastName,
                studentNumber = StudentNumber
            };
        }
    }

    class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
    }

    class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string studentNumber { get; set; }
        public int age { get; set; }
        public string address { get; set; }
        public string scores { get; set; }
        public string averageScores; // method?
        public string fullAddress; // method?
        public string fullName; // method?
    }
    
    class Address
    {
        public string address { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string country { get; set; }
    }
}
