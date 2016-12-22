using System;
using System.Numerics;

namespace _14.Factorial_Trailing_Zeros
{
    class HowManyTrailingZerosAfterFactorial
    {
        //works greater for bigger numbers
        static void Main()
        {
            ulong number = ulong.Parse(Console.ReadLine());
            ulong count, total = 0;
            count = 5;
            while ((number/count) >= 1)
            {
                total = total + number / count;
                count = count * 5;
            }
            Console.WriteLine(total);
        }
    }
}
