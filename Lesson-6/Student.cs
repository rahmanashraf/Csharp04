using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp05
{
    public class Student
    {
        public string Name;
        public string Surname;
        public double Point;
        public  int No = 0; 
        public static int Inc = 0;

        public Student(string name,string surnm)
        {
            Name = name;
            Surname = surnm;
            Inc++;
            No = Inc;
            Console.WriteLine("STATIC OLMAYAN CTOR");
        }
        public Student()
        {

        }

        static Student()
        {
            //Student[] students = new Student[5];
            Console.WriteLine("Static ctor");
        }

        public  void Fullname()
        {
            Console.WriteLine(Name + " " + Surname);
        }
    }
}
