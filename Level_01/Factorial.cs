/*6. Factorial Using Recursion:
Write a program that calculates the factorial of a number using a recursive function.
Include modular code to separate input, calculation, and output processes.*/
using System;
internal class Factorial
{
    private static int GetInput() //for taking input
    {
        Console.Write("Enter a number to calculate its factorial: ");
        return int.Parse(Console.ReadLine());
    }
    //for calculating factorial
    private static long CalculateFactorial(int number) 
    {
        if (number <= 1)
        {
            return 1;
        }
        return number * CalculateFactorial(number - 1);
    }
    //for displaying result
    private static void DisplayResult(int number, long factorial) 
    {
        Console.WriteLine($"The factorial of {number} is: {factorial}");
    }
    //entry point
    public static void Main() 
    {
        int inputNum = GetInput();
        long result = CalculateFactorial(inputNum);
        DisplayResult(inputNum, result);
    }
}