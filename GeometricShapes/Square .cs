using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{

    // Square inherits from Rectangle.
    // It automatically gets the IShape implementation from its base class.
    public class Square : Rectangle
    {
        // The constructor takes a single side length...
        public Square(double side)// ...and calls the base Rectangle constructor with that side for both width and height.
            : base(side, side)
        {

        }
    }
}
