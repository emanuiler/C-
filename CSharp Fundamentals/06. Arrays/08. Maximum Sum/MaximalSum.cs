using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Maximum_Sum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(findMaxSum(numbers));

        }
        public static int findMaxSum(int[] anArray)
        {
            int currentSum = 0;
            int currentMax = 0;

            for (int j = 0; j < anArray.Length; j++)
            {
                currentSum += anArray[j];

                if (currentMax < currentSum)
                    currentMax = currentSum;
                else if (currentSum < 0)
                    currentSum = 0;
            }

            return currentMax;

        }
    }
}
