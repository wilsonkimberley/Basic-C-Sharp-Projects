using System;

namespace VoidMethodAssignment
{
    // Class containing a void method
    public class MathOperations
    {
        // Void method that takes two integers
        // Performs math on first integer and displays the second integer
        public void ProcessNumbers(int firstNumber, int secondNumber)
        {
            // Multiply the first number by 2 and display the result
            int firstResult = firstNumber * 2;
            Console.WriteLine($"First number multiplied by 2: {firstResult}");

            // Display the second number as-is
            Console.WriteLine($"Second number: {secondNumber}");
        }
    }
}
