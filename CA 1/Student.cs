using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_1
{
    class Student
    {
        public string Name { get; set; }

        public string DOB { get; set; }

        List<Subject> Subject = new List<Subject>();

        public Student (string name, string dob)
        {
            Name = name;
            DOB = dob;

        }

    }
}
