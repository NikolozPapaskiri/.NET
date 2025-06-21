using System;

namespace UniqueItemTrackerWordFrequencyCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] productIds = { "1", "2", "3", "2" };
            HashSet<string> products = new HashSet<string>();

            foreach (string productId in productIds)
                products.Add(productId);

                Console.WriteLine("Original Array List");
            foreach (string productId in productIds)
            {
                Console.WriteLine(productId);
            }

            Console.WriteLine("\nUniqueue List");
            foreach (string productId in products)
                Console.WriteLine(productId);

            
        }
    }
}