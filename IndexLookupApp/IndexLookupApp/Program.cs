using System;
using System.Collections.Generic;

class IndexLookupApp
{
    static void Main()
    {
        // 1) String array example
        string[] words = { "apple", "banana", "cherry", "date", "elderberry" }; // string array
        Console.WriteLine("String array contains " + words.Length + " items (indexes 0 to " + (words.Length - 1) + ").");
        Console.Write("Enter an index to see the string at that position: ");
        if (int.TryParse(Console.ReadLine(), out int index1))
        {
            if (index1 >= 0 && index1 < words.Length)
            {
                Console.WriteLine("Value at index " + index1 + ": " + words[index1]);
            }
            else
            {
                Console.WriteLine("That index does not exist in the string array.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a whole number for the index.");
        }

        Console.WriteLine(); // blank line for readability

        // 2) Integer array example
        int[] numbers = { 10, 20, 30, 40, 50 }; // integer array
        Console.WriteLine("Integer array contains " + numbers.Length + " items (indexes 0 to " + (numbers.Length - 1) + ").");
        Console.Write("Enter an index to see the integer at that position: ");
        if (int.TryParse(Console.ReadLine(), out int index2))
        {
            if (index2 >= 0 && index2 < numbers.Length)
            {
                Console.WriteLine("Value at index " + index2 + ": " + numbers[index2]);
            }
            else
            {
                Console.WriteLine("That index does not exist in the integer array.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a whole number for the index.");
        }

        Console.WriteLine(); // blank line for readability

        // 3) List<string> example
        List<string> items = new List<string> { "red", "green", "blue", "yellow" }; // list of strings
        Console.WriteLine("List contains " + items.Count + " items (indexes 0 to " + (items.Count - 1) + ").");
        Console.Write("Enter an index to see the list item at that position: ");
        if (int.TryParse(Console.ReadLine(), out int index3))
        {
            if (index3 >= 0 && index3 < items.Count)
            {
                Console.WriteLine("Value at index " + index3 + ": " + items[index3]);
            }
            else
            {
                Console.WriteLine("That index does not exist in the list.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a whole number for the index.");
        }

        // End of program message
        Console.WriteLine("\nPress Enter to exit.");
        Console.ReadLine();
    }
}
