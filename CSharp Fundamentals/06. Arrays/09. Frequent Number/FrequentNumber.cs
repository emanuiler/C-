using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Frequent_Number
{
    class FrequentNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrNums = new int[n];
            int frequentNumber = 0;
            int counter = 0;
            for (int i = 0; i < n; i++)
            {
                arrNums[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arrNums.Length; i++)
            {
                int tempCounter = 0;

                for (int j = 0; j < arrNums.Length; j++)
                {
                    if (arrNums[i]== arrNums[j])
                    {
                        tempCounter++;
                    }
                }

                if (tempCounter > counter)
                {
                    counter = tempCounter;
                    frequentNumber = arrNums[i];
                }
            }

            Console.WriteLine("{0} ({1} times)",frequentNumber,counter);


        }
    }
}
