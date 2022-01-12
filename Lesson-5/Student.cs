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

        public Student(string name,string surnm)
        {
            Name = name;
            Surname = surnm;
          
        }

        public  void Fullname()
        {
            Console.WriteLine(Name + " " + Surname);
        }
    }
}
