using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list of integers
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

        // Ask the user for a number to divide by
        Console.Write("Enter a number to divide each number in the list by: ");
        string userInput = Console.ReadLine();

        try
        {
            // Convert user input to integer
            int divisor = Convert.ToInt32(userInput);

            // Loop through each number in the list
            foreach (int number in numbers)
            {
                // Divide the number by the user's input and display the result
                Console.WriteLine($"{number} / {divisor} = {number / divisor}");
            }
        }
        catch (DivideByZeroException ex)
        {
            // Handles division by zero error
            Console.WriteLine("Error: Cannot divide by zero.");
        }
        catch (FormatException ex)
        {
            // Handles invalid input that cannot be converted to int
            Console.WriteLine("Error: Invalid input. Please enter a valid integer.");
        }
        catch (Exception ex)
        {
            // Handles any other unexpected errors
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }

        // Message outside the try/catch to show program continued
        Console.WriteLine("Program has continued after the try/catch block.");
        Console.WriteLine("Press Enter to exit.");
        Console.ReadLine();
    }
}
