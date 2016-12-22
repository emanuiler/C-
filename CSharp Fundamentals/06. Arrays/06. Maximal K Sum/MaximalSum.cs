using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Maximal_K_Sum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] arrNums = new int[n];
            for (int i = 0; i < n; i++)
            {
                arrNums[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arrNums);
            List<int> finalNums = new List<int>();

            for (int i = arrNums.Length - 1, z = 0; z < k; i--, z++)
            {
                finalNums.Add(arrNums[i]);
            }

            int result = 0;

            foreach (var item in finalNums)
            {
                result += item;
            }

            Console.WriteLine(result);

        }
    }
}
