using System;
using System.Collections;

namespace Csharp04
{
    class Program
    {
        static void Main(string[] args)
        {
            const float pi= 3.14F;
           
            char x = '/';
            string soz = "sfsfsdf";
            byte z = 255;

            float fl = 5F / 3;
            //decimal d = Convert.ToDecimal(fl);
            //decimal x2 = Math.Round(d, 5);
            double db = 5D / 3;
            decimal dec = 5M / 3;

            //Console.WriteLine(x2);
            //Console.WriteLine(fl);
            //Console.WriteLine(db);
            //Console.WriteLine(dec);
            //long y = 9999999999999;
            int j = 5;
            int g = j;
            //Console.WriteLine(j);
            //Console.WriteLine(g);
            //j = 6;
            //Console.WriteLine(j);
            //Console.WriteLine(g);

            //Student st1 = new Student();
            //st1.Name = "Mina";
            //Student st2 = new Student();
            //st2 = st1; ;
            //Console.WriteLine(st1.Name);
            //Console.WriteLine(st2.Name);
            //st1.Name = "Veli";
            //Console.WriteLine(st1.Name);
            //Console.WriteLine(st2.Name);

            //string a = "gvhj";
            //string b = a;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //a = "aaaa";
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //ArrayList array = new ArrayList { 5, 6, 9, 8 ,"SDcfsdF"};
            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}
            //for(; ;)
            //{
            //    Console.WriteLine("Sonsuzzz");
            //}

            //while (true)
            //{
            //    Console.WriteLine("Sonsuzzz");

            //}

            int x2 = 2;
            if (x2>6)
            {
                Console.WriteLine("7>6");
            }
            else if (x2 < 3)
            {
                Console.WriteLine("x2<3");
            }
            else
            {
                Console.WriteLine("boyuk deyil");
            }


        }
    }

    class Student
    {
        public string Name { get; set; }
    }
}
