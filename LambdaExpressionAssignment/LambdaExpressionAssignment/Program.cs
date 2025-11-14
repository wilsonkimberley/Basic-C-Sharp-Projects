using System;
using System.Collections.Generic;
using System.Linq; // allows lambda features such as Where()

namespace LambdaExpressionAssignment
{
    class Program
    {
        static void Main()
        {
            // Create a list of employees (at least two named Joe)
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, FirstName = "Joe",   LastName = "Smith" },
                new Employee { Id = 2, FirstName = "Jane",  LastName = "Doe" },
                new Employee { Id = 3, FirstName = "Bob",   LastName = "Johnson" },
                new Employee { Id = 4, FirstName = "Alice", LastName = "Williams" },
                new Employee { Id = 5, FirstName = "Joe",   LastName = "Brown" },
                new Employee { Id = 6, FirstName = "Mary",  LastName = "Davis" },
                new Employee { Id = 7, FirstName = "Tom",   LastName = "Wilson" },
                new Employee { Id = 8, FirstName = "Sara",  LastName = "Miller" },
                new Employee { Id = 9, FirstName = "Carl",  LastName = "Taylor" },
                new Employee { Id = 10, FirstName = "Nina", LastName = "Anderson" }
            };

            // -----------------------------------------
            // 1) foreach loop to find all "Joe" employees
            // -----------------------------------------
            List<Employee> joesForeach = new List<Employee>();

            foreach (Employee emp in employees)
            {
                if (emp.FirstName == "Joe")     // check each employee's first name
                {
                    joesForeach.Add(emp);       // add match to the new list
                }
            }

            Console.WriteLine("Employees named 'Joe' (foreach):");
            foreach (var e in joesForeach)
            {
                Console.WriteLine($"{e.Id} - {e.FirstName} {e.LastName}");
            }
            Console.WriteLine();

            // -----------------------------------------
            // 2) lambda expression to find all "Joe" employees
            // -----------------------------------------
            List<Employee> joesLambda =
                employees.Where(e => e.FirstName == "Joe").ToList();

            Console.WriteLine("Employees named 'Joe' (lambda):");
            foreach (var e in joesLambda)
            {
                Console.WriteLine($"{e.Id} - {e.FirstName} {e.LastName}");
            }
            Console.WriteLine();

            // -----------------------------------------
            // 3) lambda to find employees with Id > 5
            // -----------------------------------------
            List<Employee> idGreaterThan5 =
                employees.Where(e => e.Id > 5).ToList();

            Console.WriteLine("Employees with Id > 5:");
            foreach (var e in idGreaterThan5)
            {
                Console.WriteLine($"{e.Id} - {e.FirstName} {e.LastName}");
            }
            Console.WriteLine();

            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();
        }
    }
}
