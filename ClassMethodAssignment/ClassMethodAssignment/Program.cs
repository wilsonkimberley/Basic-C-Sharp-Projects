using System;

namespace ClassMethodAssignment
{
    class Program
    {
        static void Main()
        {
            // Ask the user for a number
            Console.Write("Enter a number to divide by 2: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            // Call void method to divide by 2 and display result
            MathOperations.DivideByTwo(userNumber);

            // Call method with output parameter
            MathOperations.DivideByTwoOut(userNumber, out int outResult);
            Console.WriteLine($"Output parameter result: {outResult}");

            // Call overloaded method using a decimal number
            Console.Write("Enter a decimal number to divide by 2: ");
            decimal decimalNumber = Convert.ToDecimal(Console.ReadLine());
            MathOperations.DivideByTwo(decimalNumber);

            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();
        }
    }
}
