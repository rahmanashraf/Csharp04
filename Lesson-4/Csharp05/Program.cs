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
            #region Params
            //int[] array = { 5, 6, 9, 8 };
            //UseSimpleMethod(5,array);
            //UseParams2(2, 36, 9, 8, 6);
            //UseParams3(3, 5, 9, 8, 7, 3, 6, 5,10,11,12);
            #endregion

            //try
            //{

            //    Console.WriteLine(DivideNumber(20, 0));
            //}
            //catch (Exception mina)
            //{
            //    Console.WriteLine(mina);
            //}
            //finally
            //{
            //    Console.WriteLine("Hemise icra olunur");
            //}

            Car car1 = new Car();
            car1.Marka = "Ford";
            car1.Color = "Red";
            car1.Year = DateTime.Today;
            car1.Print();

            Car carr3 = new Car
            {
                Name = "Xxx",
                Color = "ddcfdcf",
                Year = DateTime.Today,
                Marka = "Dsfvsdf"
                
            };
            carr3.Print();

            Car car2 = new Car();
            car2.Name = "Prius";
            car2.Marka = "Toyoto";
            car2.Color = "Blue";
            car2.Year = DateTime.Today;
            car2.Print();
        }
        
        #region Params
        public static void UseSimpleMethod(int a, int[] list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        public static void UseParams2(params int[] list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        public static void UseParams3(int index, int last, params int[] list)
        {
            for (int i = index; i < last; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
        // 0  1  2  3  4  5  6  7  8
        //[9, 8, 7, 3, 6, 5,10,11,12]
        #endregion

        public static int DivideNumber(int num1, int num2)
        {
            return num1 / num2;
        }
       
    }

    public class Car
    {
        public string Name="Alman";
        public string Marka;
        public string Color;
        public DateTime Year; 

        public void Print()
        {
            Console.WriteLine(Name+" "+Marka+" "+Color+" "+Marka);
        }
    }
}
