using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp05
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Reference vs value
            //Reference
            //int[] x = { 5, 4, 3, 2 };
            //int[] x2 = x;
            //Console.WriteLine(x[0]);
            //Console.WriteLine(x2[0]);
            //x[0] = 115;
            //Console.WriteLine(x[0]);
            //Console.WriteLine(x2[0]);

            //int a = 5;
            //int b = a;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //a = 200;
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //Console.WriteLine(a);
            //Deyis(ref a);
            //Console.WriteLine(a);

            //byte d = 5;
            //int h = d;

            //int k = 15000;
            //byte p = (byte)k;
            //Fullname("Ravi", "XXX");

            //int a = 5;
            //int b = 4;
            //a = a + b;
            //b = a - b;
            //a = a - b;
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //a=4
            //b=5
            #endregion

            //Student student = new Student("Mina","Farzali");
            //student.Point = 50.7;
            //student.Fullname();

            //Student student1 = new Student("Vesile","Vesi");
            //student1.Point = 60;

            #region Student class
            //Student[] students = new Student[2];
            ////int[] xxx = new int[5];
            //for (int i = 0; i < students.Length; i++)
            //{
            //    Console.WriteLine("Adi daxil et");
            //    string name = Console.ReadLine();

            //    Console.WriteLine("Soyadin daxil et");
            //    string surname = Console.ReadLine();

            //    Console.WriteLine("Bali daxil et");
            //    double point = Convert.ToDouble(Console.ReadLine());

            //    Student student = new Student(name, surname); //instance almaq ,obyektini yaratmaq
            //    student.Point = point;

            //    students[i] = student;
            //}

            //foreach (var item in students)
            //{
            //    Console.WriteLine(item.Name + " " + item.Surname);
            //}


            //Console.WriteLine(CalculateStudentAvg(students) + " ortalama bal");
            #endregion

            //string soz = "Salam Rehman";
            //string soz2 = soz;
            //Console.WriteLine(soz);
            //Console.WriteLine(soz2);

            //soz = "Sagol Rehman";
            //Console.WriteLine(soz);
            //Console.WriteLine(soz2);

            string testString = "Hello!";
            testString = testString + " This";   //teststring=hello+this
            testString = testString + " is";
            testString = testString + " c#";
            testString = testString + " tutorial";
            //Console.WriteLine(testString);


            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Hello!");

            StringBuilder x = stringBuilder;
            Console.WriteLine(x);
            Console.WriteLine(stringBuilder);
            stringBuilder.Append("dfcsdfsd");

            Console.WriteLine(x);
            Console.WriteLine(stringBuilder);
        }

        public static double CalculateStudentAvg(Student[] list)
        {
            double sum = 0;
            foreach (var item in list)
            {
                sum += item.Point;
            }

            return sum / list.Length;
        }

        //public static void Fullname(string name, string surname)
        //{
        //    Console.WriteLine(name + " " + surname);
        //}


    }

}
