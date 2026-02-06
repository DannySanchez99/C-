using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Branching_Assignment_Submission
{
    class Program
    {
        // Main method, entry point of the program
        static async Task Main(string[] args)
        {
            // Welcome message
            Console.WriteLine("Welcome to package express, please follow the instructions below.");
            await Task.Delay(3000); // Small delay for better user experience

            // Ask for package weight
            Console.Write("Please enter the package weight: ");

            // Validate weight input and check if it's within the limit
            if (double.TryParse(Console.ReadLine(), out double weight) && weight <= 50)
            {
                Console.WriteLine("Perfect! The weight of the package is within limit!");
                await Task.Delay(3000);

                // Ask for package width
                Console.Write("Please enter the package width: ");

                // Validate width input
                if (double.TryParse(Console.ReadLine(), out double width))
                {
                    await Task.Delay(3000);

                    // Ask for package height
                    Console.Write("Perfect! Please enter the package height: ");

                    // Validate height input
                    if (double.TryParse(Console.ReadLine(), out double height))
                    {
                        await Task.Delay(3000);

                        // Ask for package length
                        Console.Write("Perfect! Please enter the package length: ");

                        // Validate length input
                        if (double.TryParse(Console.ReadLine(), out double length))
                        {
                            Console.WriteLine("Perfect! We are processing your delivery express...");
                            await Task.Delay(3000);

                            // Calculate the package size (volume)
                            double package = width + height + length;

                            // Check if package dimensions are within allowed limit
                            if (package <= 50)
                            {
                                // Calculate total shipping cost
                                double total = (package * weight) / 100;
                                decimal dectotal = (decimal)total;

                                // Display final price
                                Console.WriteLine(
                                    "Perfect! Your estimated total for shipping this package is: $" + dectotal.ToString("F2"));
                            }
                            else
                            {
                                // Package dimensions exceed the allowed size
                                Console.WriteLine(
                                    "Package too big to be shipped via Package Express.");
                            }
                        }
                        else
                        {
                            // Invalid length input
                            Console.WriteLine("Invalid length entered.");
                            return;
                        }
                    }
                    else
                    {
                        // Invalid height input
                        Console.WriteLine("Invalid height entered.");
                        return;
                    }
                }
                else
                {
                    // Invalid width input
                    Console.WriteLine("Invalid width entered.");
                    return;
                }
            }
            else
            {
                // Package weight exceeds the allowed limit
                Console.WriteLine(
                    "Package too heavy to be shipped via Package Express. Have a good day.");
            }
        }
    }
}