using System;

public class Employee // Define the Employee class
{
    public int Id { get; set; } // Property to store the employee ID

    public string FirstName { get; set; } // Property to store the employee first name

    public string LastName { get; set; } // Property to store the employee last name


    public static bool operator ==(Employee emp1, Employee emp2) // Overload the == operator to compare two Employee objects
    {

        if (ReferenceEquals(emp1, emp2)) // Check if both objects are null
        {
            return true;
        }


        if (emp1 is null || emp2 is null)  // If one of them is null but not both
        {
            return false;
        }


        return emp1.Id == emp2.Id; // Compare employees based on their Id
    }


    public static bool operator !=(Employee emp1, Employee emp2) // Overload the != operator (required pair for ==)
    {

        return !(emp1 == emp2);  // Return the opposite result of ==
    }


    public override bool Equals(object obj) // Override Equals method for consistency with ==
    {

        if (obj is Employee employee) // Check if the object is an Employee
        {
            return this.Id == employee.Id;
        }
        return false;
    }


    public override int GetHashCode() // Override GetHashCode because Equals was overridden
    {

        return Id.GetHashCode(); // Use Id to generate hash code
    }
}