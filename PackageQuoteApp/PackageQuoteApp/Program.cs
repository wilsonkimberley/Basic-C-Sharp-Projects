using System;

class PackageQuoteApp
{
    static void Main()
    {
        // Welcome message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Package weight
        Console.WriteLine("Please enter the package weight:");
        decimal packageWeight = Convert.ToDecimal(Console.ReadLine());

        // Check weight limit
        if (packageWeight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return;
        }

        // Package dimensions
        Console.WriteLine("Please enter the package width:");
        decimal packageWidth = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Please enter the package height:");
        decimal packageHeight = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Please enter the package length:");
        decimal packageLength = Convert.ToDecimal(Console.ReadLine());

        // Check dimension limit
        if ((packageWidth + packageHeight + packageLength) > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return;
        }

        // Calculate shipping quote
        decimal quote = (packageWidth * packageHeight * packageLength * packageWeight) / 100;

        // Display quote
        Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
        Console.WriteLine("Thank you!");
    }
}
