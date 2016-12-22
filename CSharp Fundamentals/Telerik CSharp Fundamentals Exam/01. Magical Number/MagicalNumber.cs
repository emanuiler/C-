using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Magical_Number
{
    class MagicalNumber
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int thirdDigit = number % 10;
            int secondDigit = (number / 10) % 10;
            int firstDigit = (number / 10) / 10;
            double result = 0;
            if (secondDigit % 2 == 0)
            {
                result = (firstDigit + secondDigit) * thirdDigit;
            }
            else if (secondDigit % 2 != 0)
            {
                result = (double)(firstDigit * secondDigit) / (double)thirdDigit;
            }
            Console.WriteLine("{0:F2}", result);
        }
    }
}
