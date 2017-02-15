using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo05
{
    class Student
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string StudentID { get; set; }

        public override string ToString()
        {
            return Firstname + " " + Lastname + " " + SocialSecurityNumber + " " + StudentID;
        }
    }
}
