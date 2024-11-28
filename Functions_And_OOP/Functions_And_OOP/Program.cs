/*
 * Delegate-based Operation
Create a method PerformOperation that takes two integers and a delegate Func<int, int, int>. Use it to perform addition, subtraction, multiplication, and division.
Example:
csharp
Copy code
*/
using Functions_And_OOP;
using System;
using static Functions_And_OOP.Operations;

public class Program
{
    public static void Main()
    {
        //Encapsulation 
        BankAccount bankAccount = new BankAccount("AccTest", 500);

        // Display account details
        Console.WriteLine($"Balance  Is {bankAccount.GetBalance}");
        Console.WriteLine($"Account Number  Is {bankAccount.AccountNumber}");

        // Perform some transactions
        bankAccount.Withdraw(1000);
        bankAccount.Deposit(5000);
        bankAccount.Withdraw(1000);







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
