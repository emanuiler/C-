using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sort_3_Numbers
{
    class Sort3Numbers
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            // To write case where a==b || b==c a==c or something like that
            //--------------------------------------------------- Max number
            int maxNumber = int.MinValue;
            if (a > maxNumber)
            {
                maxNumber = a;
            }
            if (b > maxNumber)
            {
                maxNumber = b;
            }
            if (c > maxNumber)
            {
                maxNumber = c;
            }
            //---------------------------------------------------- Min number
            int minNumber = int.MaxValue;
            if (a < minNumber)
            {
                minNumber = a;
            }
            if (b < minNumber)
            {
                minNumber = b;
            }
            if (c < minNumber)
            {
                minNumber = c;
            }
            //-----------------------------------------------------  Middle number            
            int middleNumber = int.MinValue;
            if (a > minNumber && a < maxNumber)
            {
                middleNumber = a;
            }
            else if (b > minNumber && b < maxNumber)
            {
                middleNumber = b;
            }
            else if (c > minNumber && c < maxNumber)
            {
                middleNumber = c;
            }

            if (a == b || b == c || a == c)
            {
                Console.WriteLine("{0} {1} {2}", maxNumber, minNumber, minNumber);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", maxNumber, middleNumber, minNumber);
            }

            //List<int> numbersList = new List<int>();
            //numbersList.Add(a);
            //numbersList.Add(b);
            //numbersList.Add(c);
            //numbersList.Sort();
            //Console.WriteLine("{0} {1} {2}",
            //numbersList[2], numbersList[1], numbersList[0]);
        }
    }
}
