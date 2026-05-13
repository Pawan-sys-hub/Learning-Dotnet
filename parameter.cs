
//using  parameters demo(ref, out, params )
using System;
class Program
{
    // 1. Pass by Value (No change to original)
    void Modify(int a)
    {
        a = a * 2;
    }

    // 2. Pass by Reference (Original changes)
    void RefModify(ref int a)
    {
        a = a * 2; 
    }

    // 3. Out Parameters (Must be assigned inside the method)
    void ModifyOut(out int x, out int y)
    {
        x = 15;
        y = 25;
    }

    // 4. Params Array (Accepts any number of arguments)
    int ModifyString(params int[] a)
    {
        int sum = 0;
        foreach (int item in a)
        {
            sum += item;
        }
        return sum;
    }

    // 5. Default Parameter
    void DefaultParam(string name = "hello world")
    {
        Console.WriteLine(name);
    }

    static void Main()
    {
        Program p = new Program();
        int a = 5;
        int x, y;

        // Pass by Value
        p.Modify(a);
        Console.WriteLine($"Value after Modify: {a}"); // Still 5

        // Pass by Reference
        p.RefModify(ref a);
        Console.WriteLine($"Value after RefModify: {a}"); // Now 10

        // Out Parameters
        p.ModifyOut(out x, out y);
        Console.WriteLine($"Out values: x={x}, y={y}"); 

        // Params
        int result = p.ModifyString(10, 20, 30, 40); 
        Console.WriteLine($"Sum from params: {result}");

        // Default Parameters
        p.DefaultParam();            // Prints: hello world
        p.DefaultParam("pawan pokharel");    // Prints: pawan pokharel
    }
}

