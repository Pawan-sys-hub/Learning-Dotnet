
using System;

namespace OverloadingDemo
{
    public class Car
{
    //defult constructor and parameterized constructor

    public Car()
    {
        Console.WriteLine("Default constructor");
    }

    public Car(string name)
    {
        Console.WriteLine("Parameterized Constructor  // the name is " + name);
    }

   
 // static variable and static constructor

    public static int count;

    static Car()
    {
        count = 0;
        Console.WriteLine("Static constructor");
    }

// demonstrating constructor overloading
    public Car(string name, int year)
    {
        Console.WriteLine("Constructor overloading // the name is " + name + " and the year is " + year);
    }
    
//deconstrutor and test GC
    ~Car()
    {
        Console.WriteLine("Destructor called");
    }

 public static void Main(string[] args)
    {
        Car c1 = new Car();
        Car c2 = new Car("pawan");
        Car c3 = new Car("pawan", 2020);
    }
}

}
