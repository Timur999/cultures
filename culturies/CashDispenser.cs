using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace culturies
{
    static class CashDispenser
    {
        private static decimal Money { get; set; }

        static CashDispenser()
        {
            Money = 12345.1498m;
        }

        public static void DisplayAccountBalacne(IFormatProvider serviceProvider)
        {
            Console.WriteLine(Money.ToString("F", CultureInfo.CreateSpecificCulture(serviceProvider.ToString())));
        }
    }
}
