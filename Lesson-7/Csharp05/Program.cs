using System;
using System.Collections;
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
            //Console.WriteLine("Ad daxil et");
            //string name = Console.ReadLine();

            //Console.WriteLine("Soyad daxil et");
            //string surname = Console.ReadLine();

            //StudentCsharp04 student = new StudentCsharp04(name, surname);
            //StudentCsharp04 student = new StudentCsharp04("Mina", "Farzali");
            //student.GetFullname();
            //StudentCsharp04.Write();
            //Console.WriteLine(student.Name);

            int[] a = new int[5];
            a[0] = 5;
            a[1] = 6;
            a[2] = 3;

            //ARRAYLIST-tipi olmur=>boxing unboxinge cixir , olcusu olmur
            ArrayList arrayList = new ArrayList();
            arrayList.Add(5);
            arrayList.Add(5);
            arrayList.Add(true);

            StudentCsharp04 student = new StudentCsharp04("Mina", "F");

            arrayList.Add(student);

            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            //if (arrayList[0] is int)
            //{
            //    int a1 = (int)arrayList[1];
            //    Console.WriteLine(a1);
            //}
            arrayList.Remove(5);
            //arrayList.RemoveAt(2);

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            arrayList.AddRange(a);
        }


    }


}
