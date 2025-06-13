using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    public class Circle : IShape
    {

        // Private field to store the radius.
        private readonly double _radius;

        // Constructor to initialize the circle with a radius.
        public Circle(double radius)
        {
            _radius = radius;
        }

        // Implementation of the CalculateArea method from the IShape interface.
        public double CalculateArea()
        {
            return Math.PI * _radius * _radius;
        }

        // Implementation of the CalculatePerimeter method from the IShape interface.
        public double CalculatePerimeter()
        {
            return 2 * Math.PI * _radius;
        }
    }
}
