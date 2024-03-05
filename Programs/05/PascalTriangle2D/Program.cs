using System;

class PascalTriangle
{
    static void Main()
    {
        Console.WriteLine("Enter the number of rows for Pascal's Triangle:");
        int numRows = Convert.ToInt32(Console.ReadLine());

        // Create a two-dimensional array to store Pascal's Triangle
        int[,] triangle = new int[numRows, numRows];

        // Populate the array with Pascal's Triangle values
        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                if (j == 0 || j == i)
                {
                    triangle[i, j] = 1; // First and last element in each row is 1
                }
                else
                {
                    triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j];
                }
            }
        }

        // Print Pascal's Triangle
        Console.WriteLine("Pascal's Triangle:");

        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write($"{triangle[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}

