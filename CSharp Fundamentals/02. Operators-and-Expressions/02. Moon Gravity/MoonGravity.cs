using System;

namespace _02.Moon_Gravity
{
    class MoonGravity
    {
        static void Main()
        {
            float earthWeight = float.Parse(Console.ReadLine());
            float moonWeight = (earthWeight * 17) / 100f;
            Console.WriteLine("{0:0.000}",moonWeight);
        }
    }
}
