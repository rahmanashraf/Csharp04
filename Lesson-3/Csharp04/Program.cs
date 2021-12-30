using System;
using System.Collections;

namespace Csharp04
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ev tapsirigi
            //Console.WriteLine("Bir eded daxil et");
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(x + " before");
            //Console.WriteLine(ChangeNumber(ref x) +"cem");
            //Console.WriteLine(x + " after"); //180

            //int y = 10;
            //Console.WriteLine(y + " before");
            //Test(ref y);
            //Console.WriteLine(y + " after");
            #endregion

            #region String methods
            //String methods
            //ToUpper(); SDVDFVDFV
            //ToLower(); sdgvfdvd
            //Trim();
            //Contains
            //Substring();
            //Split()
            //Reverse
            //Replace();
            //IndexOf VS LastIndexOf
            //IsNullOrEmpty
            //ToCharArray()

            //string cumle = "My name is Mina";
            //char[] arrayCumle= cumle.ToCharArray();

            //string yenicumle=cumle.ToUpper();
            //string soz = "mina".ToUpper() ;
            //Console.WriteLine(yenicumle.Contains(soz));

            //char m = 'm';
            //char M = 'M';
            //Console.WriteLine(m==M);
            //Console.WriteLine(cumle.Substring(3,4));

            //string[] splitedWord = cumle.Split(' ');
            //Console.WriteLine(cumle.Replace("Mina","Ravi"));

            //string hello = "Hello world";
            //int nomre= hello.IndexOf('l'); //2
            //int nomre2= hello.LastIndexOf('l'); //9
            //Console.WriteLine(nomre);
            //Console.WriteLine(nomre2);

            //string userName = "     ";
            //Console.WriteLine(String.IsNullOrEmpty(userName));
            //Console.WriteLine(String.IsNullOrWhiteSpace(userName)); ;
            #endregion

            #region Array
            //1
            int[] numbers = new int[5]; //size 5 olacaq
            numbers[0] = 5;
            numbers[1] = 55;
            numbers[2] = 96;
            numbers[3] = 63;
            numbers[4] = 70;
            
            //numbers[5] = 93;
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}
            //2
            int[] nums = new int[5] { 2,23,6,9,8};
            //3
            int[] number = { 2, 3, 5, 6, 9 };  ///en cox bu istf edilir
            //number[5] = 75; //6ci element
            //foreach (var item in number)
            //{
            //    Console.WriteLine(item);
            //}
            string[] students = { "Ravi", "Aysel", "Elmar", "Nurlan" }; //4

            Array.Reverse(students);

            //Console.WriteLine(students[3]);

            //for (int i = 0; i < students.Length; i++)
            //{
            //    Console.WriteLine(students[i]);
            //}
            //foreach (var item in students)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(MyReverse("papaq")); ;

            //for (int i = 10; i> -1; i--)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            Calculate(2,3,4);
        }

        //Method overloading-parametr sayi ve return type a gore ferqlenen

        public static double Calculate(double x, double y)
        {
            return x * y;
        }
        public static int Calculate(int x, int y)
        {
            return x * y;
        }

        public static string Calculate(string x, string y)
        {
            return x + y; //ana+ata=anaata
        }

        public static int Calculate(int x, int y,int z)
        {
            return x * y * z;
        }


        #region Array
        //public static string MyReverse(string input)
        //{
        //    char[] charArray = input.ToCharArray();
        //    string reversedString = "";

        //    for (int i = charArray.Length-1; i >-1; i--)
        //    {
        //        reversedString += charArray[i];

        //    }
        //    return reversedString;
        //}
        #endregion

        #region EV tapsirigi

        //public static int Test(ref int input)
        //{
        //    input = 25;
        //    return input;
        //}


        public static int ChangeNumber(ref int input)
        {
            int result = 0;
            int sum = 0;
            for (int i = 1; i < 9; i++)
            {
                result = i * input;  //2*5=10 ; 3*5=15
                sum += result; //10+15
            }
            input = sum;
            return sum;
        }

        public static int ChangeNumber2(out int input)
        {
            input = 5;
            return input;
        }

        #endregion
    }

}
