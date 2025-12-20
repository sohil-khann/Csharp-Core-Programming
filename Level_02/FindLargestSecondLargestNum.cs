/*Create a program to store the digits of the number in an array and find the largest and
second largest element of the array.*/
using System;

public static class FindLargestSecondLargestNum
{
    public static void runMethod()
    {
        int n, i;
        int[] arr = new int[50];
        int largest, secondLargest;
        Console.WriteLine("Enter the size of array: ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter number : ");
        for (i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        largest = secondLargest = Int32.MinValue;
        Array.Sort(arr);


        Console.WriteLine("The largest element is: " + arr[arr.Length-1]);
            Console.WriteLine("The second largest element is: " + arr[arr.Length-2]);
        //}
    }
}