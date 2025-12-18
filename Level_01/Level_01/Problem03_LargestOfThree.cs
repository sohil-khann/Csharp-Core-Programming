using System;

namespace Level_01
{
    public static class Problem03_LargestOfThree
    {
        public static void Run()
        {
            Console.WriteLine("Enter number1:");
            var a = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Enter number2:");
            var b = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Enter number3:");
            var c = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine($"Is the first number the largest? {a > b && a > c}");
            Console.WriteLine($"Is the second number the largest? {b > a && b > c}");
            Console.WriteLine($"Is the third number the largest? {c > a && c > b}");
        }
    }
}