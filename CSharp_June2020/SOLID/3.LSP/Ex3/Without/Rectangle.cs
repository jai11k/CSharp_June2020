using System;

namespace SOLID._3.LSP.Ex3.Without
{
    public class Rectangle
    {
        public virtual int Height { get; set; }
        public virtual int Width { get; set; }
    }

    public class Square : Rectangle
    {
        private int _height;
        private int _width;
        public override int Height
        {
            get => _height;
            set
            {
                _height = value;
                _width = value;
            }

        }

         public override int Width
        {
            get => _width;
            set
            {
                _height = value;
                _width = value;
            }
        }
    }

    public class AreaCalculator
    {
        public static int CalculateArea(Rectangle r)
        {
            return r.Height*r.Width;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Rectangle sqr1 = new Square();
            sqr1.Height = 6;
            sqr1.Width = 8;

            Console.WriteLine(AreaCalculator.CalculateArea(sqr1)); //returns 64

            Rectangle sqr2 = new Square();
            sqr2.Height = 8;
            sqr2.Width = 6;

            Console.WriteLine(AreaCalculator.CalculateArea(sqr2)); //returns 36
            Console.ReadKey();
        }
    }




}
