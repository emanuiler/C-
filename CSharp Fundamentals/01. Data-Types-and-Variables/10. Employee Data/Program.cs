using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Emanuil";
            string lastName = "Mihaylov";
            short age = 27;
            char gender = 'm';
            ulong personalId = 8306112507;
            ulong uniqueNumber = 2756000027569999;
            Console.WriteLine("{0}\r\n{1}\r\n{2}\r\n{3}\r\n{4}",
                firstName, lastName, age, gender, personalId, uniqueNumber);
        }
    }
}
