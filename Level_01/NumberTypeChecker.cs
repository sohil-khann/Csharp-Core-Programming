// Problem 5: Check Number Type
// Description: Check whether a number is positive, negative, or zero
// Returns: -1 for negative, 1 for positive, 0 for zero

class NumberTypeChecker
{
    public static void CheckNumber()
    {
        
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        
        int result = DetermineNumberType(number);
        
        string typeDescription = result switch
        {
            1 => "positive",
            -1 => "negative",
            0 => "zero",
            _ => "unknown"
        };
        
        Console.WriteLine($"The number {number} is {typeDescription}");
    }
    
    private static int DetermineNumberType(int number)
    {
        if (number > 0)
            return 1;
        else if (number < 0)
            return -1;
        else
            return 0;
    }
}
