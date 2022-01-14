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

            Student student = new Student();
            //student.Fullname();
            //Console.WriteLine(student.No);

            Student student2 = new Student("Mina", "Qizilsiz");

            //student2.Fullname();
            //Console.WriteLine(student2.No);


            //Test.WriteMessage();

            //Test2 test2 = new Test2();
            //test2.CalcTest2();
            //Console.WriteLine(Math.Max(20, 6));

            Product product = new Product("Kitkat", 2.20, 5, 30);
            Product product2 = new Product("Snikers", 0.90, 10, 50);

            product.Buy(5);
            Console.WriteLine(product.NewPrice);
            Console.WriteLine(product.TotalPrice);
        }


    }
    public  class Test2
    {
        public string Name { get; set; }
        public  void CalcTest2()
        {
            Console.WriteLine("Static methoddur");
        }
    }


    //static classin obyekti yaradilmir
    public static class Test
    {
        //static uzvler verilmir
        public static string Name { get; set; }

        public static int CalcTest()
        {
            return 5;
        }

        public static void WriteMessage()
        {
            Console.WriteLine("Hello");
        }
    }
}
