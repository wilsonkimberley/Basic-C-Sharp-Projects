using System;
using System.Text;

class StringAssignmentApp
{
    static void Main()
    {
        // Concatenate three strings
        string firstName = "John";
        string middleName = "F.";
        string lastName = "Doe";
        string fullName = firstName + " " + middleName + " " + lastName;
        Console.WriteLine("Full Name: " + fullName);

        // Convert to uppercase
        string upperName = fullName.ToUpper();
        Console.WriteLine("Full Name in Uppercase: " + upperName);

        // Build a paragraph using StringBuilder
        StringBuilder paragraph = new StringBuilder();
        paragraph.Append("This is the first sentence. ");
        paragraph.Append("Here comes the second sentence. ");
        paragraph.Append("Finally, this is the third sentence.");

        Console.WriteLine("\nParagraph built with StringBuilder:");
        Console.WriteLine(paragraph.ToString());
    }
}
