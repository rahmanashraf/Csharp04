using Csharp05;
using System;
using System.Collections;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        #region non-generic collection 
        ArrayList arrayList = new ArrayList();
        arrayList.Add("dscsdcs");
        arrayList.Add(5);


        int[] arr = { 2, 3, 5 };
        //foreach (var item in arr)
        //{
        //    Console.WriteLine(item);
        //}

        //Lifo 
        //Stack stack = new Stack();
        //stack.Push(2); //add edirsen
        //stack.Push("Dsfsd");
        //stack.Push(true);
        //stack.Push(12);

        //foreach (var item in stack)
        //{
        //    Console.WriteLine(item);
        //}
        //Console.WriteLine(stack.Count);

        //Console.WriteLine(stack.Pop() + "remove");
        //Console.WriteLine(stack.Peek() + "PEEK"); //RETURN 
        //if (stack.Contains("Dsfsd2"))
        //{
        //    Console.WriteLine("var");
        //}
        //else
        //{
        //    Console.WriteLine("yoxdu");
        //}

        //FIFO
        //Queue queue = new Queue();
        //queue.Enqueue(1);
        //queue.Enqueue(2);
        //queue.Enqueue(1);
        //queue.Enqueue(4);

        //foreach (var item in queue)
        //{
        //    Console.WriteLine(item);
        //}
        //Console.WriteLine(queue.Dequeue() + "remove"); ;
        //Console.WriteLine(queue.Peek() + "PEEK"); //RETURN 
        //foreach (var item in queue)
        //{
        //    Console.WriteLine(item);
        //}

        //LIFO
        //Hashtable hashtable = new Hashtable();
        //hashtable.Add(1, "Ravis");
        //hashtable.Add(22, "Elmar");
        //hashtable.Add("salam", "Vesi");

        //foreach (DictionaryEntry item in hashtable)
        //{
        //    Console.WriteLine(item.Key + " " + item.Value);
        //}
        //hashtable.Remove(2);
        //foreach (DictionaryEntry item in hashtable)
        //{
        //    Console.WriteLine(item.Key + " " + item.Value);
        //}

        //SortedList numberNames = new SortedList();
        //numberNames.Add(3, "Three");
        //numberNames.Add(1, "One");
        //numberNames.Add(2, "Two");
        //numberNames.Add(4, null);
        //numberNames.Add(10, "Ten");
        //numberNames.Add(5, "Five");
        //Console.WriteLine(numberNames[6] +"6");
        //foreach (DictionaryEntry kvp in numberNames)
        //{
        //    Console.WriteLine("Key:{0}, Value:{1}", kvp.Key, kvp.Value);
        //}

        //task

        //Stack stack = new Stack();
        //stack.Push(15);
        //stack.Push(25);
        //stack.Push(35);

        //Queue queue = new Queue();
        //queue.Enqueue(85);
        //queue.Enqueue(95);
        //queue.Enqueue(75);

        //ArrayList array = new ArrayList();
        //array.Add(5);
        //array.Add(6);
        //array.Add(7);
        //array.AddRange(stack);
        //array.RemoveAt(5);
        //array.AddRange(queue);
        //Ravis=>5 6 7 35 25  85 95 75
        //Elmar=>5 6 7 35 25 15  85 95 75
        //Mina 5 6 7 35 25 85 95 75
        //foreach (var item in array)
        //{
        //    Console.WriteLine(item);
        //}


        #endregion

        #region generics

        //List<int> listed = new List<int>();
        //listed.Add(5);
        //listed.Add(15);
        //listed.Add(25);

        //List<int> listed2 = new List<int>();
        //listed2.Add(1000);
        //listed2.Add(1002);
        //listed2.Add(1003);

        //listed.AddRange(listed2);

        //foreach (var item in listed)
        //{
        //    Console.WriteLine(item);
        //}
        //listed.RemoveRange(0, 2);
        //foreach (var item in listed)
        //{
        //    Console.WriteLine(item + " new");
        //}

        //Stack<int> stck = new Stack<int>();
        //stck.Push(5);
        //stck.Push(15);
        //stck.Push(35);

        //Dictionary<string, string> pairs = new Dictionary<string, string>()
        //{
        //      {"UK", "London, Manchester, Birmingham"},
        //      {"USA", "Chicago, New York, Washington"},
        //      {"India", "Mumbai, New Delhi, Pune"}

        //};
        //pairs["UK"] = "Liverpool, Bristol";
        //pairs["USA"] = "Saatli, Bristol";

        //if (pairs.ContainsKey("UK"))
        //{
        //    Console.WriteLine(pairs["UK"]);
        //}
        #endregion

        Group group = new Group(GroupType.Programming, "Csharp04");

        Student student = new Student();
        student.Name = "Vesi";
        student.Surname = "sdfcsdcfs";

        Student student2 = new Student()
        {
            Name = "Vesi",
            Surname = "XXX"
        };

        group.AddStudent(student);
        group.AddStudent(student2);
        group.FindStudentByName("Vesi");

        Group group2 = new Group(GroupType.Design, "Design04");

        Student studen1 = new Student();
        studen1.Name = "XXXX";
        studen1.Surname = "sdfcsdcfs";

        Student studen2 = new Student()
        {
            Name = "RAvis",
            Surname = "XXX"
        };


        Student studen3 = new Student()
        {
            Name = "Elmar",
            Surname = "XXX"
        };

        group2.AddStudent(studen1);
        group2.AddStudent(studen2);
        group2.AddStudent(studen3);

        //foreach (var item in group.students)
        //{
        //    Console.WriteLine(item.Name + " " +item.Surname +" gr1");
        //}

        //foreach (var item in group2.students)
        //{
        //    Console.WriteLine(item.Name + " " + item.Surname + " gr2");
        //}
    }


}