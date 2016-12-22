using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Bit_Swap
{
    class BitSwap
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());// number
            int p = int.Parse(Console.ReadLine());// first position
            int q = int.Parse(Console.ReadLine());// second position
            if (p > q)
            {
                int holder = p;
                p = q;
                q = holder;
            }
            int k = int.Parse(Console.ReadLine());// bit swap
            long maskLenth = (long)Math.Pow(2, k) - 1;

            long firstMask = maskLenth << p;
            long secondMask = maskLenth << q;
            long firstBlankMask = ~(maskLenth << p);
            long secondBlankMask = ~(maskLenth << q);


            firstMask = firstMask & n;
            secondMask = secondMask & n;

            n = firstBlankMask & n;
            n = secondBlankMask & n;

            n = (firstMask << (q - p)) | n;
            n = (secondMask >> (q - p)) | n;
            Console.WriteLine(n);

        }
    }
}
