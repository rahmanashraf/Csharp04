using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp05
{
    class StudentCsharp04
    {
        public string Name;
        public string Surname;

        public StudentCsharp04(string nm,string srname)
        {
            Name = nm;
            Surname = srname;
        }

        public static void Write()  //return 
        {
            Console.WriteLine("staticccc");
        }

        public void GetFullname() //return type yoxdur console.write
        {
            Console.WriteLine("staticcc olmayan");
        }

    }
}
