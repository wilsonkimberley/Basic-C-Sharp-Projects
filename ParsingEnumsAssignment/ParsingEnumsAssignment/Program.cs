using System;

namespace ParsingEnumsAssignment
{
    // Enum for days of the week
    public enum DaysOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    class Program
    {
        static void Main()
        {
            // Ask the user to enter the current day of the week
            Console.WriteLine("Enter the current day of the week:");

            // Read user input
            string input = Console.ReadLine();

            try
            {
                // Attempt to parse the input string to the DaysOfWeek enum
                DaysOfWeek currentDay = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), input, true);

                // Display the parsed day
                Console.WriteLine($"You entered: {currentDay}");
            }
            catch
            {
                // If parsing fails, display an error message
                Console.WriteLine("Please enter an actual day of the week.");
            }

            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();
        }
    }
}
