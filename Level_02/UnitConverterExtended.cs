/*5. Extend or Create a UnitConvertor utility class similar to the one shown in the notes to
do the following. Please define static methods for all the UnitConvertor class methods. E.g.
public static double ConvertYardsToFeet(double yards) =>
a. Method to convert yards to feet and return the value. Use following code to
convert double yards2feet = 3;
b. Method to convert feet to yards and return the value. Use following code to
convert double feet2yards = 0.333333;
c. Method to convert meters to inches and return the value. Use following code
to convert double meters2inches = 39.3701;
d. Method to convert inches to meters and return the value. Use following code
to convert double inches2meters = 0.0254;
e. Method to convert inches to centimeters and return the value. Use the
following code double inches2cm = 2.54;*/
using System;
internal static class UnitConverterExtended
{
    private const double YardsToFeetFactor = 3.0;
    private const double FeetToYardsFactor = 0.333333;
    private const double MetersToInchesFactor = 39.3701;
    private const double InchesToMetersFactor = 0.0254;
    private const double InchesToCmFactor = 2.54;
    public static double ConvertYardsToFeet(double yards)
    {
        return yards * YardsToFeetFactor;
    }
    public static double ConvertFeetToYards(double feet)
    {
        return feet * FeetToYardsFactor;
    }
    public static double ConvertMetersToInches(double meters)
    {
        return meters * MetersToInchesFactor;
    }
    public static double ConvertInchesToMeters(double inches)
    {
        return inches * InchesToMetersFactor;
    }
    public static double ConvertInchesToCm(double inches)
    {
        return inches * InchesToCmFactor;
    }
}