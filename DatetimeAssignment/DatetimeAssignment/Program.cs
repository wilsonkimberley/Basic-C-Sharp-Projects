using System;

namespace DatetimeAssignment
{
    class Program
    {
        static void Main()
        {
            // Print the current date and time
            DateTime currentTime = DateTime.Now;
            Console.WriteLine("Current date and time: " + currentTime);

            // Ask the user for a number
            Console.WriteLine("Enter a number of hours:");
            string userInput = Console.ReadLine();

            // Convert the user input to an integer
            int hoursToAdd;
            if (int.TryParse(userInput, out hoursToAdd))
            {
                // Calculate the new time by adding the input hours
                DateTime futureTime = currentTime.AddHours(hoursToAdd);

                // Display the time in X hours
                Console.WriteLine($"The time in {hoursToAdd} hours will be: {futureTime}");
            }
            else
            {
                // Display error message if input is not a valid number
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            // Pause before exiting so the user can see the output
            Console.WriteLine("\nPress Enter to exit.");
            Console.ReadLine();
        }
    }
}
