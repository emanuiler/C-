using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Selection_Sort
{
    class SortArray
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrNums = new int[n];
            for (int i = 0; i < n; i++)
            {
                arrNums[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arrNums);

            foreach (var item in arrNums)
            {
                Console.WriteLine(item);
            }            
        }
    }
}
