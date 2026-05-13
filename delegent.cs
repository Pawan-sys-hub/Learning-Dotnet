
//multidelegate 

using System;
public delegate void MyDelegate(string message);
class Program
{
    public static void Main(string[] args)
    {
        MyDelegate del1 = Method1;
        MyDelegate del2 = Method2;

        MyDelegate multiDel = del1 + del2;

        multiDel("Hello, World!");
//action delegate
        Action<string> greet = name =>
        {
            Console.WriteLine($"Hello, {name}!");
        };
        greet("pawan");
//funs delegate

        Func<int, int, int> multiply = (x, y) => x * y;
        Console.WriteLine(multiply(4, 5));

//predicate delegate
        Predicate<int> isEven = number => number % 2 == 0;
        Console.WriteLine(isEven(4));
        Console.WriteLine(isEven(5)); 

        //genric delegate
        Func<int, int, int> add = (a, b) => a + b;
        Console.WriteLine(add(5, 3));

    
    }


    public static void Method1(string message)
    {
        Console.WriteLine("Method1: " + message);
    }
    public static void Method2(string message)
    {
        Console.WriteLine("Method2: " + message);
    }
}

