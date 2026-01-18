using System;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main()
        {
            try
            {
                // Ask the user for their age
                Console.WriteLine("Please enter your age:");
                int age = Convert.ToInt32(Console.ReadLine());

                // Check for zero or negative numbers
                if (age <= 0)
                {
                    Console.WriteLine("Age must be a positive number.");
                }
                else
                {
                    // Get the current year
                    int currentYear = DateTime.Now.Year;

                    // Calculate the year of birth
                    int birthYear = currentYear - age;

                    // Display the result
                    Console.WriteLine("You were born in: " + birthYear);
                }
            }
            catch (FormatException)
            {
                // Handles non-numeric input
                Console.WriteLine("Please enter a valid number.");
            }
            catch (Exception)
            {
                // Handles any other unexpected errors
                Console.WriteLine("An unexpected error occurred.");
            }

            // Keeps the console window open
            Console.ReadLine();
        }
    }
}
