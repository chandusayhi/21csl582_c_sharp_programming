using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Simple Arithmetic Calculator");

        // Read operator and operands from the console
        Console.Write("Enter the operator (+, -, *, /, %): ");
        char operation = Console.ReadKey().KeyChar;
        Console.WriteLine(); // Move to the next line

        Console.Write("Enter the first operand: ");
        double operand1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second operand: ");
        double operand2 = Convert.ToDouble(Console.ReadLine());

        double result = 0;

        // Perform the selected operation
        switch (operation)
        {
            case '+':
                result = operand1 + operand2;
                break;
            case '-':
                result = operand1 - operand2;
                break;
            case '*':
                result = operand1 * operand2;
                break;
            case '/':
                // Check for division by zero
                if (operand2 != 0)
                {
                    result = operand1 / operand2;
                }
                else
                {
                    Console.WriteLine("Error: Division by zero.");
                    return;
                }
                break;
            case '%':
                // Check for division by zero
                if (operand2 != 0)
                {
                    result = operand1 % operand2;
                }
                else
                {
                    Console.WriteLine("Error: Division by zero.");
                    return;
                }
                break;
            default:
                Console.WriteLine("Error: Invalid operator.");
                return;
        }

        // Display the result
        Console.WriteLine($"Result: {operand1} {operation} {operand2} = {result}");
    }
}

