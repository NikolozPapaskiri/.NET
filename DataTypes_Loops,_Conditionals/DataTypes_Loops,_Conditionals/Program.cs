/*
 * 
 * //Exercise 1: Prime Number Checker
Console.WriteLine("Prime Number Checker");
while (true)
{
    Console.Write("Enter a number (or type 'exit' to quit): ");
    string inputStr = Console.ReadLine();

    if (inputStr.ToLower() == "exit")
    {
        break;
    }

    if (!int.TryParse(inputStr, out int input))
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
        continue;
    }

    bool isPrime = true;

    if (input <= 1)
    {
        isPrime = false;
    }
    else
    {
        for (int i = 2; i <= Math.Sqrt(input); i++)
        {
            if (input % i == 0)
            {
                isPrime = false;
                break;
            }
        }
    }

    if (isPrime)
    {
        Console.WriteLine("Prime");
    }
    else
    {
        Console.WriteLine("Not Prime");
    }
}

//Exercise 2: Fibonacci Sequence Generator
Console.WriteLine("Fibonacci Sequence Generator");
while (true)
{
    Console.Write("Enter a number (or type 'exit' to quit): ");
    string inputStr = Console.ReadLine();

    if (inputStr.ToLower() == "exit")
    {
        break;
    }

    if (!int.TryParse(inputStr, out int input))
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
        continue;
    }

    List<int> Fibonacci = new List<int> { 0, 1 };

    for (int i = 1; i < input; i++)
    {
        Fibonacci.Add(Fibonacci[i] + Fibonacci[i - 1]);
    }

    foreach (int num in Fibonacci)
    {
        Console.Write(num + " ");
    }
}

//Exercise 3: Palindrome Checker
Console.WriteLine("Palindrome Checker");
while (true)
{
    Console.Write("Enter a word (or type 'exit' to quit): ");
    string input = Console.ReadLine();
    if (input.ToLower() == "exit")
    {
        break;
    }
    bool isPalindrome = true;

    for(int i = 0; i < input.Length; i++)
    {
        isPalindrome =  input[i] != input[input.Length - 1 - i] ? 
            false : 
            true;
    }

    if (isPalindrome)
        Console.WriteLine("Palindrome");
    else
        Console.WriteLine("Not Palindrome");
}

*/

//Exercise 4: Sorting Algorithm
Console.WriteLine("Sorting array: { 64, 34, 25, 12, 22, 11, 90 }");

Console.WriteLine("Bubble sort");
int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
int n = arr.Length;
int temp = 0;

for (int i = 0; i < n - 1; i++)
{
    for (int j = 0; j < n - i - 1; j++)
    {
        if (arr[j] > arr[j + 1])
        {
            temp = arr[j];
            arr[j] = arr[j + 1];
            arr[j + 1] = temp;
        }
    }
}

foreach (int num in arr)
{
    Console.Write(num + " ");
}

Console.WriteLine("\nSelection sort");
arr = new int[] { 64, 34, 25, 12, 22, 11, 90 };
int tempIndex;

for (int i = 0; i < n - 1; i++)
{
    tempIndex = i;
    for (int j = i + 1; j < n; j++)
    {
        if (arr[j] < arr[tempIndex])
        {
            tempIndex = j;
        }
    }

    temp = arr[tempIndex];
    arr[tempIndex] = arr[i];
    arr[i] = temp;
}

foreach (int num in arr)
{
    Console.Write(num + " ");
}

Console.WriteLine("\nInsertion sort");
arr = new int[] { 64, 34, 25, 12, 22, 11, 90 };

for (int i = 1; i < n - 1 ; i++)
{
    temp = arr[i];
    int j = i - 1;
    // Move elements of arr[0..i-1], that are greater than temp, to one position ahead of their current position
    while (j >= 0 && arr[j] > temp)
    {
        arr[j + 1] = arr[j];
        j--;
    }
    arr[j + 1] = temp;
}

foreach (int num in arr)
{
    Console.Write(num + " ");
}

//Exercise 5: Temperature Converter

while (true)
{    
        Console.Write("\nTemperature In Celsius: ");
        string inputStr = Console.ReadLine();

        if (!int.TryParse(inputStr, out int input))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            continue;
        }

        Console.Write("Convert to (F)ahrenheit or (K)elvin: ");
        string convertTo = Console.ReadLine();
        switch (convertTo.ToLower())
        {
            case "f":
                Console.WriteLine("Temperature in Fahrenheit: " + (input * 9 / 5 + 32));
                break;
            case "k":
                Console.WriteLine("Temperature in Kelvin: " + (input + 273.15));
                break;
            default:
                Console.WriteLine("Invalid option. Please enter 'F' or 'K'.");
                break;
        }
}


//Exercise 6: Factorial Calculator