using System;

// 1. Basic example using 'this' to resolve name ambiguity
class Student 
{
    private string name;

    
    public Student(string name)
    {
        this.name = name;
    }

    public void SetName(string name)
    {
        this.name = name; 
    }

    public void Display() 
    {
        Console.WriteLine("Student Name: " + name);
    }
}

// 2. Using 'this' to call current class methods
class Test
{    
    public void Show()
    {
        Console.WriteLine("This is Show method");
    }

    public void Display()
    {
        Console.WriteLine("This is Display method");
        this.Show(); 
    }
}
 
// 3. Using 'this' in a constructor
class Students
{
    string names;
    int age;

    public Students(string names, int age)
    {
        // Fixed: Use the 'names' parameter instead of default(String)
        this.names = names; 
        this.age = age;
    }

    public void Display()
    {
        Console.WriteLine("Names: " + names);
        Console.WriteLine("Age: " + age);
    }
}

//4 method call Example using "this"
class calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public void ShowResult()
    {
        int result = this.Add(5, 10); 
        Console.WriteLine("Result of addition: " + result);
    }

}

//passing current object using this 

class testing
{
    public void Display(testing t)
    {
        Console.WriteLine("Inside Display method");
    }

    public void Show()
    {
        this.Display(this); 
    }
}

// The Main method should be in its own class or one of the existing ones
class Program
{
    public static void Main(string[] args) 
    {

        Student s = new Student("Pawan Pokharel");
        s.Display();
        Console.WriteLine("-----------------------------------------------------------------------");

       
        Test t = new Test();
        t.Display();
        Console.WriteLine("-----------------------------------------------------------------------");

        
        Students s1 = new Students("Pawan Pokharel", 22);
        s1.Display();
        Console.WriteLine("-----------------------------------------------------------------------");

        calculator c = new calculator();
        c.ShowResult();
        Console.WriteLine("-----------------------------------------------------------------------");

        testing test = new testing();
        test.Show();
        Console.WriteLine("-----------------------------------------------------------------------");


    }
}

