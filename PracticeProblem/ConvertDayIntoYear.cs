using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class ConvertDayIntoYear
    {
        public static void FindYearMonthWeek()
        {
            Console.WriteLine("Enter the days: ");
            string input = Console.ReadLine();
            int day = Convert.ToInt32(input);

            int year, month, weeks;
            year = day / 365;
            month = day /30;
            weeks = day / 7;

            Console.WriteLine("Years:" + year + "\n month: " + month + "\n weeks:" + weeks);
        }
    }
}
