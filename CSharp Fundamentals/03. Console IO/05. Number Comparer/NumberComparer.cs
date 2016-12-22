using System;

namespace _05.Number_Comparer
{
    class NumberComparer
    {
        static void Main()
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Max(firstNumber,secondNumber));
        }
    }
}
