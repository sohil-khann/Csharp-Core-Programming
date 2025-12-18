using System;

namespace Level_01
{
    public static class Problem06_PosNegZero
    {
        public static void Run()
        {
            Console.WriteLine("Enter a number:");
            if (!double.TryParse(Console.ReadLine(), out var value))
            {
                Console.WriteLine("Invalid input");
                return;
            }

            if (value > 0)
                Console.WriteLine("positive");
            else if (value < 0)
                Console.WriteLine("negative");
            else
                Console.WriteLine("zero");
        }
    }
}