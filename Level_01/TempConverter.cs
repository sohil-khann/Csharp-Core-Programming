/*8. Temperature Converter:
Write a program that converts temperatures between Fahrenheit and Celsius.
The program should have separate functions for converting from Fahrenheit to
Celsius and from Celsius to Fahrenheit.
*/
using System;

internal static class TempConverter
{
    //for converting F to C
    private static double FahrenheitToCelsius(double fahrenheit) 
    {
        return (fahrenheit - 32) * 5 / 9;
    }
    //for converting C to F
    private static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }
    //entry point
    public static void Main()
    {
        Console.WriteLine("Temperature Converter");
        Console.WriteLine("Choose conversion type:");
        Console.WriteLine("1. Fahrenheit to Celsius");
        Console.WriteLine("2. Celsius to Fahrenheit");
        Console.Write("Enter your choice (1 or 2): ");
        //Choice input
        int choice = int.Parse(Console.ReadLine());
        double inputTemp, convertedTemp;

        //Perform task based on user choice
        switch (choice)
        {
            case 1:
                Console.Write("Enter temperature in Fahrenheit: ");
                inputTemp = double.Parse(Console.ReadLine());
                //Convert F to C method call
                convertedTemp = FahrenheitToCelsius(inputTemp);
                Console.WriteLine($"{inputTemp}°F is equal to {convertedTemp:F2}°C");
                break;
            case 2:
                Console.Write("Enter temperature in Celsius: ");
                inputTemp = double.Parse(Console.ReadLine());
                //Convert C to F method call
                convertedTemp = CelsiusToFahrenheit(inputTemp);
                Console.WriteLine($"{inputTemp}°C is equal to {convertedTemp:F2}°F");
                break;
            default:
                Console.WriteLine("Invalid choice. Please select 1 or 2.");
                break;
        }
    }
}