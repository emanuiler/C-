using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Going_to_a_party
{
    class GoingToAParty
    {
        static void Main(string[] args)
        {
            string input = /*Console.ReadLine()*/"abcAk^zzz^";
            bool isLower = true;
            int start = 0;
            int position = 0;
            int currentPosition = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int valueOfIndex = (int)input[i] % 32;
                start = valueOfIndex;
                currentPosition = input[i];
                if (char.IsUpper(input[i]))
                {
                    isLower = false;
                    currentPosition -= valueOfIndex;
                }
                else if (valueOfIndex == 30)
                {

                    break;
                }
                else
                {
                    currentPosition += valueOfIndex;
                }

                position = currentPosition;
            }
            if (position < input.Length)
            {
                Console.WriteLine("Djor and Djano are at the party at {0}!", currentPosition);
            }
            else if (position > input.Length || start < 0)
            {
                Console.WriteLine("Djor and Djano are lost at {0}!", currentPosition);
            }

        }
    }
}
