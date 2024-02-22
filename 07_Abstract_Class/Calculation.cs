using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Abstract_Class
{
    public abstract class Calculation
    {
        public abstract double PerformCalculation(double x, double y);
        public void DisplayResult(double result)
        {
            Console.WriteLine($"The result of the calculation is: {result}");
        }
    }
}
