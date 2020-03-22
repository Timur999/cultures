using System;
using System.Globalization;

namespace culturies
{
    class Program
    {
        static void Main(string[] args)
        {
            //decimal salary = 9999.9199m;

            //Console.WriteLine(salary.ToString("F", CultureInfo.CreateSpecificCulture("en-US")));

            ////CultureInfo.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");

            //Console.WriteLine(salary.ToString("F"));

            //GetService(CultureInfo.CurrentCulture);

            //Display(RoundNumber(salary));

            CultureInfo cultureInfo = CultureInfo.CurrentCulture;

            CashDispenser.DisplayAccountBalacne(cultureInfo);

            Console.ReadKey();
        }

        static void GetService(IFormatProvider serviceProvider)
        {
            Console.WriteLine(serviceProvider.ToString());
        }

        static decimal RoundNumber(decimal number)
        {
            return Math.Round(number, 3);
        }

        static void Display (decimal number)
        {
            Console.WriteLine(number.ToString("F", CultureInfo.InvariantCulture));
            Console.WriteLine(number);
        }
    }
}
