using System;

namespace MethodOverloadingAssignment
{
    class Program
    {
        static void Main()
        {
            // Instantiate the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Call the first method with an integer
            int intResult = mathOps.PerformOperation(15);
            Console.WriteLine($"Integer method result: {intResult}");

            // Call the second method with a decimal
            int decimalResult = mathOps.PerformOperation(7.5m);
            Console.WriteLine($"Decimal method result: {decimalResult}");

            // Call the third method with a string
            int stringResult = mathOps.PerformOperation("20");
            Console.WriteLine($"String method result: {stringResult}");

            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();
        }
    }
}
