using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class SquarOfArray
    {
        //Write a program in C# to find the number of an array
        //and the square of each number in LINQ Query.
        //sample data:
        //input: int[] arr

        public static void Array()
        {
            int[] arr = new int[] { 1, 4, 3, 6, 4, 2 };

            var squarOfArray = from num in arr
                               select new {Number=num, squar = num * num };
            foreach(var num in squarOfArray)
            {
                Console.WriteLine($"Squar of {num.Number}: {num.squar}");
            }
                                
        }
    }
}
