using System;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main()
        {
            // Create two Employee objects
            Employee emp1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };
            Employee emp2 = new Employee { Id = 1, FirstName = "Jane", LastName = "Smith" };
            Employee emp3 = new Employee { Id = 2, FirstName = "Bob", LastName = "Johnson" };

            // Compare employees using overloaded == operator
            Console.WriteLine(emp1 == emp2); // True, same Id
            Console.WriteLine(emp1 == emp3); // False, different Id

            // Compare using overloaded != operator
            Console.WriteLine(emp1 != emp3); // True

            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();
        }
    }
}
