using System;
using System.Linq;

namespace CodeFirstStudentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create database context
            using (var context = new SchoolContext())
            {
                // Create a new student
                var student = new Student
                {
                    FirstName = "John",
                    LastName = "Doe",
                    EnrollmentDate = DateTime.Now
                };

                // Add student to database
                context.Students.Add(student);

                // Save changes to database
                context.SaveChanges();

                Console.WriteLine("Student added successfully!");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
