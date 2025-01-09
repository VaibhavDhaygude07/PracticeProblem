using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class SquareSumDiff
    {
        public static void SumDiff()
        {
            Console.Write("Enter first number: ");
            string num1 = Console.ReadLine();
            int number1 = Convert.ToInt32(num1);

            Console.Write("Enter second number: ");
            string num2 = Console.ReadLine();
            int number2 = Convert.ToInt32(num2);

            
            int num1Squar = number1 * number1;
            int num2Square = number2 * number2;

            int sum = num1Squar + num2Square;
            int difference = num1Squar - num2Square;

            Console.WriteLine("Sum of two square number is: " + sum + " and difference of two square number is: " + difference);
        }
    }
}
