/*3. Extend or Create a NumberChecker utility class and perform the following task. Call
from the main() method the different methods and display results. Make sure all are static
methods
Hint =>
a. Method to find the count of digits in the number and a Method to Store the digits of
the number in a digits array
b. Method to find the sum of the digits of a number using the digits array
c. Method to find the sum of the squares of the digits of a number using the digits array.
Use Math.Pow() method
d. Method to Check if a number is a Harshad number using a digits array. A number is
called a Harshad number if it is divisible by the sum of its digits. For e.g. 21
e. Method to find the frequency of each digit in the number. Create a 2D array to store
the frequency with digit in the first column and frequency in the second column.*/
using System;
internal static class NumberChecker02
{
    public static void Main()
    {
        Console.Write("Enter Number: ");
        int number = int.Parse(Console.ReadLine());
        int digitCount = CountDigits(number);
        Console.WriteLine($"Count of digits in {number}: {digitCount}");
        int[] digitsArray = StoreDigitsInArray(number);
        Console.WriteLine($"Digits in {number}: {string.Join(", ", digitsArray)}");
        int sumOfDigits = SumOfDigits(digitsArray);
        Console.WriteLine($"Sum of digits in {number}: {sumOfDigits}");
        double sumOfSquares = SumOfSquaresOfDigits(digitsArray);
        Console.WriteLine($"Sum of squares of digits in {number}: {sumOfSquares}");
        bool isHarshad = IsHarshadNumber(number, sumOfDigits);
        Console.WriteLine($"{number} is a Harshad number: {isHarshad}");
        int[,] frequencyArray = DigitFrequency(number);
        Console.WriteLine("Digit Frequency:");
        for (int i = 0; i < frequencyArray.GetLength(0); i++)
        {
            Console.WriteLine($"Digit: {frequencyArray[i, 0]}, Frequency: {frequencyArray[i, 1]}");
        }
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
    public static int SumOfDigits(int[] digits)
    {
        int sum = 0;
        foreach (int digit in digits)
        {
            sum += digit;
        }
        return sum;
    }
    public static double SumOfSquaresOfDigits(int[] digits)
    {
        double sum = 0;
        foreach (int digit in digits)
        {
            sum += Math.Pow(digit, 2);
        }
        return sum;
    }
    public static bool IsHarshadNumber(int number, int sumOfDigits)
    {
        return number % sumOfDigits == 0;
    }
    public static int[,] DigitFrequency(int number)
    {
        int[] frequency = new int[10];
        string numberStr = number.ToString();
        foreach (char digitChar in numberStr)
        {
            int digit = int.Parse(digitChar.ToString());
            frequency[digit]++;
        }
        int count = 0;
        for (int i = 0; i < frequency.Length; i++)
        {
            if (frequency[i] > 0)
            {
                count++;
            }
        }
        int[,] freqArray = new int[count, 2];
        int index = 0;
        for (int i = 0; i < frequency.Length; i++)
        {
            if (frequency[i] > 0)
            {
                freqArray[index, 0] = i;
                freqArray[index, 1] = frequency[i];
                index++;
            }
        }
        return freqArray;
    }   
    }