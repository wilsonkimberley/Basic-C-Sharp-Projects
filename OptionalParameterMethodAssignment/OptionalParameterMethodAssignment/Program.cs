using System;

namespace OptionalParameterMethodAssignment
{
    class Program
    {
        static void Main()
        {
            // Instantiate the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Ask the user for the first number
            Console.Write("Enter the first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            // Ask the user for the second number (optional)
            Console.Write("Enter the second number (press Enter to skip): ");
            string secondInput = Console.ReadLine();

            int result;

            if (string.IsNullOrWhiteSpace(secondInput))
            {
                // User did not enter second number, call method with one parameter
                result = mathOps.AddNumbers(firstNumber);
            }
            else
            {
                // User entered second number, convert and pass both numbers
                int secondNumber = Convert.ToInt32(secondInput);
                result = mathOps.AddNumbers(firstNumber, secondNumber);
            }

            // Display the result
            Console.WriteLine($"The result is: {result}");

            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();
        }
    }
}
