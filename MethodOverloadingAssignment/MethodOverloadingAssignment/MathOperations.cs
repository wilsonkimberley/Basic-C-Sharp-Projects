using System;

namespace MethodOverloadingAssignment
{
    // Class containing overloaded math methods
    public class MathOperations
    {
        // Method 1: takes an integer, adds 10, returns result
        public int PerformOperation(int number)
        {
            return number + 10;
        }

        // Method 2: takes a decimal, multiplies by 2, returns result as int
        public int PerformOperation(decimal number)
        {
            return (int)(number * 2);
        }

        // Method 3: takes a string, converts to int, subtracts 5, returns result
        public int PerformOperation(string numberStr)
        {
            int number = Convert.ToInt32(numberStr); // convert string to int
            return number - 5;
        }
    }
}
