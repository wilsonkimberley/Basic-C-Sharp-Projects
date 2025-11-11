using System;

namespace ClassMethodAssignment
{
    // Declare class as static since all methods are utility methods
    public static class MathOperations
    {
        // Void method: divides input by 2 and prints the result
        public static void DivideByTwo(int number)
        {
            int result = number / 2;
            Console.WriteLine($"Number divided by 2: {result}");
        }

        // Method with output parameter: divides input by 2 and returns via out
        public static void DivideByTwoOut(int number, out int result)
        {
            result = number / 2;
        }

        // Overloaded method: takes a decimal instead of int
        public static void DivideByTwo(decimal number)
        {
            decimal result = number / 2;
            Console.WriteLine($"Decimal number divided by 2: {result}");
        }
    }
}
