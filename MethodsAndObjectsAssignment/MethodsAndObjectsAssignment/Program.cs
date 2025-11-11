using System;

namespace MethodsAndObjectsAssignment
{
    class Program
    {
        static void Main()
        {
            // Instantiate an Employee object
            Employee employee = new Employee();

            // Set first and last name
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            // Set employee ID (optional for this example)
            employee.Id = 12345;

            // Call the inherited SayName method
            employee.SayName();

            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();
        }
    }
}
