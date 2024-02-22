using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Abstract_Class
{
    public class Subtraction : Calculation
    {
        public override double PerformCalculation(double x, double y)
        {
            return x - y;
        }
    }
}
