using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class Factorial
    {
        public static void FindFactorial()
        {
            Console.WriteLine();
            Console.WriteLine("Enter a number: ");
            string numberInput = Console.ReadLine();
            int number = Convert.ToInt32(numberInput);
            int factorial = 1;

            for(int i =1; i<=number; i++)
            {
                factorial = factorial * i;
            }

            Console.WriteLine(factorial);
        }
    }
}
