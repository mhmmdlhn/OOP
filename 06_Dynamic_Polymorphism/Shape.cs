using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Dynamic_Polymorphism
{
    public class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape");
        }
    }
}
