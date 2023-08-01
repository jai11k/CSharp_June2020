using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_June2020.SOLID._2.OCP.WithoutOCP
{
    public abstract class Shape
    {
        public abstract double CalculateArea();
    }

    public class Circle : Shape
    {
        public override double CalculateArea()
        {
            // Calculate and return the area of the Circle
            return 0.0;
        }
    }

    public class Rectangle : Shape
    {
        public override double CalculateArea()
        {
            // Calculate and return the area of the Rectangle
            return 0.0;
        }
    }

    // Adding support for a new shape (e.g., Triangle) without modifying existing code.
    public class Triangle : Shape
    {
        public override double CalculateArea()
        {
            // Calculate and return the area of the Triangle
            return 0.0;
        }
    }

}
