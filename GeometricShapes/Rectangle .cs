using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    public class Rectangle : IShape
    {
        // Private field to store the width.
        private readonly double Width;

        // Private field to store the height.
        private readonly double Height;

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        // Implementation for area.
        public double CalculateArea()
        {
            return Width * Height;
        }

        // Implementation for perimeter.
        public double CalculatePerimeter()
        {
            return 2 * (Width + Height);
        }
    }
}
