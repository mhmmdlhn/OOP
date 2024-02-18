using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Inheritance
{
    public class Cat : Animal
    {
        public int Age { get; set; }

        public Cat(string name, int age) : base(name)
        {
            Age = age;
        }

        public void Purr()
        {
            Console.WriteLine($"{Name} (age {Age}) is purring.");
        }
    }
}
