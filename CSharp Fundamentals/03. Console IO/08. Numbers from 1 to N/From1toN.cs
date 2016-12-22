using System;

namespace _08.Numbers_from_1_to_N
{
    class From1toN
    {
        static void Main(string[] args)
        {
            short n = short.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
