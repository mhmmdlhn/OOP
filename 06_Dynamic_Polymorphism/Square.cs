using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Dynamic_Polymorphism
{
    public class Square : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a square");
        }
    }
}
