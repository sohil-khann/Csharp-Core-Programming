// Problem 8: Find Smallest and Largest of 3 Numbers
// Description: Find the smallest and largest of three numbers in a single method
// Returns: An array with [smallest, largest]

class SmallestLargestFinder
{
    public static void FindSmallestAndLargest()
    {
        
        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());
        
        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());
        
        Console.Write("Enter third number: ");
        int num3 = int.Parse(Console.ReadLine());
        
        int[] result = GetSmallestAndLargest(num1, num2, num3);
        
        Console.WriteLine($"Smallest number: {result[0]}");
        Console.WriteLine($"Largest number: {result[1]}");
    }
    
    private static int[] GetSmallestAndLargest(int number1, int number2, int number3)
    {
        int smallest = number1;
        int largest = number1;
        
        if (number2 < smallest)
            smallest = number2;
        if (number2 > largest)
            largest = number2;
        
        if (number3 < smallest)
            smallest = number3;
        if (number3 > largest)
            largest = number3;
        
        return new int[] { smallest, largest };
    }
}
