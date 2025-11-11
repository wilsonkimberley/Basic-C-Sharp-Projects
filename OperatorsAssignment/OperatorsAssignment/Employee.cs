using System;

namespace OperatorsAssignment
{
    // Employee class
    public class Employee
    {
        // Properties for Employee
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overload == operator to compare Employees by Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Check for nulls to avoid exceptions
            if (ReferenceEquals(emp1, null) && ReferenceEquals(emp2, null))
                return true;
            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
                return false;

            return emp1.Id == emp2.Id;
        }

        // Overload != operator to pair with ==
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }

        // Override Equals and GetHashCode to avoid compiler warnings
        public override bool Equals(object obj)
        {
            if (obj is Employee otherEmployee)
            {
                return this.Id == otherEmployee.Id;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
