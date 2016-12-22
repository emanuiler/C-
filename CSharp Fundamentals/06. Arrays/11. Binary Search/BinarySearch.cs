using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Binary_Search
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int low = 0;
            int high = numbers.Length - 1;
            int firstOccurrence = int.MinValue;

            while (low <= high)
            {
                int middle = low + ((high - low) >> 1);

                if (numbers[middle] == x)
                {
                    // key found and we want to search an earlier occurrence
                    firstOccurrence = middle;
                    high = middle - 1;
                }
                else if (numbers[middle] < x)
                {
                    low = middle + 1;
                }
                else
                {
                    high = middle - 1;
                }
            }

            if (firstOccurrence != int.MinValue)
            {
                Console.WriteLine(firstOccurrence);
            }

            Console.WriteLine(-(low + 1));   // key not found

        }

    }
}
