using System;

namespace CallingMethodsAssignment
{
    class Program
    {
        static void Main()
        {
            // Ask the user for a number
            Console.Write("Enter a number to perform math operations on: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            // Create an instance of MathOperations class
            MathOperations mathOps = new MathOperations();

            // Call MultiplyByTwo method and display result
            int result1 = mathOps.MultiplyByTwo(userNumber);
            Console.WriteLine($"Multiply by 2: {result1}");

            // Call AddTen method and display result
            int result2 = mathOps.AddTen(userNumber);
            Console.WriteLine($"Add 10: {result2}");

            // Call SubtractFive method and display result
            int result3 = mathOps.SubtractFive(userNumber);
            Console.WriteLine($"Subtract 5: {result3}");

            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();
        }
    }
}
