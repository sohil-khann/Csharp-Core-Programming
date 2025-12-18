using System;

namespace Level_02Programs
{
    public static class LeapYearMultiple
    {
        public static void Run()
        {
            Console.Write("Enter a year (>=1582): ");
            if (!int.TryParse(Console.ReadLine(), out int year))
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            if (year < 1582)
            {
                Console.WriteLine("Year must be >= 1582 (Gregorian calendar).");
                return;
            }

            // Multiple if/else implementation
            if (year % 400 == 0)
            {
                Console.WriteLine($"{year} is a Leap Year (divisible by 400).");
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine($"{year} is NOT a Leap Year (divisible by 100 but not 400).");
            }
            else if (year % 4 == 0)
            {
                Console.WriteLine($"{year} is a Leap Year (divisible by 4 and not by 100).");
            }
            else
            {
                Console.WriteLine($"{year} is NOT a Leap Year.");
            }

            // Single if with logical operators
            if (year >= 1582 && ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)))
            {
                Console.WriteLine("(Single-if check) Leap Year");
            }
            else
            {
                Console.WriteLine("(Single-if check) Not a Leap Year");
            }
        }
    }
}
