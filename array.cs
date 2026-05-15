
using System;
using System.Globalization;

class Program
{
   static void Main(string[] args)
    {
        // sum of Numbers
        int sum = 0;
        for (int i = 1; i <= 100000; i++)
        {
            sum += i;
        }
        Console.WriteLine("Sum of numbers from 1 to 100000 is: " + sum);



        // multiplication Table
        Console.WriteLine("Multiplication Table:");
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write((i * j).ToString().PadLeft(4));
            }
            Console.WriteLine();
        }



    //factorial of a number
        Console.WriteLine("Enter a number to calculate its factorial:");
        int number = int.Parse(Console.ReadLine());
        long factorial = 1;
        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }
        Console.WriteLine("Factorial of " + number + " is: " + factorial);
        
        
        
// reverse a number
        Console.WriteLine("Enter a number to reverse:");
        int numToReverse = int.Parse(Console.ReadLine());
        int reversedNumber = 0;
        while (numToReverse > 0)
        {
            int digit = numToReverse % 10;
            reversedNumber = (reversedNumber * 10) + digit;
            numToReverse /= 10;
        }
        Console.WriteLine("Reversed number is: " + reversedNumber);
        
        
        
//iterate a array
        Console.WriteLine("Iterating through an array:");
        int[] numbersArray = { 1, 2, 3, 4, 5 };
        foreach (int num in numbersArray)
        {
            Console.WriteLine(num);
        }
    }
}