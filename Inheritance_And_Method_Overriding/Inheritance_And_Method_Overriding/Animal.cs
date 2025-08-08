using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_And_Method_Overriding
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }

        public Animal(string name, int age, string breed, string color)
        {
            this.Name = name;
            this.Age = age;
            this.Breed = breed;
            this.Color = color;
        }

        
        public virtual void MakeSound()
        {
            Console.WriteLine("The animal makes a generic sound.");
        }
    }
}
