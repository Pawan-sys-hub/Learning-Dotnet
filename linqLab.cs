//FINDING Even Numbers in a List using LINQ
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Using LINQ to find even numbers
        var evenNumbers = numbers.Where(n => n % 2 == 0);

        Console.WriteLine("Even numbers in the list:");
        foreach (var num in evenNumbers)
        {
            Console.WriteLine(num);
        }
    }
}