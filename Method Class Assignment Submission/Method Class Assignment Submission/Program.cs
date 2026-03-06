using System; 

class MathOperations
{
    // Create a void method that takes two integers as parameters
    // The method performs a math operation on the first integer
    public void DoMath(int number1, int number2)
    {
       
        int result = number1 * 2; // Perform a math operation on the first integer (example: multiply by 2)
        Console.WriteLine("Result of math operation on first number: " + result);   // Display the result of the math operation     
        Console.WriteLine("Second number is: " + number2); // Display the second integer
    }
}

class Program
{
    static void Main(string[] args)
    {
       
        MathOperations mathObject = new MathOperations();  // Instantiate create the MathOperations class

        // Call the method and pass two integers normally
        mathObject.DoMath(5, 10);
        mathObject.DoMath(number1: 7, number2: 20);
      
        Console.ReadLine(); // Wait for user 
    }
}