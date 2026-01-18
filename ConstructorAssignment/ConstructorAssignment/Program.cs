using System;

namespace ConstructorAssignment
{
    // Create a class to demonstrate constructors
    class Person
    {
        // Create a const variable (cannot be changed)
        public const string Species = "Human";

        // Property to store the person's name
        public string Name { get; set; }

        // First constructor (takes no parameters)
        public Person() : this("Unknown")
        {
            // This constructor calls the second constructor
        }

        // Second constructor (takes a name parameter)
        public Person(string name)
        {
            // Assigns the provided name to the Name property
            Name = name;
        }
    }

    class Program
    {
        static void Main()
        {
            // Create a variable using the 'var' keyword
            var person = new Person("Alex");

            // Display the person's name
            Console.WriteLine("Name: " + person.Name);

            // Display the const variable
            Console.WriteLine("Species: " + Person.Species);

            // Pause the program so output can be read
            Console.ReadLine();
        }
    }
}
