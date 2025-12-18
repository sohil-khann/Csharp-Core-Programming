using System;

namespace Level_01
{
    public static class Problem05_Voting
    {
        public static void Run()
        {
            Console.WriteLine("Enter age:");
            if (!int.TryParse(Console.ReadLine(), out var age))
            {
                Console.WriteLine("Invalid input");
                return;
            }

            if (age >= 18)
                Console.WriteLine($"The person's age is {age} and can vote.");
            else
                Console.WriteLine($"The person's age is {age} and cannot vote.");
        }
    }
}