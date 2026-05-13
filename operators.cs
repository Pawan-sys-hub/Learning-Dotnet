using System;
class Program
{
    static void Main()
    {
    int  a = 5;
    int b = 10;
    Console.WriteLine ("Addition = " + (a + b));
    Console.WriteLine ("Subtraction = " + (a - b));
    Console.WriteLine ("Multiplication = " + (a * b));
    Console.WriteLine ("Division = " + (a / b));
    Console.WriteLine ("Modulus = " + (a % b));
    Console.WriteLine ("Post-Increment = " + (a++));
     Console.WriteLine ("Post-Decrement = " + (a--));
    Console.WriteLine ("Pre-Increment = " + (++a));
    Console.WriteLine (a>b);
        Console.WriteLine (a<b);
        Console.WriteLine (a==b);
        Console.WriteLine (a!=b);
        Console.WriteLine (a>=b);
        Console.WriteLine (a<=b);
        Console.WriteLine ((a>b) && (a!=b));
        Console.WriteLine ((a>b) || (a==b));
        Console.WriteLine (!(a>b));
        
    }
}
