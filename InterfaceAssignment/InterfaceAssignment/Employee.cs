using System;

namespace InterfaceAssignment
{
    // Employee class implements IQuittable interface
    public class Employee : IQuittable
    {
        // Properties for first and last name
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Method from IQuittable interface
        public void Quit()
        {
            Console.WriteLine($"{FirstName} {LastName} has quit the job.");
        }
    }
}
