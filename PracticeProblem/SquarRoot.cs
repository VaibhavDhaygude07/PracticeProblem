using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class SquarRoot
    {
        public static void FindSquareRoot()
        { 
            Console.WriteLine("Enter the number which you want to find squarroot: ");
            string inputNum = Console.ReadLine();
            int number = Convert.ToInt32(inputNum);

            int res = 1;
            while (res * res <= number)
            {
                res++;
            }
            Console.WriteLine(res-1);

        }
    }
}
