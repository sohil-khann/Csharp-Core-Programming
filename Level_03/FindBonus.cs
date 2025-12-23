/*11. Create a program to find the bonus of 10 employees based on their years of service
as well as the total bonus amount the 10-year-old company Zara has to pay as a bonus,
along with the old and new salary.
Hint =>
a. Zara decides to give a bonus of 5% to employees whose year of service is more than 5
years or 2% if less than 5 years
b. Create a Method to determine the Salary and years of service and return the same.
Use the Math.Random() method to determine the 5-digit salary for each employee and also
use the random method to determine the years of service. Define 2D Array to save the
salary and years of service.
c. Write a Method to calculate the new salary and bonus based on the logic defined
above and return the new 2D Array of the latest salary and bonus amount
d. Write a Method to Calculate the sum of the Old Salary, the Sum of the New Salary,
and the Total Bonus Amount and display it in a Tabular Format*/
using System;
internal static class FindBonus
{
    internal static void Main()
    {
        const int employeeCount = 10;
        double[,] employeeData = GenerateEmployeeData(employeeCount);
        double[,] updatedEmployeeData = CalculateBonuses(employeeData, employeeCount);
        DisplaySalaryTable(employeeData, updatedEmployeeData, employeeCount);
    }
    private static double[,] GenerateEmployeeData(int count)
    {
        Random rand = new Random();
        double[,] data = new double[count, 2];
        for (int i = 0; i < count; i++)
        {
            data[i, 0] = rand.Next(30000, 100000); // Salary between 30,000 and 100,000
            data[i, 1] = rand.Next(1, 11); // Years of service between 1 and 10
        }
        return data;
    }
    private static double[,] CalculateBonuses(double[,] employeeData, int count)
    {
        double[,] updatedData = new double[count, 3]; // Old Salary, Bonus, New Salary
        for (int i = 0; i < count; i++)
        {
            double oldSalary = employeeData[i, 0];
            double yearsOfService = employeeData[i, 1];
            double bonusPercentage = yearsOfService > 5 ? 0.05 : 0.02;
            double bonusAmount = oldSalary * bonusPercentage;
            double newSalary = oldSalary + bonusAmount;
            updatedData[i, 0] = oldSalary;
            updatedData[i, 1] = bonusAmount;
            updatedData[i, 2] = newSalary;
        }
        return updatedData;
    }
    private static void DisplaySalaryTable(double[,] oldData, double[,] newData, int count)
    {
        Console.WriteLine("Employee\tOld Salary\tBonus\tNew Salary");
        double totalOldSalary = 0;
        double totalBonus = 0;
        double totalNewSalary = 0;
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"{i + 1}\t\t{oldData[i, 0]}\t{newData[i, 1]}\t{newData[i, 2]}");
            totalOldSalary += oldData[i, 0];
            totalBonus += newData[i,1];
            totalNewSalary += newData[i, 2];
            }

        Console.WriteLine($"Total\t\t{totalOldSalary}\t{totalBonus}\t{totalNewSalary}");
        }
    }
