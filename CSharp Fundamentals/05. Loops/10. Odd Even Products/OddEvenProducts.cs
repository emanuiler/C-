using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Odd_Even_Products
{
    class OddEvenProducts
    {
        static void Main()
        {
            ulong n = ulong.Parse(Console.ReadLine());
            string nn = Console.ReadLine();
            ulong[] numbers = nn.Split().Select(ulong.Parse).ToArray();
            ulong oddProduct = 1;
            ulong evenProduct = 1;
            for (ulong i = 0; i <(ulong) numbers.Length; i++)
            {
                if (i % 2 != 0)
                {
                    oddProduct *= numbers[i];
                }
                else
                {
                    evenProduct *= numbers[i];
                }
            }
            if (oddProduct == evenProduct)
            {
                Console.WriteLine("yes {0}", oddProduct);
            }
            else
            {
                Console.WriteLine("no {0} {1}",evenProduct, oddProduct);
            }                
        }
    }
}
