using System;
using System.Collections.Generic;

namespace LambdaAndDelegate
{
    internal class Program
    {
        public  delegate int  DelFoo(int x);
        public delegate bool Filter(int x);
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 23, 34, 67, 23, 12, 67 };


            void filterFunc(List<int> lst,Filter condition)
            {
                for (int i = 0; i < lst.Count; i++)
                {
                    if (condition(lst[i]))
                    {
                        Console.WriteLine(lst[i]);
                    }
                }
            }

            filterFunc(numbers,x => x >30 && x%2==0);

            numbers.Find

           

            


        }
       

        
    }
}
