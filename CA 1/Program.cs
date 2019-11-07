using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Subject subject1 = new Subject("OOP", "Keith McManus", 2);
            Subject subject2 = new Subject("DataBase", "colm davey", 2);
            Subject subject3 = new Subject("UX Design", "Adrian Durcan", 2);
            Subject subject4 = new Subject("Web design", "Kevin Peyton", 2);

            List<Subject> AllSubject = new List<Subject>();

            AllSubject.Add(subject1);
            AllSubject.Add(subject2);
            AllSubject.Add(subject3);
            AllSubject.Add(subject4);



            Student student1 = new Student("James Bishop", "22/11/1997");
            Student student2 = new Student("Joe Smith", "21/10/2000");



            display(AllSubject);


        }
        private static void display(List<Subject> subjects)
        {
            foreach (Subject subject in subjects)
            {
                Console.WriteLine("{0,-10} {1,-10} {2,-10}", subject.Name, subject.Lecturer, subject.Year);

            }
            Console.WriteLine();
        }

    }
}
