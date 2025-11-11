using System;

namespace InterfaceAssignment
{
    class Program
    {
        static void Main()
        {
            // Create an Employee object
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            // Use polymorphism: treat the Employee object as an IQuittable
            IQuittable quittableEmployee = employee;

            // Call the Quit method via the interface
            quittableEmployee.Quit();

            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();
        }
    }
}
