using System;

namespace BasicCalculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 1. Instantiate the Calculator
            Calculator calculator = new Calculator();

            Console.WriteLine("--- Basic Calculator Demonstration ---");

            // 2. Perform integer calculations
            Console.WriteLine("\n--- Integer Operations ---");
            int sum_int = calculator.Add(10, 5);
            int difference_int = calculator.Subtract(10, 5);
            int product_int = calculator.Multiply(10, 5);
            double quotient_int = calculator.Divide(10, 4); // Note: 10/4 is 2.5

            Console.WriteLine($"10 + 5 = {sum_int}");
            Console.WriteLine($"10 - 5 = {difference_int}");
            Console.WriteLine($"10 * 5 = {product_int}");
            Console.WriteLine($"10 / 4 = {quotient_int}");

            // 3. Perform double calculations (using overloaded methods)
            Console.WriteLine("\n--- Double Operations ---");
            double sum_double = calculator.Add(10.5, 5.2);
            double difference_double = calculator.Subtract(10.5, 5.2);
            double product_double = calculator.Multiply(10.5, 5.2);
            double quotient_double = calculator.Divide(10.5, 5.2);

            Console.WriteLine($"10.5 + 5.2 = {sum_double:F2}"); // Format to 2 decimal places
            Console.WriteLine($"10.5 - 5.2 = {difference_double:F2}");
            Console.WriteLine($"10.5 * 5.2 = {product_double:F2}");
            Console.WriteLine($"10.5 / 5.2 = {quotient_double:F2}");

            // 4. Demonstrate error handling for division by zero
            double devide_byzero = calculator.Divide(15, 0);
            Console.WriteLine($"Attempting to divide 15 by 0...{devide_byzero}");
        }
    }
}