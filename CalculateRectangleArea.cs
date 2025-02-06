using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_UsingCSharp
{
    /* Rectangle Area Calculation
        Create a Rectangle class with private fields for Length and Breadth.Add public methods to set
        the values of these fields and a method to calculate and return the area of the rectangle.
    */
    internal class CalculateRectangleArea
    {
        private double length;
        private double breadth;

        public void SetLength(double length)
        {
            if (length > 0)
            {
                this.length = length;
            }
            else
            {
                Console.WriteLine("Length must be a positive number.");
            }
        }
        public void SetBreadth(double breadth)
        {
            if (breadth > 0)
            {
                this.breadth = breadth;
            }
            else
            {
                Console.WriteLine("Breadth must be a positive number.");
            }
        }

        public void CalculateArea()
        {
            double area = length * breadth;
            Console.WriteLine($"Area of the Rectangle is: {area}");
        }
    }

}
