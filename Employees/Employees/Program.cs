using System;

class Program
{
    static void Main(string[] args)
    {
        // Create the first Employee object
        Employee employee1 = new Employee();

        // Assign values to employee1 properties
        employee1.Id = 1;
        employee1.FirstName = "John";
        employee1.LastName = "Smith";

        // Create the second Employee object
        Employee employee2 = new Employee();

        // Assign values to employee2 properties
        employee2.Id = 1;
        employee2.FirstName = "Sarah";
        employee2.LastName = "Johnson";

        // Compare the two employees using the overloaded == operator
        bool areEqual = employee1 == employee2;

        // Display the comparison result in the console
        Console.WriteLine("Are the two employees equal? " + areEqual);

        // Pause the program so the console stays open
        Console.ReadLine();
    }
}