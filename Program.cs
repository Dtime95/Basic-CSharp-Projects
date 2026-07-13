using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Ask for package weight
            Console.Write("Please enter the package weight: ");
            decimal weight = Convert.ToDecimal(Console.ReadLine());

            // Check if package is too heavy
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return;
            }

            // Ask for package width
            Console.Write("Please enter the package width: ");
            decimal width = Convert.ToDecimal(Console.ReadLine());

            // Ask for package height
            Console.Write("Please enter the package height: ");
            decimal height = Convert.ToDecimal(Console.ReadLine());

            // Ask for package length
            Console.Write("Please enter the package length: ");
            decimal length = Convert.ToDecimal(Console.ReadLine());

            // Check total dimensions
            if ((width + height + length) > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                return;
            }

            // Calculate shipping quote
            decimal quote = (width * height * length * weight) / 100;

            // Display quote
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
            Console.WriteLine("Thank you!");

            Console.ReadLine();
        }
    }
}
