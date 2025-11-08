using System;

class DailyReport
{
    static void Main()
    {
        Console.WriteLine("Academy of Learning Career College");
        Console.WriteLine("Student Daily Report");

        Console.WriteLine("What is your name?");
        string studentName = Console.ReadLine(); // store input as a string

        Console.WriteLine("What course are you on?");
        string courseName = Console.ReadLine();

        Console.WriteLine("What page number?");
        int pageNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
        bool needsHelp = Convert.ToBoolean(Console.ReadLine());

        Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
        string positiveExperience = Console.ReadLine();

        Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
        string additionalFeedback = Console.ReadLine();

        Console.WriteLine("How many hours did you study today?");
        int studyHours = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");



    }
}
