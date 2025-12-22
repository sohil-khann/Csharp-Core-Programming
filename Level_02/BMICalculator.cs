/*
10. An organization took up the exercise to find the Body Mass Index (BMI) of all the persons in the team of 10 members. For this create a program to find the BMI and display the height, weight, BMI and status of each individual Hint =>
a. Take user input in double for the weight (in kg) of the person and height (in cm) for the person and store it in the corresponding 2D array of 10 rows and 3 columns. The First Column storing the weight, the second column storing the height in cm and the third column is the BMI
b. Create a Method to find the BMI of every person and populate the array. Use the formula BMI = weight / (height * height). Note unit is kg/m^2. For this convert cm to meter
c. Create a Method to determine the BMI status using the logic shown in the figure below. and return the array of all the persons BMI Status.
*/

using System;

namespace Level_02
{
    public class BMICalculator
    {
        public static void runMethod()
        {
            double[,] personData = new double[10, 3];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Enter details for person {i + 1}:");
                Console.Write("Weight (kg): ");
                if (double.TryParse(Console.ReadLine(), out double weight))
                {
                    personData[i, 0] = weight;
                }

                Console.Write("Height (cm): ");
                if (double.TryParse(Console.ReadLine(), out double height))
                {
                    personData[i, 1] = height;
                }
                Console.WriteLine();
            }

            CalculateBMIs(personData);
            string[] statuses = DetermineBMIStatuses(personData);

            Console.WriteLine($"{"ID",-5} {"Weight",-10} {"Height",-10} {"BMI",-10} {"Status",-15}");
           
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i + 1,-5} {personData[i, 0],-10:F2} {personData[i, 1],-10:F2} {personData[i, 2],-10:F2} {statuses[i],-15}");
            }
        }

        public static void CalculateBMIs(double[,] data)
        {
            for (int i = 0; i < data.GetLength(0); i++)
            {
                double weight = data[i, 0];
                double heightInMeters = data[i, 1] / 100.0;
                if (heightInMeters > 0)
                {
                    data[i, 2] = weight / (heightInMeters * heightInMeters);
                }
                else
                {
                    data[i, 2] = 0;
                }
            }
        }

        public static string[] DetermineBMIStatuses(double[,] data)
        {
            string[] statuses = new string[data.GetLength(0)];
            for (int i = 0; i < data.GetLength(0); i++)
            {
                double bmi = data[i, 2];
                if (bmi < 18.5)
                {
                    statuses[i] = "Underweight";
                }
                else if (bmi < 25)
                {
                    statuses[i] = "Normal";
                }
                else if (bmi < 30)
                {
                    statuses[i] = "Overweight";
                }
                else
                {
                    statuses[i] = "Obese";
                }
            }
            return statuses;
        }
    }
}
