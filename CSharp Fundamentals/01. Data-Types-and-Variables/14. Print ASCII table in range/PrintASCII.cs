using System;
using System.Text;

class PrintASCII
{
    static void Main()
    {
        //Console.OutputEncoding = Encoding.ASCII;
        for (byte i = 33; i <= 126; i++)
        {
            Console.Write("{0}", (char)i);
        }
    }
}


