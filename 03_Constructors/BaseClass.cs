using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Constructors
{
    public class BaseClass
    {
        private int baseValue;

        // Constructor
        public BaseClass(int value)
        {
            baseValue = value;
        }

        // Method
        public void DisplayBaseValue()
        {
            Console.WriteLine($"Base Value: {baseValue}");
        }
    }
}
