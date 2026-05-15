
//leap year 

using System;
using System.Globalization;

class Program
{
    
    //showing leap year
    static void Main(string[] args)
    {
        int year = 2024;
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            Console.WriteLine(year + " is a leap year.");
        }
        else
        {
            Console.WriteLine(year + " is not a leap year.");
        }
    }
}

// nested if statement
        int number = 10;
        if (number > 0)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine(number + " is a positive even number.");
            }
            else
            {
                Console.WriteLine(number + " is a positive odd number.");
            }
}
        else if (number < 0)
        {
            Console.WriteLine(number + " is a negative number.");
        }
        else
        {
            Console.WriteLine("The number is zero.");
        }
