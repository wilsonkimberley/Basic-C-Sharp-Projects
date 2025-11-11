using System;

namespace AbstractClassAssignment
{
    // Employee class inherits from abstract Person class
    public class Employee : Person
    {
        // Implement the abstract SayName method
        public override void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }
}
