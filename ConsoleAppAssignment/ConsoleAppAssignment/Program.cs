using System;
using System.Collections.Generic;

class ConsoleAppAssignments
{
    static void Main()
    {
        // ===============================
        // PART 1: Array string concatenation
        // ===============================
        string[] phrases = { "The sky is", "Today feels", "Learning C# is", "This course is" };
        Console.WriteLine("PART 1: Array String Concatenation");
        Console.Write("Enter a word or phrase to add to each sentence: ");
        string userText = Console.ReadLine();

        for (int i = 0; i < phrases.Length; i++)
        {
            phrases[i] += " " + userText;
        }

        Console.WriteLine("Updated sentences:");
        foreach (string phrase in phrases)
        {
            Console.WriteLine(phrase);
        }
        Console.WriteLine();

        // ===============================
        // PART 2: Infinite loop fixed with break
        // ===============================
        Console.WriteLine("PART 2: Infinite Loop (type 'exit' to stop)");
        bool keepRunning = true;
        while (keepRunning)
        {
            Console.Write("Enter text (or 'exit' to stop): ");
            string input = Console.ReadLine();
            if (input.ToLower() == "exit")
            {
                keepRunning = false;
                Console.WriteLine("Loop ended successfully!");
            }
            else
            {
                Console.WriteLine($"You entered: {input}");
            }
        }
        Console.WriteLine();

        // ===============================
        // PART 3: Loops using < and <= operators
        // ===============================
        Console.WriteLine("PART 3: Loops with < and <= operators");
        Console.WriteLine("< loop:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"i = {i}");
        }

        Console.WriteLine("<= loop:");
        for (int j = 0; j <= 5; j++)
        {
            Console.WriteLine($"j = {j}");
        }
        Console.WriteLine();

        // ===============================
        // PART 4: List search (unique items)
        // ===============================
        Console.WriteLine("PART 4: List Search (Unique Items)");
        List<string> colors = new List<string> { "red", "green", "blue", "yellow", "purple" };
        Console.Write("Enter a color to search for: ");
        string colorInput = Console.ReadLine();
        bool foundColor = false;

        for (int i = 0; i < colors.Count; i++)
        {
            if (colors[i].Equals(colorInput, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Match found! '{colorInput}' is at index {i}.");
                foundColor = true;
                break; // Stop after first match
            }
        }
        if (!foundColor)
        {
            Console.WriteLine($"'{colorInput}' is not in the list.");
        }
        Console.WriteLine();

        // ===============================
        // PART 5: List search (duplicates)
        // ===============================
        Console.WriteLine("PART 5: List Search (Duplicates)");
        List<string> fruits = new List<string> { "apple", "banana", "orange", "apple", "grape", "banana" };
        Console.Write("Enter a fruit to search for: ");
        string fruitInput = Console.ReadLine();
        bool foundFruit = false;

        for (int i = 0; i < fruits.Count; i++)
        {
            if (fruits[i].Equals(fruitInput, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Match found at index {i}.");
                foundFruit = true;
                // No break here to find all matches
            }
        }
        if (!foundFruit)
        {
            Console.WriteLine($"'{fruitInput}' is not in the list.");
        }
        Console.WriteLine();

        // ===============================
        // PART 6: Detect duplicates with foreach
        // ===============================
        Console.WriteLine("PART 6: Detect Duplicates with foreach");
        List<string> letters = new List<string> { "A", "B", "C", "D", "C", "B" };
        HashSet<string> seenItems = new HashSet<string>();

        foreach (string letter in letters)
        {
            if (seenItems.Contains(letter))
            {
                Console.WriteLine($"{letter} - this item is a duplicate");
            }
            else
            {
                Console.WriteLine($"{letter} - this item is unique");
                seenItems.Add(letter);
            }
        }

        Console.WriteLine("\nAll parts completed. Press Enter to exit.");
        Console.ReadLine();
    }
}
