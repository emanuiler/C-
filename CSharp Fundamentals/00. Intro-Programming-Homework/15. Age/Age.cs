using System;
using System.Globalization;

class Age
{
    static void Main()
    {
        DateTime input = DateTime.Parse(Console.ReadLine());
        DateTime current = DateTime.Today;
        double days = (current - input).TotalDays;
        double age = Math.Truncate(days / 365.25);
        DateTime dateInTenYears = DateTime.Today.AddYears(10);
        double daysInTenYears = (dateInTenYears - input).TotalDays;
        double ageAfterTenYears = Math.Truncate(daysInTenYears / 365.25);
        Console.WriteLine(age);
        Console.WriteLine(ageAfterTenYears);
    }
}

