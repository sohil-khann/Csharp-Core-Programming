using System;
/*
7.Rewrite the above program using multi-dimensional array to store height, weight, and BMI in
2D array for all the persons
Hint =>
a. Take input for a number of persons
b. Create a multi-dimensional array to store weight, height and BMI. Also create an to store
the weight status of the persons
 double[][] personData = new double[number][3];
String[] weightStatus = new String[number];
c.Take input for weight and height of the persons and for negative values, ask the user to
enter positive values
d. Calculate BMI of all the persons and store them in the personData array and also find
the weight status and put them in the weightStatus array
e. Display the height, weight, BMI and status of each person*/internal static class BmiUsing2DArr{    internal static void runMethod()    {        Console.WriteLine("Enter number of persons:");        int n = int.Parse(Console.ReadLine());        double[][] personData = new double[n][];        string[] weightStatus = new string[n];        for (int i = 0; i < n; i++)        {            personData[i] = new double[3];            double weight, height;            do            {                Console.WriteLine($"Enter weight of person {i + 1}:");                weight = double.Parse(Console.ReadLine());                if (weight <= 0)                    Console.WriteLine("Please enter a positive value for weight.");            } while (weight <= 0);            personData[i][0] = weight;            do            {                Console.WriteLine($"Enter height of person {i + 1}:");                height = double.Parse(Console.ReadLine());                if (height <= 0)                    Console.WriteLine("Please enter a positive value for height.");            } while (height <= 0);            personData[i][1] = height;            personData[i][2] = weight / (height * height);            double bmi = personData[i][2];            if (bmi < 18.5)                weightStatus[i] = "Underweight";            else if (bmi >= 18.5 && bmi < 24.9)                weightStatus[i] = "Normal weight";            else if (bmi >= 25 && bmi < 29.9)                weightStatus[i] = "Overweight";            else                weightStatus[i] = "Obesity";        }        for (int i = 0; i < n; i++)        {            Console.WriteLine($"Height : {personData[i][1]}  Weight : {personData[i][0]}  BMI : {personData[i][2]}  Status : {weightStatus[i]}\n");        }    }}