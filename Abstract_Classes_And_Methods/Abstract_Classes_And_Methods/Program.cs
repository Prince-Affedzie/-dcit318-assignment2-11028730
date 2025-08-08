using Abstract_Classes_And_Methods;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        
        Circle myCircle = new Circle(10);
        Console.WriteLine($"The area of the circle is: {myCircle.GetArea()}");

        
        Rectangle myRectangle = new Rectangle(5, 8);
        Console.WriteLine($"The area of the rectangle is: {myRectangle.GetArea()}");
    }
}