using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _08.Catalan_Numbers
{
    class CatalanNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            //2n!/((n+1)! n!)
            BigInteger factorial = 1;
            BigInteger fact2N = 1;
            BigInteger factN1 = 1;
            for (int i = 2; i <= n; i++)
            {
                factorial *= i;
            }
            for (int j = 2; j <= 2 * n; j++)
            {
                fact2N *= j;
            }
            for (int k = 2; k <= n + 1; k++)
            {
                factN1 *= k;
            }
            BigInteger sum = fact2N / (factN1 * factorial);
            Console.WriteLine(sum);
        }
    }
}
