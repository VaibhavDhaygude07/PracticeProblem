using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class PrintNumber
    {
        public static void Number()
        {
            Console.WriteLine("Enter a number: ");
            string number = Console.ReadLine();

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(number);
            }
        }
    }
}
