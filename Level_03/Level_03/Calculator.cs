using System;

namespace Level_03
{
    public static class Calculator
    {
        public static void Run()
        {
            Console.Write("Enter first number: ");
            if (!double.TryParse(Console.ReadLine(), out double first)) { Console.WriteLine("Invalid input"); return; }
            Console.Write("Enter second number: ");
            if (!double.TryParse(Console.ReadLine(), out double second)) { Console.WriteLine("Invalid input"); return; }
            Console.Write("Enter operator (+, -, *, /): ");
            string? op = Console.ReadLine();

            if (op == null)
            {
                Console.WriteLine("Invalid operator");
                return;
            }

            switch (op)
            {
                case "+":
                    Console.WriteLine($"Result: {first + second}");
                    break;
                case "-":
                    Console.WriteLine($"Result: {first - second}");
                    break;
                case "*":
                    Console.WriteLine($"Result: {first * second}");
                    break;
                case "/":
                    if (second == 0)
                        Console.WriteLine("Cannot divide by zero");
                    else
                        Console.WriteLine($"Result: {first / second}");
                    break;
                default:
                    Console.WriteLine("Invalid Operator");
                    break;
            }
        }
    }
}