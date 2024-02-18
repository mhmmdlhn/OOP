using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Constructors
{
    public class DerivedClass : BaseClass
    {
        private int derivedValue;

        // Derived class constructor
        public DerivedClass(int baseValue, int derivedValue) : base(baseValue)
        {
            this.derivedValue = derivedValue;
        }

        // New method in the derived class
        public void DisplayDerivedValue()
        {
            Console.WriteLine($"Derived Value: {derivedValue}");
        }
    }
}
