using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Max_Sequence_of_Increasing_Elements
{
    class IncreasingElements
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();
            int start = 1;
            int counter = 0;
            int max = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                numbers.Add(num);
            }

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] < numbers[i + 1])
                {
                    counter++;
                    if (counter > max)
                    {
                        start = i - counter;
                        max = counter;
                    }
                }
                else
                {
                    counter = 0;
                }
            }

            Console.WriteLine(max + 1);
        }
    }
}
