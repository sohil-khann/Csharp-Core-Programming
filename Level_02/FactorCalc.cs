/*1.Create a program to find the factors of a number taken as user input, store the factors in
an array and display the factors. Also find the sum, sum of square of factors and product of
the factors and display the results
Hint =>
1. Take the input for a number
2. Write a static Method to find the factors of the number and save them in an array
and return the array.
3. To find factors and save to array will have two loops. The first loop to find the count
and initialize the array with the count. And the second loop save the factors into the
array
4. Write a method to find the sum of the factors using factors array
5.Write a method to find the product of the factors using factors array
6.Write a method to find the sum of square of the factors using Math.Pow() method*/
using System;
using System.Collections.Generic;

public static class FactorCalc
{
    public static void runMethod()
    {
        List<int> factors= new List<int>();
        Console.WriteLine("Enter a number:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Factors of {n}:");
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                factors.Add(i);
            }
        }
        Console.WriteLine($"Factors are: {string.Join(", ", factors)}");
        sumOfFactors(factors);
        productOfFactors(factors);
        squareOfFactors(factors);

    }
    internal static void sumOfFactors(List<int> factors)
    {
        int sum = 0;
        foreach (int factor in factors)
        {
            sum += factor;
        }
        Console.WriteLine($"Sum of factors is {sum}");
        return;
    }

    internal static void productOfFactors(List<int> factors)
    {
        int prod = 1;
        foreach (int factor in factors)
        {
            prod *= factor;
        }
        Console.WriteLine($"Product of factors is {prod}");
        return;
    }
    internal static void squareOfFactors(List<int> factors)
    {
        int sqr = 0;
        foreach (int factor in factors)
        {
            sqr+=(int)Math.Pow(factor,2);
        }
        Console.WriteLine($"Sum of squares of factors is :{sqr}");
        return;
    }


}