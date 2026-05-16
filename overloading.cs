
using System;

public class car
{
    //defult constructor and parameterized constructor

    public car()
    {
        Console.WriteLine("Default constructor");
    }

    public car(string name)
    {
        Console.WriteLine("Parameterized Constructor  // the name is " + name);
    }

   
 // static variable and static constructor

    public static int count;

    static car()
    {
        count = 0;
        Console.WriteLine("Static constructor");
    }

// demonstrating constructor overloading
    public car(string name, int year)
    {
        Console.WriteLine("Constructor overloading // the name is " + name + " and the year is " + year);
    }
    
//deconstrutor and test GC
    ~car()
    {
        Console.WriteLine("Destructor called");
    }

 public static void Main(string[] args)
    {
        car c1 = new car();
        car c2 = new car("pawan");
        car c3 = new car("pawan", 2020);
    }
}
