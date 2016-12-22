using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Fibonacci_Numbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<ulong> list = new List<ulong>();
            ulong first = 0;
            ulong second = 1;
            if (n == 0)
            {
                Console.WriteLine(0);
            }
            else if (n == 1)
            {
                Console.WriteLine(0);
            }
            else if (n > 2)
            {
                Console.Write("0, 1, ");
                for (int i = 0; i <= n - 3; i++)
                {
                    ulong next = first + second;
                    first = second;
                    second = next;
                    list.Add(second);
                }
                Console.WriteLine(string.Join(", ", list));
            }
        }
    }
}
