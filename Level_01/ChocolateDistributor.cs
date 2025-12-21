// Problem 10: Divide Chocolates Among Children
// Description: Distribute N chocolates among M children and find remainder
// Returns: An array with [chocolates per child, remaining chocolates]

class ChocolateDistributor
{
    public static void DistributeChocolates()
    {
      
        
        Console.Write("Enter number of chocolates: ");
        int numberOfChocolates = int.Parse(Console.ReadLine());
        
        Console.Write("Enter number of children: ");
        int numberOfChildren = int.Parse(Console.ReadLine());
        
        if (numberOfChildren == 0)
        {
            Console.WriteLine("Error: Number of children cannot be zero");
            return;
        }
        
        int[] distribution = GetChocolateDistribution(numberOfChocolates, numberOfChildren);
        
        Console.WriteLine($"Each child gets: {distribution[0]} chocolates");
        Console.WriteLine($"Remaining chocolates: {distribution[1]}");
    }
    
    private static int[] GetChocolateDistribution(int numberOfChocolates, int numberOfChildren)
    {
        int chocolatesPerChild = numberOfChocolates / numberOfChildren;
        int remainingChocolates = numberOfChocolates % numberOfChildren;
        return new int[] { chocolatesPerChild, remainingChocolates };
    }
}
