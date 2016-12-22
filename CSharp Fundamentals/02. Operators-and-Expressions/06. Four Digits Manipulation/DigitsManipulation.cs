using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Four_Digits_Manipulation
{
    class DigitsManipulation
    {
        static void Main()
        {
            string input = Console.ReadLine();

            //sum
            int sum = 0;
            int number = Convert.ToInt32(input);
            for (int i = 0; i < 4; i++)
            {
                int last = number % 10;
                number = number / 10;
                sum += last;
            }
            Console.WriteLine(sum);

            //reversed
            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(input[i]);
            }
            Console.WriteLine();

            //last digit in first place
            for (int i = input.Length - 1; i >= 3; i--)
            {
                Console.Write(input[i]);
            }
            for (int i = 0; i <= input.Length - 2; i++)
            {
                Console.Write(input[i]);
            }
            Console.WriteLine();

            // exchange index 2 and index 3
            Console.Write(input.First());
            for (int i = 2; i >= 1; i--)
            {
                Console.Write(input[i]);
            }
            Console.Write(input.Last());
            Console.WriteLine();
        }
    }
}
