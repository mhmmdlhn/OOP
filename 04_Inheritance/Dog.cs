using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Inheritance
{
    public class Dog : Animal
    {
        public string Breed { get; set; }

        public Dog(string name, string breed) : base(name)
        {
            Breed = breed;
        }

        public void Bark()
        {
            Console.WriteLine($"{Name} (a {Breed} dog) is barking.");
        }
    }
}
