using System;

class MathOperationsApp
{
    static void Main()
    {
        // 1. Multiply user input by 50
        Console.WriteLine("Enter a number to multiply by 50:");
        decimal number1 = Convert.ToDecimal(Console.ReadLine());
        decimal result1 = number1 * 50;
        Console.WriteLine("Result of multiplication: " + result1);

        // 2. Add 25 to user input
        Console.WriteLine("Enter a number to add 25:");
        decimal number2 = Convert.ToDecimal(Console.ReadLine());
        decimal result2 = number2 + 25;
        Console.WriteLine("Result after adding 25: " + result2);

        // 3. Divide user input by 12.5
        Console.WriteLine("Enter a number to divide by 12.5:");
        decimal number3 = Convert.ToDecimal(Console.ReadLine());
        decimal result3 = number3 / 12.5m;  // 'm' for decimal literal
        Console.WriteLine("Result after division: " + result3);

        // 4. Check if user input is greater than 50
        Console.WriteLine("Enter a number to check if it's greater than 50:");
        decimal number4 = Convert.ToDecimal(Console.ReadLine());
        bool isGreaterThan50 = number4 > 50;
        Console.WriteLine("Is the number greater than 50? " + isGreaterThan50);

        // 5. Divide user input by 7 and find the remainder
        Console.WriteLine("Enter a number to divide by 7 and find the remainder:");
        decimal number5 = Convert.ToDecimal(Console.ReadLine());
        decimal remainder = number5 % 7;
        Console.WriteLine("Remainder after dividing by 7: " + remainder);
    }
}
