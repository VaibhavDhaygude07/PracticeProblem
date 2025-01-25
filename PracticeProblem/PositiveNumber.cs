using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class PositiveNumber
    {
        public static void PositiveNum()
        {

            //Write a program in C# to find the positive numbers from a list of
            //numbers using two where conditions in LINQ Query.

            List<int> numbers = new List<int> { -10, 15, -20, 30, -5, 40, 0 };

            
            var positiveNumbers = from num in numbers
                                  where num > 0
                                  where num % 2 == 0
                                  select num;

         
            Console.WriteLine("Positive numbers:");
            foreach (var number in positiveNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
