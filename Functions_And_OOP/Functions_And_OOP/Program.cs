/*
 * Delegate-based Operation
Create a method PerformOperation that takes two integers and a delegate Func<int, int, int>. Use it to perform addition, subtraction, multiplication, and division.
Example:
csharp
Copy code
*/
using System;
using static Functions_And_OOP.Operations;

public class Program
{
    public static void Main()
    {
        int a = 10;
        int b = 5;

        // Define some operations using lambda expressions
        Operation add = (x, y) => x + y;
        Operation subtract = (x, y) => x - y;
        Operation multiply = (x, y) => x * y;
        Operation divide = (x, y) => x / y;

        // Perform operations
        Console.WriteLine("add: " + add(a, b));
        Console.WriteLine("subtract: " + subtract(a, b));
        Console.WriteLine("multiply: " + multiply(a, b));
        Console.WriteLine("divide: " + divide(a, b));
    }
}
