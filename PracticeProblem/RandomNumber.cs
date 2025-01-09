using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class RandomNumber
    {
        public static void AverageOfNumber()
        {
            Random rnd = new Random();
            int number1 = rnd.Next(10, 51);
            Console.WriteLine(number1);
            int number2 = rnd.Next(10, 51);
            Console.WriteLine(number2);
            int number3 = rnd.Next(10, 51);
            Console.WriteLine(number3);
            int number4 = rnd.Next(10, 51);
            Console.WriteLine(number4);
            int number5 = rnd.Next(10, 51);
            Console.WriteLine(number5);

            int average = (number1 + number2 + number3 + number4 + number5) / 5;
            Console.WriteLine("Average number is: "+ average);
        }
    }
}
