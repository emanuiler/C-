using System;
using System.Numerics;

class CalculateAgain
{
    static void Main()
    {
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        BigInteger k = BigInteger.Parse(Console.ReadLine());

        BigInteger sum = 1;
        for (BigInteger i = n; i > k; i--)
        {
            sum = sum * i;
        }

        Console.WriteLine(sum);
    }
}