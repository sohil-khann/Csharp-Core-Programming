/*1. Create a program to find the shortest, tallest, and mean height of players present in a
football team.
Hint =>
a. The formula to calculate the mean is: mean = sum of all elements/number of
elements
b. Create an int array named heights of size 11 and get 3 digits random height in cms for
each player in the range 150 cms to 250 cms
c. Write the method to Find the sum of all the elements present in the array.
d. Write the method to find the mean height of the players on the football team
e. Write the method to find the shortest height of the players on the football team
f. Write the method to find the tallest height of the players on the football team
g. Finally display the results8/*/
using System;
internal static class FootBallTeam
{
    internal static void Main()
    {
        int[] heights = new int[11];
        Random random = new Random();
        
        for(int i=0;i<11;i++){
          
             heights[i]=  random.Next(150, 251);
            Console.WriteLine($"Height of player {i+1}: {heights[i]} cms");

        }
        int sum = SumOfHeights(heights);
        double mean = MeanHeight(heights);
        int shortest = ShortestHeight(heights);
        int tallest = TallestHeight(heights);
        Console.WriteLine($"Sum of Heights: {sum} cms");
        Console.WriteLine($"Mean Height: {mean:F2} cms");
        Console.WriteLine($"Shortest Height: {shortest} cms");
        Console.WriteLine($"Tallest Height: {tallest} cms");
    }
   

internal static int SumOfHeights(int[] heights)
    {
        int sum = 0;
        foreach (int height in heights)
        {
            sum += height;
        }
        return sum;
}
internal static double MeanHeight(int[] heights)
    {
        int sum = SumOfHeights(heights);
        return (double)sum / heights.Length;
}

    internal static int ShortestHeight(int[] heights)
    {
        int shortest = heights[0];
        foreach (int height in heights)
        {
            if (height < shortest)
            {
                shortest = height;
            }
        }
        return shortest;
    }

    
    internal static int TallestHeight(int[] heights)
    {
        int tallest = heights[0];
        foreach (int height in heights)
        {
            if (height > tallest)
            {
                tallest = height;
            }
        }
        return tallest;
}
}