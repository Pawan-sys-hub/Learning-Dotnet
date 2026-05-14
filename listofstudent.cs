//list of students using LINQ
using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<string> students = new List<string>
        {
           "Pawan",
           "Aayusha",
            "Suman",
            "Prashant",
            "Anup",
            "Sushil",
        };

        // Using LINQ to filter students whose names start with 'P'
        var filteredStudents = students.Where(s => s.StartsWith("P"));

        Console.WriteLine("Students whose names start with 'P':");
        foreach (var student in filteredStudents)
        {
            Console.WriteLine(student);
        }
    }
}