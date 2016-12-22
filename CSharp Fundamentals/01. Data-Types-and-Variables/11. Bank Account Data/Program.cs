using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Bank_Account_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            /*A bank account has a holder name (first name, middle name and last name),
             *  available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
             *  Declare the variables needed to keep the information for a single bank account using 
             *  the appropriate data types and descriptive names.*/
            string firstName = "Emanuil";
            string middleName = "Andreev";
            string lastName = "Mihaylov";
            decimal balance = 9999999999999999999999999999m;
            string bankName = "FIBank";
            ulong firstCreditCardNumber = 555511225047;
            ulong secondCreditCardNumber = 530011225067;
            ulong thirdCreditCardNumber = 534311225023;
            Console.WriteLine("{0}\r\n{1}\r\n{2}\r\n{3}\r\n{4}\r\n{5}\r\n{6}\r\n{7}",
                firstName, middleName, lastName, balance, bankName,
                firstCreditCardNumber,secondCreditCardNumber,thirdCreditCardNumber);
        }
    }
}
