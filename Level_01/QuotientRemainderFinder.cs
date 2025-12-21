// Problem 9: Quotient and Remainder
// Description: Find the quotient and remainder when dividing a number by a divisor
// Returns: An array with [quotient, remainder]

class QuotientRemainderFinder
{
    public static void CalculateQuotientAndRemainder()
    {
        
        Console.Write("Enter dividend: ");
        int dividend = int.Parse(Console.ReadLine());
        
        Console.Write("Enter divisor: ");
        int divisor = int.Parse(Console.ReadLine());
        
        if (divisor == 0)
        {
            Console.WriteLine("Error: Divisor cannot be zero");
            return;
        }
        
        int[] result = GetQuotientAndRemainder(dividend, divisor);
        
        Console.WriteLine($"Quotient: {result[0]}");
        Console.WriteLine($"Remainder: {result[1]}");
    }
    
    private static int[] GetQuotientAndRemainder(int number, int divisor)
    {
        int quotient = number / divisor;
        int remainder = number % divisor;
        return new int[] { quotient, remainder };
    }
}
