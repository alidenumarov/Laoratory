using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass
{
    class Student
    {
        public string name;
        public string surname;
        public double gpa;

        public Student(string s1, string s2, double d1)
        {
            this.name = s1;
            this.surname = s2;
            this.gpa = d1;
        }

        public override string ToString()
        {
             return this.name + " " + this.surname + " " + this.gpa;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student me = new Student("Aliden", "Umarov", 4.0);
            Console.WriteLine(me);
            Console.ReadKey();
        }
    }
}
