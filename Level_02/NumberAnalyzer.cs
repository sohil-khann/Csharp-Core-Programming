/*
9. Write a program to take user input for 5 numbers and check whether a number is positive or negative. Further for positive numbers check if the number is even or odd. Finally compare the first and last elements of the array and display if they are equal, greater, or less Hint =>
a. Write a Method to Check whether the number is positive or negative
b. Write a Method to check whether the number is even or odd
c. Write a Method to compare two numbers and return 1 if number1 > number2 or 0 if both are equal or -1 if number1 < number2
d. In the main program, Loop through the array using the length call the method isPositive() and if positive call method isEven() and print accordingly
e. If the number is negative, print negative.
f. Finally compare the first and last element of the array by calling the method compare() and display if they are equal, greater, or less
*/

using System;

namespace Level_02
{
    public class NumberAnalyzer
    {
        public static void runMethod()
        {
            int[] numbers = new int[5];
            Console.WriteLine("Enter 5 numbers:");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Number {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int val))
                {
                    numbers[i] = val;
                }
            }

            Console.WriteLine("\nAnalysis:");
            foreach (int num in numbers)
            {
                if (IsPositive(num))
                {
                    string parity = IsEven(num) ? "Even" : "Odd";
                    Console.WriteLine($"{num} is Positive and {parity}.");
                }
                else
                {
                    Console.WriteLine($"{num} is Negative.");
                }
            }

            int comparison = Compare(numbers[0], numbers[numbers.Length - 1]);
            Console.Write("\nComparison of first and last elements: ");
            if (comparison == 1)
            {
                Console.WriteLine($"{numbers[0]} is greater than {numbers[numbers.Length - 1]}.");
            }
            else if (comparison == 0)
            {
                Console.WriteLine($"{numbers[0]} is equal to {numbers[numbers.Length - 1]}.");
            }
            else
            {
                Console.WriteLine($"{numbers[0]} is less than {numbers[numbers.Length - 1]}.");
            }
        }

        public static bool IsPositive(int number)
        {
            return number >= 0;
        }

        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public static int Compare(int number1, int number2)
        {
            if (number1 > number2) return 1;
            if (number1 < number2) return -1;
            return 0;
        }
    }
}
