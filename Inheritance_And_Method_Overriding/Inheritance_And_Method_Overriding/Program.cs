// See https://aka.ms/new-console-template for more information
using System;
namespace Inheritance_And_Method_Overriding;

public class Program 
{
    public static void Main(string[] args) 
    {

        // Create an instance of the base Animal class
        Animal myAnimal = new Animal("Catty", 2, "Persian", "White");
        myAnimal.MakeSound();

        // Create an instance of the Dog class
        Dog myDog = new Dog("Buddy", 5, "Golden Retriever", "Golden");
        myDog.MakeSound();

        Cat myCat = new Cat("Cat1", 2, "Siamese", "White");
        myCat.MakeSound();

        
    }
}
