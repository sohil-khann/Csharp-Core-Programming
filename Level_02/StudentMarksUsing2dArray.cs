/*Rewrite the above program to store the marks of the students in physics, chemistry, and
maths in a 2D array and then compute the percentage and grade
Hint =>
a. All the steps are the same as the problem 8 except the marks are stored in a 2D array
b. Use the 2D array to calculate the percentages, and grades of the students*/


using System;   
internal static class StudentMarksUsing2dArray
{
    internal static void runMethod()
    {
        Console.WriteLine("Enter number of students:");
        int n = int.Parse(Console.ReadLine());
        int[,] marks = new int[n, 3];
        double[] percentages = new double[n];
        string[] grades = new string[n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                int mark;
                do
                {
                    Console.WriteLine($"Enter marks of student {i + 1} in subject {j + 1}:");
                    mark = int.Parse(Console.ReadLine());
                    if (mark < 0)
                        Console.WriteLine("invalid entry.");
                } while (mark < 0);
                marks[i, j] = mark;
            }
            percentages[i] = (marks[i, 0] + marks[i, 1] + marks[i, 2]) / 3.0;
            double percentage = percentages[i];
            if (percentage >= 80)
                grades[i] = "A";
            else if (percentage >= 70)
                grades[i] = "B";
            else if (percentage >= 60)
                grades[i] = "C";
            else if (percentage >= 50)
                grades[i] = "D";
            else if(percentage >= 40)
                grades[i] = "E";
            else
                grades[i] = "R";
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Student {i + 1} Marks: Physics: {marks[i, 0]}, Chemistry: {marks[i, 1]}, Maths: {marks[i, 2]}  Percentage : {percentages[i]}  Grade : {grades[i]}\n");
        }
    }
}