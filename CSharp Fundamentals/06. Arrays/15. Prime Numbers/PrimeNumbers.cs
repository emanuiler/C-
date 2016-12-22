using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Prime_Numbers
{
    class PrimeNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool[] nums = new bool[n];
            for (int i = 2; i <= Math.Sqrt(nums.Length); i++)
            {
                if (nums[i] == false)
                {
                    for (int j = i * i; j <= nums.Length; j = j + i)
                    {
                        nums[j] = true;
                    }
                }
            }
            for (int i = 2; i < nums.Length; i++)
            {
                if (nums[i] == false)
                {
                    Console.WriteLine("{0} ", i);
                }
            }
            Console.WriteLine();
        }
    }
}
