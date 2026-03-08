using System; 

public interface IQuittable
{
    
    void Quit();
}

class Employee : IQuittable
{
    public string Name { get; set; } // Property to store the employee's name

    public int Id { get; set; } // Property to store the employee's ID

    public void Quit() // Implementation of the Quit() method required by the interface
    {
        Console.WriteLine(Name + " has quit the job."); // This message will appear in the console when the method is called
    }
}

class Program
{
    static void Main(string[] args) // The entry point of the console application
    {
        Employee emp = new Employee(); // Create a new Employee        
        emp.Name = "Danny";
        emp.Id = 1;

        IQuittable quittableEmployee = emp; // POLYMORPHISM: Create a variable of type IQuittable

        quittableEmployee.Quit(); // Call the Quit() method through the interface reference


        Console.ReadLine(); // Keeps the console window open until the user presses Enter
    }
}