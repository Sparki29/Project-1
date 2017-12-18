using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Student : Person
    {
        public string studentNumber { get; set; }
        public int age { get; set; }
        public int scores { get; set; }
        public string averageScores { get; set; }
        public string fullAddress { get; set; }
        public string fullName { get; set; }
        public override string ToString()
        {
            return "Student " + fullName + " score is " + averageScores + ".";
        }
    }
}
