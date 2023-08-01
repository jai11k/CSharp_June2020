using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3.LSP.Ex4.WithoutLSP
{
    using System;

    public class Shape
    {
        public virtual double Area()
        {
            return 0; // Placeholder implementation for base class
        }
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }
    }

    public class Square : Shape
    {
        public double Side { get; set; }

        public override double Area()
        {
            return Side * Side; // Area of a square is Side * Side, not Width * Height
        }
    }

    public class Program
    {
        static void Main()
        {
            Shape rectangle = new Rectangle { Width = 5, Height = 10 };
            Shape square = new Square { Side = 5 };

            Console.WriteLine($"Area of rectangle: {rectangle.Area()}"); // Output: Area of rectangle: 50
            Console.WriteLine($"Area of square: {square.Area()}");       // Output: Area of square: 25

            // Violating Liskov Substitution Principle by treating Square as Rectangle
            // Since the Square class is derived from Shape, we attempt to modify the Width and Height properties.
            // This would produce unexpected behavior because the Square class doesn't behave like a Rectangle.
            //rectangle.Width = 7;
            //rectangle.Height = 7;
            Console.WriteLine($"Area of rectangle after modification: {rectangle.Area()}"); // Incorrect output: Area of rectangle after modification: 49
        }
    }


}
