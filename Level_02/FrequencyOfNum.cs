/*10.Create a program to take a number as input find the frequency of each digit in the number
using an array and display the frequency of each digit
Hint =>
a. Take the input for a number
b. Find the count of digits in the number
c. Find the digits in the number and save them in an array
d. Find the frequency of each digit in the number. For this define a frequency array of size
10, Loop through the digits array, and increase the frequency of each digit
e. Display the frequency of each digit in the number*/

using System;
internal static class FrequencyOfNum
{
    internal static void runMethod()
    {
        Console.WriteLine("Enter a number:");
        string input = Console.ReadLine();
        int[] frequency = new int[10];
        foreach (char c in input)
        {
            if (char.IsDigit(c))
            {
                int digit = c - '0';
                frequency[digit]++;
            }
        }
        Console.WriteLine("Digit Frequency:");
        for (int i = 0; i < frequency.Length; i++)
        {
            if (frequency[i] > 0)
            {
                Console.WriteLine($"Digit {i}: {frequency[i]} time");
            }
        }
    }
}