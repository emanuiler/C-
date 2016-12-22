using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Exchange_Numbers
{
    class ExchangeNumbers
    {
        static void Main()
        {
            sbyte a = sbyte.Parse(Console.ReadLine());
            sbyte b = sbyte.Parse(Console.ReadLine());
            sbyte temp;
            if (a > b)
            {
                temp = a;
                a = b;
                b = temp;
                Console.Write("{0} {1}", a, b);
                Console.WriteLine();
            }
            else
            {
                Console.Write("{0} {1}", a, b);
                Console.WriteLine();
            }

        }
    }
}
