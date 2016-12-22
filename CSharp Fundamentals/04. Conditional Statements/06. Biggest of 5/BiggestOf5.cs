using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Biggest_of_5
{
    class BiggestOf5
    {
        static void Main(string[] args)
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            float d = float.Parse(Console.ReadLine());
            float e = float.Parse(Console.ReadLine());
            List<float> numbersList = new List<float>();
            numbersList.Add(a);
            numbersList.Add(b);
            numbersList.Add(c);
            numbersList.Add(d);
            numbersList.Add(e);
            numbersList.Sort();
            Console.WriteLine(numbersList[4]);
        }
    }
}
