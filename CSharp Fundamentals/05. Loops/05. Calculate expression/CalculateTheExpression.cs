using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Calculate_expression
{
    class CalculateTheExpression
    {
        static void Main()
        {
            //S = 1 + 1!/x + 2!/x2 + … + N!/xN.  // 3   i   2  == 2,75000

            ulong n = ulong.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            ulong factorial = 1;
            double sum = 1 + 1 / x;
            for (ulong i = 2; i <= n; i++)
            {
                factorial *= i;
                double pow = Math.Pow(x, i);
                sum += (factorial / pow);
            }

            Console.WriteLine("{0:F5}", sum);
        }
    }
}
