using System;
using System.IO;

namespace InputAssignment
{
    class Program
    {
        static void Main()
        {
            // Ask the user for a number
            Console.WriteLine("Please enter a number:");
            string userInput = Console.ReadLine();

            // Specify the path of the text file to store input
            string filePath = "UserNumber.txt";

            // Write the user input to the text file
            File.WriteAllText(filePath, userInput);

            // Read the content of the file
            string fileContent = File.ReadAllText(filePath);

            // Display the content of the file back to the user
            Console.WriteLine("\nHere is the number you entered from the file:");
            Console.WriteLine(fileContent);

            // Pause before exiting so the user can see output
            Console.WriteLine("\nPress Enter to exit.");
            Console.ReadLine();
        }
    }
}
