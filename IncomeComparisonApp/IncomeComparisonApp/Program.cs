using System;

class IncomeComparisonApp
{
    static void Main()
    {
        Console.WriteLine("Anonymous Income Comparison Program");

        // Person 1 details
        Console.WriteLine("\nPerson 1");
        Console.WriteLine("Hourly Rate?");
        decimal hourlyRate1 = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Hours worked per week?");
        decimal hoursPerWeek1 = Convert.ToDecimal(Console.ReadLine());

        // Person 2 details
        Console.WriteLine("\nPerson 2");
        Console.WriteLine("Hourly Rate?");
        decimal hourlyRate2 = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Hours worked per week?");
        decimal hoursPerWeek2 = Convert.ToDecimal(Console.ReadLine());

        // Calculate annual salaries
        decimal annualSalary1 = hourlyRate1 * hoursPerWeek1 * 52;
        decimal annualSalary2 = hourlyRate2 * hoursPerWeek2 * 52;

        // Display annual salaries
        Console.WriteLine("\nAnnual salary of Person 1:");
        Console.WriteLine(annualSalary1);
        Console.WriteLine("Annual salary of Person 2:");
        Console.WriteLine(annualSalary2);

        // Compare salaries
        bool person1MakesMore = annualSalary1 > annualSalary2;
        Console.WriteLine("\nPerson 1 makes more money than Person 2");
        Console.WriteLine(person1MakesMore);
    }
}
