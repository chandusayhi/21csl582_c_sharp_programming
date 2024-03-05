using System;

class SubstringLister
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string inputString = Console.ReadLine();

        // Check if the inputString is null, and if so, assign an empty string
        inputString ??= string.Empty;

        Console.WriteLine("All substrings in the given string:");

        // Loop through each character in the string
        for (int i = 0; i < inputString.Length; i++)
        {
            // Loop through each length of substring starting from the current character
            for (int j = 1; j <= inputString.Length - i; j++)
            {
                // Extract the substring using Substring(startIndex, length)
                string substring = inputString.Substring(i, j);
                Console.WriteLine(substring);
            }
        }
    }
}

