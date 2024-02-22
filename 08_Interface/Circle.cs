using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Interface
{
    public class Circle : IShape
    {
        // Implementing the properties and methods from the interface
        public string Name { get; set; }

        public void Draw()
        {
            Console.WriteLine($"Drawing a {Name}");
        }
    }

}
