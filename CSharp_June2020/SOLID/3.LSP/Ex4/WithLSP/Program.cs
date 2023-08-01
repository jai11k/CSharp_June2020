using System;

namespace SOLID._3.LSP.Ex4.WithLSP
{
    //LSP states that - all classes should be substitutable for their base C# classes.
    //no sense again here
    public abstract class Shape
    {
        public abstract double Area();
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
            return Side * Side; // This behavior is consistent with the base class (Shape)
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
        }
    }

}
