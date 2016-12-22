using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Merging_Numbers
{
    class MergingNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            List<string> concList = new List<string>();
            List<int> sumList = new List<int>();
            int sumOfNumbers = 0;
            int last = 0;
            int next = 0;
            string num = null;

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            //concatenate
            for (int k = 0; k < n - 1; k++)
            {
                last = numbers[k] % 10;
                next = ((numbers[k + 1] / 10) % 10);
                num = Convert.ToString(last) + Convert.ToString(next);
                concList.Add(num);
                last = next;
            }
            //sum
            for (int m = 0; m < n - 1; m++)
            {
                last = numbers[m];
                next = (numbers[m + 1]);
                sumOfNumbers = last + next;
                sumList.Add(sumOfNumbers);
                last = next;
            }

            Console.WriteLine(string.Join(" ", concList));
            Console.WriteLine(string.Join(" ", sumList));
        }
    }
}
