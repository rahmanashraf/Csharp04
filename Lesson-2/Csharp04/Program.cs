using System;
using System.Collections;

namespace Csharp04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Yasi daxil et");
            //int yas= Convert.ToInt32( Console.ReadLine());

            //Console.WriteLine(yas +"Yasi var");

            #region While,for,do while
            //int i = 1;
            //while (i<10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}


            //do
            //{ 
            //    i++;
            //    Console.WriteLine(i);

            //} while (i<5);


            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //    if (i>5)
            //    {
            //        break;
            //    }

            //} while (i<10);


            //for (int u = 0; u < 10; u++)
            //{
            //    if (u==5)
            //    {
            //        continue; //break
            //    }
            //    Console.WriteLine(u);

            //}

            //for in
            //for of
            //each
            //for
            #endregion

            #region Casting and boxing
            //casting-up ve down -value typelar
            byte a = 255;
            int b = a;

            int c = 5;
            byte h = (byte)c; //downcasting
            //Console.WriteLine(h);

            //boxing unboxing
            int k = 5;
            object obj = k;


            object x2 = 6; //unboxing

            if (x2 is int)
            {
                int x3 = (int)x2;
                //Console.WriteLine(x3);
            }

            #endregion

            #region Methods
            //GetFullName();
            //GetFullName2("Aysel"); 
            //GetFullName2("Ravi");

            //CalculateNumber(5, 6);

            //Console.WriteLine(CalculateNumber3(6, 8));

            ////int qiymet = CalculateNumber(5, 6) + 5;

            //int qiymet2 = X() + 5;
            //Console.WriteLine(qiymet2);
            //string soz = SetIdByName("Mina") + " Salam";
            //Console.WriteLine(soz);
            #endregion

            #region Calculator
            //Console.WriteLine("Enter the action to");
            //Console.WriteLine("1 Addition");
            //Console.WriteLine("2 Subraction");
            //Console.WriteLine("3 Multiplication");
            //Console.WriteLine("4 Division");

            //int action = Convert.ToInt32( Console.ReadLine());
            //Console.WriteLine("Enter 1st number");
            //int firstNumber= Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter 2nd number");
            //int secondNumber = Convert.ToInt32(Console.ReadLine());

            //int result = 0;

            //switch (action)
            //{
            //    case 1:
            //        {
            //            result = Addition(firstNumber, secondNumber);
            //            break;
            //        }
            //    case 2:
            //        {
            //            result = Subraction(firstNumber, secondNumber);
            //            break;
            //        }
            //    case 3:
            //        {
            //            result = Multiplication(firstNumber, secondNumber);
            //            break;
            //        }
            //    case 4:
            //        {
            //            result = Division(firstNumber, secondNumber);
            //            break;
            //        }
            //    default:
            //        Console.WriteLine("Wrong action! try again");
            //        break;
            //}

            //Console.WriteLine($"result {result}");
            #endregion

            
            int number = Convert.ToInt32( Console.ReadLine());

            //Console.WriteLine(number);
            ChangeNumber(ref number);
            //Console.WriteLine(number);
            Console.WriteLine(number);

            int number1;

            ChangeNumber2(out number1);
            //Console.WriteLine(number1);
        }

        static void ChangeNumber(ref int num)
        {
            //number=15
            num += 5;
        }

        static void ChangeNumber2(out int num)
        {
            //number=15
            num=5;
        }

      


        //static
        //access modifiers
        #region Methods
        public static void GetFullName()
        {
            Console.WriteLine("Menim adim Minadir");
        }

        
        public static void GetFullName2(string name) //parametr
        {
            //Console.WriteLine("Menim adim" + name);
            Console.WriteLine($"Menim adim {name}");
            //Console.WriteLine("Menim adim {0} {1}" ,name,surname);
        }

        public static void CalculateNumber(int x1,int x2)
        {
            Console.WriteLine($"{x1} * {x2} ={x1*x2}");
        }

        //return type olam
        //public static byte CalculateNumber2(byte x3, byte x4)
        //{
        //    byte result =Convert.ToByte( x3 * x4);
        //    return  result;
        //}

        public static int CalculateNumber3(int x3, int x4)
        {
            int result = x3 * x4;
            return result; //48
        }

        public static string SetIdByName(string name)
        {
            return name + "001";
        }

        public static int X()
        {
            return 5;
        }
        #endregion

        #region Calculator

        public static int Addition(int input1,int input2)
        {
            int result = input1 + input2;
            return result;
        }
        public static int Subraction(int input1, int input2)
        {
            int result = input1 - input2;
            return result;
        }

        public static int Multiplication(int input1, int input2)
        {
            int result = input1 * input2;
            return result;
        }

        public static int Division(int input1, int input2)
        {
            int result = input1 / input2;
            return result;
        }
        #endregion
    }

}
