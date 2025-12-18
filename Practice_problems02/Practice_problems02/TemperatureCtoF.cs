using System;

namespace Practice_problems02
{
    public static class TemperatureCtoF
    {
        public static void Run()
        {
            double celsius;
            while (true)
            {
                Console.Write("Enter temperature in Celsius: ");
                if (double.TryParse(Console.ReadLine(), out celsius))
                    break;
                Console.WriteLine("Invalid input. Try again.");
            }

            double fahrenheitResult = (celsius * 9.0 / 5.0) + 32.0;
            Console.WriteLine($"The {celsius} Celsius is {fahrenheitResult} Fahrenheit");
        }
    }
}