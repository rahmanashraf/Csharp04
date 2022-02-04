using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mail;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        #region Inheritance

        //Woman veliska = new Woman("veliska",15,0);

        //Human human = new Human("Dvdfv",25);

        //Man man = new Man("Vali", 15, 1);
        //man.Surname = "RAvis";
        //man.getFullName();
        //man.Run();
        #endregion

        Student student = new Student();
        student.Email = "gdfvfd@gmail";
        Console.WriteLine(student.Email);

        CalcSquare calcSquare = new CalcSquare();
        calcSquare.x = 10;
        calcSquare.y = 6;
        calcSquare.Sahe = 500;
        calcSquare.Calc();
        Console.WriteLine(calcSquare.Sahe);
    }
}


class Student
{
    private string _email;

    public string Email
    {
        get { return _email; }
        set
        {
            try
            {
                MailAddress mailAddress = new MailAddress(value);
                _email = value;

            }
            catch (Exception)
            {

                throw new ArgumentException("eMAIL IS NOT VALID");
            }
        }

    }

}


class CalcSquare
{
    public int x { get; set; }
    public int y { get; set; }
    private int sahe;

    public int Sahe
    {
        get
        {
            return sahe;
        }
    }

    public void Calc()
    {
        this.sahe = this.x * this.y;
        Sahe = sahe;
    }
}

#region Inheritance
//abstract class Human //format
//{
//    public string Name;
//    public string Surname;
//    public byte age;

//    public Human(string nm,byte age)
//    {
//        Name = nm;
//        this.age = age;
//    }

//    public virtual void getFullName()
//    {
//        Console.WriteLine(this.Name + " " + this.Surname);
//    }

//    public abstract void Run();

//    public void Test()
//    {
//        Console.WriteLine("this is test");
//    }
//}


//class Man : Human
//{
//    public int BeardLength;

//    public Man(string ad, byte yas, int beardLength) : base(ad, yas) 
//    {
//        BeardLength = beardLength;
//    }
//    public override void getFullName()
//    {
//        Console.WriteLine(this.Name +" "+this.Surname+ " saqqal "+BeardLength );
//    }

//    public override void Run()
//    {
//        Console.WriteLine("Man is running");
//    }

//}

//class Woman : Man
//{
//    public string NailsColor;
//    public int HairLength;
//    public Woman(string add, byte yass, int beard) : base(add, yass, beard) { }
//}


//class Mother
//{

//}
//class Father
//{

//}

//class Child:Mother,Father
//{

//}

#endregion