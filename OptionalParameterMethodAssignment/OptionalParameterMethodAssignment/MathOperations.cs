using System;

namespace OptionalParameterMethodAssignment
{
    // Class containing math methods
    public class MathOperations
    {
        // Method that takes two integers, second one is optional, adds them together
        public int AddNumbers(int num1, int num2 = 0) // num2 is optional
        {
            return num1 + num2;
        }
    }
}
