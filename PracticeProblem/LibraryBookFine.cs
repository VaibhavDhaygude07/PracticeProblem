using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class LibraryBookFine
    {
        public static void FindFine()
        {
            Console.WriteLine("Enter the number of days a book is overdue: ");
            string numberInput = Console.ReadLine();
            int number = Convert.ToInt32(numberInput);

            double fine = number - 7;

            Console.WriteLine("Fine of overdue library book is:" + fine * (0.5) + "$");
        }
    }
}
