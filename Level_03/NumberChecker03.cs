/*4. Extend or Create a NumberChecker utility class and perform the following task. Call
from the main() method the different methods and display results. Make sure all are static
methods
Hint =>
a. Method to find the count of digits in the number and a Method to Store the digits of
the number in a digits array
b. Method to reverse the digits array
c. Method to compare two arrays and check if they are equal
d. Method to check if a number is a palindrome using the Digits. A palindrome number
is a number that remains the same when its digits are reversed.
e. Method to Check if a number is a duck number using the digits array. A duck number
is a number that has a non-zero digit present in it*/
using System;

internal static class NumberChecker03
{
    public static void Main()
    {
        Console.Write("Enter Number: ");
        int number = int.Parse(Console.ReadLine());
        int digitCount = CountDigits(number);
        Console.WriteLine($"Count of digits in {number}: {digitCount}");
        int[] digitsArray = StoreDigitsInArray(number);
        Console.WriteLine($"Digits in {number}: {string.Join(", ", digitsArray)}");
        int[] reversedArray = ReverseDigitsArray(digitsArray);
        Console.WriteLine($"Reversed Digits: {string.Join(", ", reversedArray)}");
        bool isPalindrome = AreArraysEqual(digitsArray, reversedArray);
        Console.WriteLine($"{number} is a Palindrome: {isPalindrome}");
        bool isDuckNumber = IsDuckNumber(digitsArray);
        Console.WriteLine($"{number} is a Duck Number: {isDuckNumber}");
    }
    public static int CountDigits(int number)
    {
        return number.ToString().Length;
    }
    public static int[] StoreDigitsInArray(int number)
    {
        string numberStr = number.ToString();
        int[] digits = new int[numberStr.Length];
        for (int i = 0; i < numberStr.Length; i++)
        {
            digits[i] = int.Parse(numberStr[i].ToString());
        }
        return digits;
    }
    public static int[] ReverseDigitsArray(int[] digits)
    {
        int[] reversed = new int[digits.Length];
        for (int i = 0; i < digits.Length; i++)
        {
            reversed[i] = digits[digits.Length - 1 - i];
        }
        return reversed;
    }
    public static bool AreArraysEqual(int[] array1, int[] array2)
    {
        if (array1.Length != array2.Length) return false;
        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i] != array2[i]) return false;
        }
        return true;
    }
    public static bool IsDuckNumber(int[] digits)
    {
        foreach (int digit in digits)
        {
            if (digit != 0) return true;
        }
        return false;
    }
}
