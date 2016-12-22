using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _07.Calculate
{
    class CalculateFactorials
    {
        static void Main()
        {
            //N! / (K! * (N - K)!)
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger k = BigInteger.Parse(Console.ReadLine());
            BigInteger factorialN = 1;
            BigInteger factorialK = 1;
            BigInteger sub = n - k;
            BigInteger factSub = 1;
            for (BigInteger j = 2; j <= n; j++)
            {
                factorialN *= j;
            }

            for (BigInteger h = 2; h <= k; h++)
            {
                factorialK *= h;
            }

            for (BigInteger r = 2; r <= sub; r++)
            {
                factSub *= r;
            }

            BigInteger sum = factorialN / (factorialK * factSub);
            Console.WriteLine(sum);

        }
    }
}
