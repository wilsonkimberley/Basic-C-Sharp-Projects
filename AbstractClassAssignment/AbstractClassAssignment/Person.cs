using System;

namespace AbstractClassAssignment
{
    // Abstract class cannot be instantiated
    public abstract class Person
    {
        // Properties for first and last name
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Abstract method - must be implemented by derived classes
        public abstract void SayName();
    }
}
