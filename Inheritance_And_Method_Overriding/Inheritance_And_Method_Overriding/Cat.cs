using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_And_Method_Overriding
{
    internal class Cat : Animal
    {
        public Cat(string name, int age, string breed, string color)
            : base(name, age, breed, color)
        {
        }

        // The derived class provides its own implementation of the virtual method
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }
}
