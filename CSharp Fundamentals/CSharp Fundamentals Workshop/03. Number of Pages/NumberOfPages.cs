using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Number_of_Pages
{
    class NumberOfPages
    {
        static void Main(string[] args)
        {
            long d = long.Parse(Console.ReadLine());
            long numberOfDigits = d;
            long counter = 0;
            long n = 1;
            while (d > 1)
            {
                n++;
                int currentDigitsInN = n.ToString().Length;
                d -= currentDigitsInN;
                
                //ulong digits = d % 10;
                //counter++;
                //d = d / 10;
            }
            Console.WriteLine(n);

            //switch (counter)
            //{

            //    case 1:
            //        Console.WriteLine(numberOfDigits);
            //        break;
            //    case 2:
            //        ulong temp2 = (numberOfDigits - 9) / counter;
            //        ulong n2 = 9 + temp2;
            //        Console.WriteLine(n2);
            //        break;
            //    case 3:
            //        ulong temp3 = (numberOfDigits - 9 * (1 + 10 * 2)) / counter;
            //        ulong n3 = 99 + temp3;
            //        Console.WriteLine(n3);
            //        break;
            //    case 4:
            //        ulong temp4 = (numberOfDigits - 9* (1 + 10 * 2 + 100 * 3)) / counter;
            //        ulong n4 = 999 + temp4;
            //        Console.WriteLine(n4);
            //        break;
            //    case 5:
            //        ulong temp5 = (numberOfDigits - 9 * (1 + 10 * 2 + 100 * 3 + 1000 * 4)) / counter;
            //        ulong n5 = 9999 + temp5;
            //        Console.WriteLine(n5);
            //        break;
            //    case 6:
            //        ulong temp6 = (numberOfDigits - 9 * (1 + 10 * 2 + 100 * 3 + 1000 * 4 + 10000 * 5)) / counter;
            //        ulong n6 = 99999 + temp6;
            //        Console.WriteLine(n6);
            //        break;
            //    case 7:
            //        ulong temp7 = (numberOfDigits - 9 * (1 + 10 * 2 + 100 * 3 + 1000 * 4 + 10000 * 5 + 100000 * 6)) / counter;
            //        ulong n7 = 999999 + temp7;
            //        Console.WriteLine(n7);
            //        break;
            //case 8:
            //    ulong temp8 = (numberOfDigits - (9 + 90 * 2 + 900 * 3 + 9000 * 4 + 90000 * 5 + 900000 * 6 + 9000000 * 7)) / counter;
            //    ulong n8 = 9999999 + temp8;
            //    Console.WriteLine(n8);
            //    break;
            //case 9:
            //    ulong temp9 = (numberOfDigits - (9 + 90 * 2 + 900 * 3 + 9000 * 4 + 90000 * 5 + 900000 * 6 + 9000000 * 7 + 90000000 * 8)) / counter;
            //    ulong n9 = 99999999 + temp9;
            //    Console.WriteLine(n9);
            //    break;

            //default:
            //    Console.WriteLine(0);
            //    break;
            //}
        }
    }
}
