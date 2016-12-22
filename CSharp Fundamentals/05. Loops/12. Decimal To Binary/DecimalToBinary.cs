using System;
using System.Numerics;
using System.Text;

class DecimalToBinary
{
    static void Main()
    {
        BigInteger number = BigInteger.Parse(Console.ReadLine());
        StringBuilder sb = new StringBuilder();
        do
        {
            BigInteger remaining = number % 2;
            sb.Append(remaining);
            BigInteger result = number / 2;
            number = number / 2;
            remaining = number % 2;
        } while (number > 0);

        string str = sb.ToString();
        string reversed = ReverseString(str.ToString());
        Console.WriteLine(reversed);
    }
    public static string ReverseString(string s)
    {
        StringBuilder revsb = new StringBuilder();
        for (int i = s.Length - 1; i >= 0; i--)
        {
            revsb.Append(s[i]);
        }
        return revsb.ToString();
    }
}

