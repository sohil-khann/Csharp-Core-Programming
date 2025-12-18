using System;

namespace Level_02Programs
{
    public static class GradeCalculator
    {
        public static void Run()
        {
            Console.Write("Enter marks for Physics: ");
            if (!double.TryParse(Console.ReadLine(), out double physics)) { Console.WriteLine("Invalid input"); return; }
            Console.Write("Enter marks for Chemistry: ");
            if (!double.TryParse(Console.ReadLine(), out double chemistry)) { Console.WriteLine("Invalid input"); return; }
            Console.Write("Enter marks for Maths: ");
            if (!double.TryParse(Console.ReadLine(), out double maths)) { Console.WriteLine("Invalid input"); return; }

            double total = physics + chemistry + maths;
            double percentage = total / 3.0;

            string grade;
            string remarks;

            if (percentage >= 80)
            {
                grade = "A";
                remarks = "Level 4, above agency-normalized standards";
            }
            else if (percentage >= 70)
            {
                grade = "B";
                remarks = "Level 3, at agency-normalized standards";
            }
            else if (percentage >= 60)
            {
                grade = "C";
                remarks = "Level 2, below, but approaching agency-normalized standards";
            }
            else if (percentage >= 50)
            {
                grade = "D";
                remarks = "Level 1, well below agency-normalized standards";
            }
            else if (percentage >= 40)
            {
                grade = "E";
                remarks = "Level 1-, too below agency-normalized standards";
            }
            else
            {
                grade = "F";
                remarks = "39% and below";
            }

            Console.WriteLine($"Average Marks: {percentage:F2}%\nGrade: {grade}\nRemarks: {remarks}");
        }
    }
}
