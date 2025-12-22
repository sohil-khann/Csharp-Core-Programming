/*7. Write a program to generate a six-digit OTP number using Math.Random() method.
Validate the numbers are unique by generating the OTP number 10 times and ensuring all
the 10 OTPs are not the same
Hint =>
a. Write a method to Generate a 6-digit OTP number using Math.Random()
b. Create an array to save the OTP numbers generated 10 times
c. Write a method to ensure that the OTP numbers generated are unique. If unique
return true else return false*/
using System;
using System.Collections.Generic;
internal static class OTP
{
    public static void Main()
    {
        const int otpCount = 10;
        string[] otps = new string[otpCount];
        for (int i = 0; i < otpCount; i++)
        {
            otps[i] = GenerateOTP();
            Console.WriteLine($"Generated OTP {i + 1}: {otps[i]}");
        }
        bool areUnique = AreOTPsUnique(otps);
        Console.WriteLine($"All generated OTPs are unique: {areUnique}");
    }
    public static string GenerateOTP()
    {
        Random random = new Random();
        int otp = random.Next(100000, 1000000); // Generates a number between 100000 and 999999
        return otp.ToString();
    }
    public static bool AreOTPsUnique(string[] otps)
    {
        HashSet<string> otpSet = new HashSet<string>(otps);
        return otpSet.Count == otps.Length;
    }
}