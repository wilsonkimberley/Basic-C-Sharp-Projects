using System;

class CarInsuranceApp
{
    static void Main()
    {
        // Ask for age
        Console.WriteLine("What is your age?");
        int age = Convert.ToInt32(Console.ReadLine());

        // Ask about DUI
        Console.WriteLine("Have you ever had a DUI? (true/false)");
        bool hasDUI = Convert.ToBoolean(Console.ReadLine());

        // Ask about speeding tickets
        Console.WriteLine("How many speeding tickets do you have?");
        int speedingTickets = Convert.ToInt32(Console.ReadLine());

        // Determine if applicant is qualified
        bool isQualified = (age > 15) && (!hasDUI) && (speedingTickets <= 3);

        // Display the result
        Console.WriteLine("Qualified?");
        Console.WriteLine(isQualified);
    }
}
