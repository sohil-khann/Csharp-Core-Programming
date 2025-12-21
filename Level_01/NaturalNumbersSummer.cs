// Problem 7: Sum of N Natural Numbers
// Description: Find the sum of n natural numbers using loop
// Formula: 1 + 2 + 3 + ... + n

class NaturalNumbersSummer
{
    public static void CalculateSumOfNaturalNumbers()
    {
        
        Console.Write("Enter a number n: ");
        int n = int.Parse(Console.ReadLine());
        
        int sum = FindSumOfNaturalNumbers(n);
        
        Console.WriteLine($"The sum of natural numbers from 1 to {n} is: {sum}");
    }
    
    private static int FindSumOfNaturalNumbers(int n)
    {
        int total = 0;
        for (int i = 1; i <= n; i++)
        {
            total += i;
        }
        return total;
    }
}
