using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Greatest_Common_Divisor_GCD
{
    class GreatestCommonDivisor
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            long[] nums = input
                .Split().Select(long.Parse).ToArray();
            long a = nums[0];
            long b = nums[1];
            while (b != 0)
            {
                long current = b;
                b = a % b;
                a = current;
            }
            Console.WriteLine(a);
        }
    }
}
