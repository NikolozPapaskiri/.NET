using System;
using System.Security.Cryptography.X509Certificates;

namespace WordFrequencyCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your text: ");

            string strInput = Console.ReadLine().;

            var result = WordFrequencyCounter(strInput);

            foreach (var item in result) 
            {
                Console.WriteLine($"Word: {item.Key}, Frequency: {item.Value}");
            }
        }

        public static Dictionary<string, int> WordFrequencyCounter(string inputStr)
        {
            string cleanText = inputStr.ToLower().Trim();

            var wordFrequencies = new Dictionary<string, int>();

            string[] list = cleanText.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            foreach (string str in list)
            {
                if (wordFrequencies.ContainsKey(str))
                {
                    wordFrequencies[str]++;
                }
                else
                {
                    wordFrequencies.Add(str, 1);
                }
            }

            return wordFrequencies;
        }
    }
}