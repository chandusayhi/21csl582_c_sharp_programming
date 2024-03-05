using System;

class FloydsTriangle
{
    static void Main()
    {
        Console.WriteLine("Enter the number of rows for Floyd's Triangle:");
        int numRows = Convert.ToInt32(Console.ReadLine());

        // Create a jagged array to store Floyd's Triangle
        int[][] triangle = new int[numRows][];

        // Populate the jagged array with Floyd's Triangle values
        int currentNumber = 1;
        for (int i = 0; i < numRows; i++)
        {
            triangle[i] = new int[i + 1]; // Allocate space for each row

            for (int j = 0; j <= i; j++)
            {
                triangle[i][j] = currentNumber++;
            }
        }

        // Print Floyd's Triangle
        Console.WriteLine("Floyd's Triangle:");

        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write($"{triangle[i][j]} ");
            }
            Console.WriteLine();
        }
    }
}

