using System;
using System.Collections.Generic;
using System.Text;

namespace Level_01
{
    public static class CheckNumDivByFive
    {
        public static bool IsDivisibleByFive()

        {
            int number = Convert.ToInt32(Console.ReadLine());
            return number % 5 == 0;
        }

    }
}
