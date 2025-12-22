/*2. Write a program to find the sum of n natural numbers using recursive method and
compare the result with the formulae n*(n+1)/2 and show the result from both
computations is correct.
Hint =>
a. Take the user input number and check whether it's a Natural number, if not exit
b. Write a Method to find the sum of n natural numbers using recursion
c. Write a Method to find the sum of n natural numbers using the formulae
 n*(n+1)/2
d. Compare the two results and print the result*/using System;internal static class CompareSumOfNum{    public static void runMethod()    {        Console.WriteLine("Enter a natural number:");        int n = int.Parse(Console.ReadLine());        if (n < 1)        {            Console.WriteLine("Not a natural number. Exiting.");            return;        }        int recursiveSum = SumUsingRecursion(n);        int formulaSum = SumUsingFormula(n);        Console.WriteLine($"Sum using recursion: {recursiveSum}");        Console.WriteLine($"Sum using formula: {formulaSum}");        if (recursiveSum == formulaSum)        {            Console.WriteLine("Both results are correct and equal.");        }        else        {            Console.WriteLine("The results do not match.");        }    }    internal static int SumUsingRecursion(int n)    {        if (n == 1)            return 1;        return n + SumUsingRecursion(n - 1);    }    internal static int SumUsingFormula(int n)    {        return n * (n + 1) / 2;    }}   