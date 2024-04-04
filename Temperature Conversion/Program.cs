using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Select conversion:");
        Console.WriteLine("1. Celsius to Fahrenheit");
        Console.WriteLine("2. Fahrenheit to Celsius");
        Console.Write("Enter your choice (1 or 2): ");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.Write("Enter temperature in Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = CelsiusToFahrenheit(celsius);
            Console.WriteLine($"{celsius}°C is equal to {fahrenheit}°F");
        }
        else if (choice == "2")
        {
            Console.Write("Enter temperature in Fahrenheit: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            double celsius = FahrenheitToCelsius(fahrenheit);
            Console.WriteLine($"{fahrenheit}°F is equal to {celsius}°C");
        }
        else
        {
            Console.WriteLine("Invalid choice. Please enter either 1 or 2.");
        }
    }

    static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }
}
