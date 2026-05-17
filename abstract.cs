
using System;
 //abtract class demo

 class Square
 {
     public virtual void area()
     {
         Console.WriteLine("Area of square");
     }
 }
    class Rectangle : Square
    {
        public override void area()
        {
            Console.WriteLine("Area of rectangle");
        }
    }
    class Circle : Square
    {
        public override void area()
        {
            Console.WriteLine("Area of circle");
        }
    }
    class Program
    {
        static void Main(string[] args)        {
            Square s = new Square();
            s.area();
            Rectangle r = new Rectangle();
            r.area();
            Circle c = new Circle();
            c.area();
        }
    }


