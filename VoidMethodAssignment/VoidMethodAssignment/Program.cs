using System;

namespace VoidMethodAssignment
{
    class Program
    {
        static void Main()
        {
            // Instantiate the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Call the method normally with two numbers
            mathOps.ProcessNumbers(5, 10);

            // Call the method using named arguments (order does not matter)
            mathOps.ProcessNumbers(secondNumber: 20, firstNumber: 7);

            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();
        }
    }
}
