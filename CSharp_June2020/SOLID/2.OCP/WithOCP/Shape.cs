using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_June2020.SOLID._2.OCP.WithOCP
{
    public class Shape
    {
        public string Type { get; set; }

        public double CalculateArea()
        {
            if (Type == "Circle")
            {
                // Calculate and return the area of the Circle
            }
            else if (Type == "Rectangle")
            {
                // Calculate and return the area of the Rectangle
            }
            // Other shape calculations can be added here, but this violates OCP.
            return 0.0;
        }
    }

}
