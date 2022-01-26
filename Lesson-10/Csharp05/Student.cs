using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp05
{
    public class Student
    {   
        public string Name="Mina";
        public string Surname;

        public  Student(string nm,string srn)
        {
            Name = nm;
            Surname = srn;
            Console.WriteLine("adi");
        }

        static Student()
        {
            Console.WriteLine("static ctor");
        }

        //public  Student(string nm)
        //{
        //    Name = nm;
        //}

        public void GetFullName()
        {
            Console.WriteLine(this.Name + " " +this.Surname);
            //Console.WriteLine($"{this.Name} {this.Surname}");
            //Console.WriteLine("ad: {1} ,soyad {2}", this.Name,this.Surname);
        }
        public static void Write()
        {
            Console.WriteLine("Staticcc");
        }
    }

    public static class Student2
    {
        public static void Write()
        {
            Console.WriteLine("Staticcc");
        }
    }
}
