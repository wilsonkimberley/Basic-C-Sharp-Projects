using System;

namespace MethodsAndObjectsAssignment
{
    // Base class representing a person
    public class Person
    {
        // Property for first name
        public string FirstName { get; set; }

        // Property for last name
        public string LastName { get; set; }

        // Void method to display full name
        public void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }
}
