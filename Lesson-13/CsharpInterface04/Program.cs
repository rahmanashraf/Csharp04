using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpInterface04
{
    class Program
    {
        static void Main(string[] args)
        {
            //MySql mySql = new MySql();

            //FileLog fileLog = new FileLog();
            //fileLog.Write("Eli Eliyev Maaslar/Bugunun maaslari");


            //ConsoleLog consoleLog = new ConsoleLog();
            //consoleLog.Write("Eli Eliyev Maaslar/Bugunun maaslari");



        }
    }

    interface Test
    {
        public void Tested()
        {
            Console.WriteLine("for testing");
        }
    }



    #region Ilog
    interface ILog
    {
        void Write(string action);
    }

    class ConsoleLog : ILog
    {
        public void Write(string action)
        {
            Console.WriteLine(DateTime.Now.ToString("dd.MM.yyyy HH:mm") +""+ action);
        }
    }

    class Database : ILog
    {
        public void Write(string action)
        {
            //connection qururuq
            //database -e save edirsen datani

        }
    }

    class FileLog : ILog
    {
        public void Write(string action)
        {
            string text = DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "" + action;
            using (StreamWriter file = File.AppendText(@"C:\Users\Mina\source\repos\CsharpInterface04\test.txt"))
            {
                file.WriteLine(text);
            }
        }
    }
    #endregion

    #region Interface explain
    interface IDatabase
    {
        string Name { get; set; }
      
        void Add(string table, string connection);
        void Delete(string table, string connection);
        void Update(string table, string connection);
        void Select(string table, string connection);
    }
    interface IProcedures
    {
         void Logger(string name);
         void Logger2(string name);
    
    }

    abstract class X
    {
        public string XName { get; set; }

        public abstract void X1(string table, string connection);
        public abstract void X2(string table, string connection);
        public abstract void X3(string table, string connection);
        public abstract void X4(string table, string connection);

        public virtual void Greet()
        {
            Console.WriteLine("Hello world");
        }
    }

    class MySql :X, IDatabase, IProcedures
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Add(string table, string connection)
        {
           //some amazing code
        }

        public void Delete(string table, string connection)
        {
            //some amazing code

        }

        public void Logger(string name)
        {
            throw new NotImplementedException();
        }

        public void Logger2(string name)
        {
            throw new NotImplementedException();
        }

        public void Select(string table, string connection)
        {
            //some amazing code

        }

        public void Update(string table, string connection)
        {
            //some amazing code

        }

        public override void X1(string table, string connection)
        {
            throw new NotImplementedException();
        }

        public override void X2(string table, string connection)
        {
            throw new NotImplementedException();
        }

        public override void X3(string table, string connection)
        {
            throw new NotImplementedException();
        }

        public override void X4(string table, string connection)
        {
            throw new NotImplementedException();
        }
    }
    #endregion
}
