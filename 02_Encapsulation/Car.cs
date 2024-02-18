using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Encapsulation
{
    public class Car
    {
        // Private fields (attributes)
        private string make;
        private string model;
        private int year;

        // Public properties to access the private fields
        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Year
        {
            get { return year; }
            set
            {
                // Example validation: allow setting only if the value is greater than 1900
                if (value > 1900)
                {
                    year = value;
                }
                else
                {
                    Console.WriteLine("Invalid year value");
                }
            }
        }

        // Public method
        public void DisplayCarInfo()
        {
            Console.WriteLine($"Make: {Make}, Model: {Model}, Year: {Year}");
        }
    }
}
