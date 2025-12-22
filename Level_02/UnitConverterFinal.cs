/*
6. Extend or Create a UnitConvertor utility class similar to the one shown in the notes to do the following. Please define static methods for all the UnitConvertor class methods. E.g. public static double convertFarhenheitToCelsius(double farhenheit) =>
a. Method to convert Fahrenheit to Celsius and return the value. Use the following code double farhenheit2celsius = (farhenheit - 32) * 5 / 9;
b. Method to convert Celsius to Fahrenheit and return the value. Use the following code double celsius2farhenheit = (celsius * 9 / 5) + 32;
c. Method to convert pounds to kilograms and return the value. Use the following code double pounds2kilograms = 0.453592;
d. Method to convert kilograms to pounds and return the value. Use the following code double kilograms2pounds = 2.20462;
e. Method to convert gallons to liters and return the value. Use following code to convert double gallons2liters = 3.78541;
f. Method to convert liters to gallons and return the value. Use following code to convert double liters2gallons = 0.264172;
*/

using System;

namespace Level_02
{
    public static class UnitConverterFinal
    {
        private const double LbsToKgFactor = 0.453592;
        private const double KgToLbsFactor = 2.20462;
        private const double GalToLtrFactor = 3.78541;
        private const double LtrToGalFactor = 0.264172;

        public static double ConvertFahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        public static double ConvertCelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        public static double ConvertPoundsToKilograms(double pounds)
        {
            return pounds * LbsToKgFactor;
        }

        public static double ConvertKilogramsToPounds(double kilograms)
        {
            return kilograms * KgToLbsFactor;
        }

        public static double ConvertGallonsToLiters(double gallons)
        {
            return gallons * GalToLtrFactor;
        }

        public static double ConvertLitersToGallons(double liters)
        {
            return liters * LtrToGalFactor;
        }
    }
}
