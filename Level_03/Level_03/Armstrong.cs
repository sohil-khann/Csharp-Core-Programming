using System;

namespace Level_03
{
    public static class Armstrong
    {
        public static void Run()
        {
            Console.Write("Enter an integer to check for Armstrong: ");
            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Invalid input");
                return;
            }

            int originalNumber = number;
            int sum = 0;

            // Process each digit
            while (originalNumber != 0)
            {
                int remainder = originalNumber % 10;          // get last digit
                int cube = remainder * remainder * remainder; // cube of digit
                sum += cube;                                  // add to sum
                originalNumber /= 10;                         // remove last digit
            }

            if (sum == number)
                Console.WriteLine($"{number} is an Armstrong number.");
            else
                Console.WriteLine($"{number} is NOT an Armstrong number.");
        }
    }
}