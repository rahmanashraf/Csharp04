using Csharp05;
using System;
using System.Collections;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        #region Dictionary
        //PhoneBook bestFriend = new PhoneBook();
        //bestFriend.AddPerson("Mina", "0559288755");
        //bestFriend.AddPerson("Rehi", "0552000001");
        //bestFriend.AddPerson("Vesi", "0552200001");
        //bestFriend.AddPerson("Aysel", "9552000001");
        //bestFriend.AddPerson("Mina", "0513009966");
        //bestFriend.GetNamebyNumber("0513009966");
        //bestFriend.GetNumberByName("Rehi");
        //bestFriend.RemoveByNumber("9552000001");

        //bestFriend.List();
        #endregion

        //AStruct aStruct=new AStruct(3,4);
        //AStruct aStruct2= aStruct;

        //Console.WriteLine(aStruct.X);
        //Console.WriteLine(aStruct2.X);
        //aStruct.X = 100;

        //Console.WriteLine(aStruct.X);
        //Console.WriteLine(aStruct2.X);

        AClass aClass=new AClass(5,6);
        AClass aClass1 = aClass;
        Console.WriteLine(aClass.X);
        Console.WriteLine(aClass1.X);
        aClass.X = 80;
        Console.WriteLine(aClass.X);
        Console.WriteLine(aClass1.X);
    }

}

public struct AStruct
{
    public int X,Y;
    public AStruct(int x,int y)
    {
        X = x;
        Y = y;
    }

}

public class AClass
{
    public int X,Y;
    public AClass(int x,int y)
    {
        X = x;
        Y = y;
    }
}


#region Dictionary
class PhoneBook
{
    private Dictionary<string, string> _phonebook;
    public PhoneBook()
    {
        _phonebook = new Dictionary<string, string>();
    }
    public void AddPerson(string name, string number)
    {
        if (_phonebook.ContainsKey(name))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{name} is exist");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Select one of the option \n 1.Keep the number \n 2.Update the number");
            string option = Console.ReadLine();
            while (option != "1" && option != "2")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please select valid option");
                Console.ForegroundColor = ConsoleColor.White;
                option = Console.ReadLine();
            }
            if (option == "2")
            {
                //var Oldnum = _phonebook[name];
                _phonebook[name] = number;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Succesfully updated");
                Console.ForegroundColor = ConsoleColor.White;

            }

        }
        else
        {
            _phonebook.Add(name, number);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{name} with {number} added");
            Console.ForegroundColor = ConsoleColor.White;
        }


    }
    public void GetNumberByName(string name)
    {
        if (_phonebook.ContainsKey(name))
        {
            Console.WriteLine($"{_phonebook[name]} is exist");
            //Console.WriteLine(_phonebook[name]+" is exist");
        }
        else
        {
            Console.WriteLine("No one");
        }
    }
    public void GetNamebyNumber(string number)
    {
        if (_phonebook.ContainsValue(number) /*&& number.Length<9*/)
        {
            foreach (var item in _phonebook.Keys)
            {
                if (_phonebook[item] == number)
                {
                    Console.WriteLine($"{item}");
                }

            }
        }
    }
    public void RemoveByName(string name)
    {
        if (_phonebook.ContainsKey(name))
        {
            _phonebook.Remove(name);

            Console.WriteLine(name + " is deleted");
        }
        else
        {
            Console.WriteLine("this person is not exist");
        }
    }
    public void RemoveByNumber(string number)
    {
        if (_phonebook.ContainsValue(number))
        {
            foreach (var item in _phonebook.Keys)
            {
                if (_phonebook[item] == number)
                {
                    _phonebook.Remove(item);
                    break;
                }
            }
        }
        else
        {
            Console.WriteLine("this person is not exist");
        }
    }
    public void List()
    {
        Console.WriteLine("All people");
        foreach (var item in _phonebook.Keys)
        {
            Console.WriteLine(item + " and his/her " + _phonebook[item]);
        }
    }
}

#endregion