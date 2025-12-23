/*9. Basic Calculator:
Write a program that performs basic mathematical operations (addition, subtraction,
multiplication, division) based on user input.
 Each operation should be performed in its own function, and the program should
prompt the user to choose which operation to perform.
*/
using System; 
internal class BasicCalc
{
    //for addition
    private static double Add(double a, double b)
    {
        return a + b;
    }
    //for subtraction
    private static double Subtract(double a, double b) 
    {
        return a - b;
    }
    //for multiplication
    private static double Multiply(double a, double b) 
    {
        return a * b;
    }
    //for division
    private static double Divide(double a, double b) 
    {
        if (b == 0)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
            return double.NaN;
        }
        return a / b;
    }
    public static void Main() 
        //entry point
    {
        Console.WriteLine("Basic Calculator");
        Console.WriteLine("Choose an operation:");
        Console.WriteLine("1. Addition (+)");
        Console.WriteLine("2. Subtraction (-)");
        Console.WriteLine("3. Multiplication (*)");
        Console.WriteLine("4. Division (/)");
        Console.Write("Enter your choice (1-4): ");
        //Choice input
        int choice = int.Parse(Console.ReadLine());
        Console.Write("Enter first number: ");
        //Number inputs
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");

        double num2 = double.Parse(Console.ReadLine());
        double result = 0;

        //Perform operation based on user choice
        switch (choice)
        {
            case 1:
                result = Add(num1, num2);
                Console.WriteLine($"Result: {num1} + {num2} = {result}");
                break;
            case 2:
                result = Subtract(num1, num2);
                Console.WriteLine($"Result: {num1} - {num2} = {result}");
                break;
            case 3:
                result = Multiply(num1, num2);
                Console.WriteLine($"Result: {num1} * {num2} = {result}");
                break;
            case 4:
                result = Divide(num1, num2);
                if (!double.IsNaN(result))
                {
                    Console.WriteLine($"Result: {num1} / {num2} = {result}");
                }
                break;
            default:
                Console.WriteLine("Invalid choice. Please select a valid operation.");
                break;
        }
    }
}