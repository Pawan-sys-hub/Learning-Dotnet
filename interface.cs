
using System;

//single inheritance 
class inheritancedemo
{
class A
{
    public void display()
    {
        Console.WriteLine("Base class ");
        Console.WriteLine("---------------------------------------------------");
    }
    
}

class B : A
{
    public void show()
    {
        Console.WriteLine("Derived class");
        Console.WriteLine("---------------------------------------------------");
    }
}


//multilevel inheritance
class C : B
{
    public void display()
    {
        Console.WriteLine("Multilevel inheritance D");
        Console.WriteLine("---------------------------------------------------");
    }
}



//multiple inheritance

interface AA
    {
        void display();
    }
interface BB
    {
        void show();
    }
class D : AA, BB
    {
        public void display()
        {
            Console.WriteLine("Multiple inheritance AA");
            
        }
        public void show()
        {
            Console.WriteLine("Multiple inheritance BB");
          
        }
    }

    static void Main(string[] args)
    {
        B obj = new B();
        obj.display();
        obj.show();

        C obj1 = new C();
        obj1.display();
        obj1.show();


        D obj2 = new D();
        obj2.display();
        obj2.show();
    }
}


