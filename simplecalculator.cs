
//simple calculator using switch case
using System;
using System.Globalization;

class Program
{
    //positive or negitive number
    static void Main(string[] args)
    {
        int number;
        Console.WriteLine("Enter a number: ");
        number = int.Parse(Console.ReadLine());

        if(number >= 0)
        {
            Console.WriteLine("The number is positive.");
        }
        else if (number < 0)
        {
            Console.WriteLine("The number is negative.");
        }

      //find the largest of two numbers
        int num1, num2;
        Console.WriteLine("Enter the first number: ");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        num2 = int.Parse(Console.ReadLine());

        if(num1 > num2)
        {
            Console.WriteLine("The largest number is: " + num1);
        }
        else if (num2 > num1)
        {
            Console.WriteLine("The largest number is: " + num2);
        }

        //grade of a student
        int grade;
        Console.WriteLine("Enter the grade: ");
        grade = int.Parse(Console.ReadLine());
        
        if(grade >= 80)
        {
            Console.WriteLine("Grade: A");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("Grade: B");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("Grade: C");
        }
        else if (grade >= 50)
        {
            Console.WriteLine("Grade: D");
        }
        else
        {
            Console.WriteLine("Grade: F");
        }


//simple calculator using switch case
        double numA, numB, result;
        char operation;

        Console.WriteLine("Enter the first number: "); 
        numA = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        numB = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the operation (+, -, *, /): ");
        operation = char.Parse(Console.ReadLine());

        switch (operation)
        {
            case '+':
                result = numA + numB;
                Console.WriteLine("Result: " + result);
                break;
            case '-':
                result = numA - numB;
                Console.WriteLine("Result: " + result);
                break;
            case '*':
                result = numA * numB;
                Console.WriteLine("Result: " + result);
                break;
            case '/':
               result = numA / numB;
                Console.WriteLine("Result: " + result);
         
                break;
                default:
                Console.WriteLine("Invalid.");
                break;      
        }
    }
}

