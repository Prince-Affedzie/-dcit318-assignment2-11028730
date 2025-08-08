using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_And_Method_Overriding
{
    public class Dog : Animal
    {
        public Dog(string name, int age, string breed, string color)
            : base(name, age, breed, color)
        {
        }

       
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }
}
