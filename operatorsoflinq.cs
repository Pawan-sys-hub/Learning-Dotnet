//All operators of LINQ ( addition , subtraction, multiplication, division, modulus, increment, decrement, equality, inequality, greater than, less than, logical AND, logical OR, logical NOT)
using System;
using System.Linq;
class Program
{
    static void Main()
    {
        int a = 10;
        int b = 5;

        // Addition
        Console.WriteLine($"Addition: {a} + {b} = {a + b}");

        // Subtraction
        Console.WriteLine($"Subtraction: {a} - {b} = {a - b}");

        // Multiplication
        Console.WriteLine($"Multiplication: {a} * {b} = {a * b}");

        // Division
        Console.WriteLine($"Division: {a} / {b} = {a / b}");

        // Modulus
        Console.WriteLine($"Modulus: {a} % {b} = {a % b}");

        // Increment
        a++;
        Console.WriteLine($"Increment: a++ = {a}");

        // Decrement
        b--;
        Console.WriteLine($"Decrement: b-- = {b}");

        // Equality
        Console.WriteLine($"Equality: a == b is {(a == b)}");

        // Inequality
        Console.WriteLine($"Inequality: a != b is {(a != b)}");

        // Greater than
        Console.WriteLine($"Greater than: a > b is {(a > b)}");

        // Less than
        Console.WriteLine($"Less than: a < b is {(a < b)}");

        // Logical AND
        Console.WriteLine($"Logical AND: (a > 0) && (b > 0) is {(a > 0 && b > 0)}");

        // Logical OR
        Console.WriteLine($"Logical OR: (a > 0) || (b < 0) is {(a > 0 || b < 0)}");

        // Logical NOT
        Console.WriteLine($"Logical NOT: !(a > 0) is {! (a > 0)}");
    }
}