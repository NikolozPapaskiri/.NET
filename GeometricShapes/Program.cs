using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace GeometricShapes
{
    /*
    Define an interface IShape with methods double CalculateArea() and double CalculatePerimeter().
    Implement IShape in classes Circle (constructor takes radius), Rectangle (constructor takes width and height), and Square (inherits from Rectangle, constructor takes side length).
    Create a list of IShape objects containing instances of Circle, Rectangle, and Square. Iterate through the list and print the area and perimeter of each shape.
    */
    public class Program
    {
        public static void Main(string[] args)
        {

            // Create a list that can hold any object implementing the IShape interface.
            var shapes = new List<IShape>
            {
                new Circle(5),
                new Rectangle(4, 7),
                new Square(6) // A Square is treated as an IShape via its Rectangle base class.
            };

            Console.WriteLine("--- Calculating Shape Details ---");

            // Iterate through the list. The 'shape' variable is of type IShape.
            foreach (var shape in shapes) 
            {
                // GetType().Name gets the actual class name (e.g., "Circle").
                Console.WriteLine($"\nShape: {shape.GetType().Name}");

                // Call the interface methods. The correct implementation is used automatically.
                Console.WriteLine($"Area: {shape.CalculateArea():F2}"); // F2 formats to 2 decimal places.
                Console.WriteLine($"Perimeter: {shape.CalculatePerimeter():F2}");
            }
        }
    }
}