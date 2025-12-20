/*4.Rework the program 2, especially the Hint: if index equals maxDigit, we break from the loop.
Here we want to modify to increase the size of the array i, e maxDigit by 10 if the index is
equal to maxDigit. This is done to consider all digits to find the largest and second-largest
number
Hint =>
a. In Hint f inside the loop if the index is equal to maxDigit, increase maxDigit and make
digits array to store more elements.
b. To do this, we need to create a new temp array of size maxDigit, copy from the current
digits array the digits into the temp array, and assign the current digits array to the temp
array
c. Now the digits array will be able to store all digits of the number in the array and then
find the largest and second largest number*/

using System;    public static class  ReworkOfProgram2{    public static void runMethod()
    {

        int number, index = 0, maxDigit = 10;
        Console.WriteLine("Enter a number:");
        number = Convert.ToInt32(Console.ReadLine());
        int[] digits = new int[maxDigit];
        while (number > 0)
        {
            if (index == maxDigit)
            {
                maxDigit += 10;
                int[] temp = new int[maxDigit];
                Array.Copy(digits, temp, digits.Length);
                digits = temp;
            }
            digits[index] = number % 10;
            number /= 10;
            index++;
        }
        int largest = int.MinValue;
        int secondLargest = int.MinValue;
     Array.Sort(digits);
        Console.WriteLine("Largest digit: " + digits[digits.Length-1]);
        Console.WriteLine("Second largest digit: " + digits[digits.Length-2]);
    }}