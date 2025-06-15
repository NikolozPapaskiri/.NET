using System;
using System.Reflection.Metadata.Ecma335;

namespace ParenthesesBalancingChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write Your Parentheses: ");

            string input = Console.ReadLine();

            bool isBalanced1 = ParenthesesBalancingChecker(input);
            bool isBalanced2 = ParenthesesBalancingCheckerWithDictionary(input);

            Console.WriteLine("Parentheses Are Balanced (using ParenthesesBalancingChecker()): " + isBalanced1);
            Console.WriteLine("Parentheses Are Balanced (using ParenthesesBalancingCheckerWithDictionary()): " + isBalanced2);
        }

        public static bool ParenthesesBalancingCheckerWithDictionary(string input)
        {
            var stack = new Stack<char>();

            // A dictionary is a clean way to map opening to closing brackets
            var bracketPairs = new Dictionary<char, char>()
            {
                { '(', ')' },
                { '{', '}' },
                { '[', ']' }
            };

            foreach (char c in input)
            {
                // If it's an opening bracket, push it onto the stack.
                if (bracketPairs.ContainsKey(c))
                {
                    stack.Push(c);
                }
                // If it's a closing bracket
                else if (bracketPairs.ContainsValue(c))
                {
                    // If stack is empty or the brackets don't match, it's unbalanced.
                    // Stack.TryPop gets the top item AND removes it in one step.
                    if (stack.Count == 0 || bracketPairs[stack.Pop()] != c)
                    {
                        return false;
                    }
                }
            }

            // If the stack is empty at the end, all brackets were matched.
            return stack.Count == 0;
        }

        public static bool ParenthesesBalancingChecker(string input)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char ch in input)
            {
                if (ch == '(' || ch == '{' || ch == '[')
                {
                    stack.Push(ch);
                }
                else if (ch == ')' || ch == '}' || ch == ']')
                {
                    if (stack.Count == 0 || !IsMatchingParentheses(stack.Pop(), ch))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }

        public static bool IsMatchingParentheses(char open, char close)
        {
            // Corrected the comparison operators and replaced 'True' and 'False' with 'true' and 'false'.
            if ((open == '{' && close == '}') ||
                (open == '[' && close == ']') ||
                (open == '(' && close == ')'))
            {
                return true;
            }
            return false;
        }
    }
}