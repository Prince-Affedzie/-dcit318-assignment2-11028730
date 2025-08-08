using System;
namespace Interfaces;

public class Program
{
    public static void Main(string[] args)
    {
        
        Car myCar = new Car();
        myCar.Move(); 

        
        Bicycle myBicycle = new Bicycle();
        myBicycle.Move();
    }
}