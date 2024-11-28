using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions_And_OOP
{
    public class BankAccount
    {
        // Private fields
        private string _accountNumber;
        private decimal _balance;

        // Constructor to initialize the account
        public BankAccount(string accountNumber, decimal initialBalance)
        {
            _accountNumber = accountNumber;
            _balance = initialBalance < 0
                ? throw new ArgumentException("Initial balance cannot be negative.")
                : initialBalance;
        }

        // Public getter for AccountNumber (read-only property)
        public string AccountNumber => _accountNumber;

        // Public method to deposit money
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be greater than zero.");
                return;
            }
            _balance += amount;
            Console.WriteLine($"Deposited {amount:C}. New balance: {_balance:C}");
        }

        // Public method to withdraw money
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be greater than zero.");
                return;
            }

            if (amount > _balance)
            {
                Console.WriteLine("Insufficient funds. Withdrawal failed.");
                return;
            }

            _balance -= amount;
            Console.WriteLine($"Withdrew {amount:C}. New balance: {_balance:C}");
        }

        // Public method to get current balance
        public decimal GetBalance() => _balance;
    }
}