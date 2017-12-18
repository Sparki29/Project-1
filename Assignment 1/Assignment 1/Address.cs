using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
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
