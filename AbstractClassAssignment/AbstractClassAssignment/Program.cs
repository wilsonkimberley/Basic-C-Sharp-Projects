using System;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main()
        {
            // Instantiate an Employee object
            Employee employee = new Employee();

            // Set the first and last name
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            // Call the SayName method (implemented in Employee class)
            employee.SayName();

            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();
        }
    }
}
