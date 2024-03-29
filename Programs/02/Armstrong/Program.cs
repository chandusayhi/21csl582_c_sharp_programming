/*using System;

class ArmstrongNumbers
{
    static void Main()
    {
        Console.WriteLine("Armstrong Numbers between 1 and 1000:");

        for (int number = 1; number <= 1000; number++)
        {
            if (IsArmstrongNumber(number))
            {
                Console.WriteLine(number);
            }
        }
    }

    static bool IsArmstrongNumber(int num)
    {
        int originalNumber = num;
        int numDigits = CountDigits(num);
        int sum = 0;

        while (num > 0)
        {
            int digit = num % 10;
            sum += (int)Math.Pow(digit, numDigits);
            num /= 10;
        }

        return originalNumber == sum;
    }

    static int CountDigits(int num)
    {
        int count = 0;

        while (num > 0)
        {
            num /= 10;
            count++;
        }

        return count;
    }
}
*/

//Without using Functions
using System;

class ArmstrongNumbers
{
    static void Main()
    {
        Console.WriteLine("Armstrong Numbers between 1 and 1000:");

        for (int number = 1; number <= 1000; number++)
        {
            int numDigits = 0;
            int temp = number;

            while (temp > 0)
            {
                temp /= 10;
                numDigits++;
            }

            temp = number;
            int sum = 0;

            while (temp > 0)
            {
                int digit = temp % 10;
                sum += (int)Math.Pow(digit, numDigits);
                temp /= 10;
            }

            if (number == sum)
            {
                Console.WriteLine(number);
            }
        }
    }
}

