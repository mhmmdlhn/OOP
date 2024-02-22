using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Interface
{
    public interface IShape
    {
        // Property
        string Name { get; set; }

        // Method
        void Draw();
    }
}
