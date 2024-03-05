using System;

class Complex
{
    private double real;
    private double imaginary;

    // Constructor
    public Complex(double real, double imaginary)
    {
        this.real = real;
        this.imaginary = imaginary;
    }

    // Overloaded addition operator
    public static Complex operator +(Complex c1, Complex c2)
    {
        double realSum = c1.real + c2.real;
        double imaginarySum = c1.imaginary + c2.imaginary;
        return new Complex(realSum, imaginarySum);
    }

    // Display the complex number
    public void Display()
    {
        Console.WriteLine($"Result: {real} + {imaginary}i");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first complex number:");
        Console.Write("Real part: ");
        double real1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Imaginary part: ");
        double imaginary1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nEnter the second complex number:");
        Console.Write("Real part: ");
        double real2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Imaginary part: ");
        double imaginary2 = Convert.ToDouble(Console.ReadLine());

        // Create Complex objects
        Complex complex1 = new Complex(real1, imaginary1);
        Complex complex2 = new Complex(real2, imaginary2);

        // Use the overloaded addition operator
        Complex result = complex1 + complex2;

        // Display the result
        Console.WriteLine("\nFirst complex number:");
        complex1.Display();
        Console.WriteLine("\nSecond complex number:");
        complex2.Display();
        Console.WriteLine("\nResult of addition:");
        result.Display();
    }
}

