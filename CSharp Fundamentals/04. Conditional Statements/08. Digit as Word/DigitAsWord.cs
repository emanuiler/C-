﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Digit_as_Word
{
    class DigitAsWord
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int digit;

            if (int.TryParse(input, out digit))
            {
                switch (digit)
                {
                    case 1:
                        Console.WriteLine("one");
                        break;
                    case 2:
                        Console.WriteLine("two");
                        break;
                    case 3:
                        Console.WriteLine("three");
                        break;
                    case 4:
                        Console.WriteLine("four");
                        break;
                    case 5:
                        Console.WriteLine("five");
                        break;
                    case 6:
                        Console.WriteLine("six");
                        break;
                    case 7:
                        Console.WriteLine("seven");
                        break;
                    case 8:
                        Console.WriteLine("eight");
                        break;
                    case 9:
                        Console.WriteLine("nine");
                        break;
                    case 0:
                        Console.WriteLine("zero");
                        break;
                    default:
                        Console.WriteLine("not a digit");
                        break;
                }
            }
            else
            {
                Console.WriteLine("not a digit");
            }
        }
    }
}
