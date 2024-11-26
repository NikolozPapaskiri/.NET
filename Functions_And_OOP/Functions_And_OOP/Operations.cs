using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions_And_OOP
{
    internal class Operations
    {
        // Define a delegate that matches methods with two int inputs and an int output
        public delegate int Operation(int x, int y);

        // Method that accepts the delegate
        public static int PerformOperation(int a, int b, Operation op)
        {
            return op(a, b); // Call the method referenced by the delegate
        }
    }
}
