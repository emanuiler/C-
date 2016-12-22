using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Company_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            string companyName = Console.ReadLine();
            string companyAddress = Console.ReadLine();
            string companyPhoneNumber = Console.ReadLine();
            string fax = Console.ReadLine();
            string website = Console.ReadLine();
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            string telNumber = Console.ReadLine();

            /*Telerik Academy
Address: 231 Al. Malinov, Sofia
Tel. +359 888 55 55 555
Fax: (no fax)
Web site: http://telerikacademy.com/
Manager: Nikolay Kostov (age: 25, tel. +359 2 981 981)*/

            Console.WriteLine(companyName);
            Console.WriteLine("Address: {0}", companyAddress);
            Console.WriteLine("Tel. {0}", companyPhoneNumber);
            if (fax.Count().Equals(0))
            {
                Console.WriteLine("Fax: (no fax)");
            }
            else
            {
                Console.WriteLine("Fax: {0}", fax);
            }
            
            Console.WriteLine("Web site: {0}", website);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})",
                firstName, lastName, age, telNumber);
        }
    }
}
