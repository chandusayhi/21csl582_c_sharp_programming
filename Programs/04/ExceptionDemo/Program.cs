using System;

class ExceptionDemo
{
    static void Main()
    {
        // Division by Zero Exception
        try
        {
            int numerator = 10;
            int denominator = 3;
            int result = numerator / denominator;  // Division by non zero value
            Console.WriteLine($"Result of division of {numerator}/{denominator}: {result}");
            numerator = 10;
            denominator = 0;
            result = numerator / denominator;  // Division by zero
            Console.WriteLine($"Result of division: {result}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Division by zero exception caught: {ex.Message}");
        }

        // Index Out of Range Exception
        try
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int index = 3;  // Accessing an index that is in range
            int value = numbers[index];
            Console.WriteLine($"Value at index {index}: {value}");            
            index = 10;  // Accessing an index that is out of range
            value = numbers[index];
            Console.WriteLine($"Value at index {index}: {value}");
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine($"Specified Index is out of range hence out of range exception caught: {ex.Message}");
        }
    }
}

