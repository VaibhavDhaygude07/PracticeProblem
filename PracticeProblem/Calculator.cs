using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class Calculator
    {
        public static void Operations()
        {
            Console.WriteLine("Enter first number: ");
            string number1Input = Console.ReadLine();
            int number1 = Convert.ToInt32(number1Input);

            Console.WriteLine("Enter second number: ");
            string number2Input = Console.ReadLine();
            int number2 = Convert.ToInt32(number2Input);

            Console.WriteLine("What operation you want to perform(+,-,*,/): ");
            string operatorInput = Console.ReadLine();


            if (operatorInput == "+")
            {
                int sum = number1 + number2;
                Console.WriteLine(sum);
            }
            else if (operatorInput == "-")
            {
                int sub = number2 - number2;
                Console.WriteLine(sub);
            }
            else if (operatorInput == "*")
            {
                int multi = number1 * number2;
                Console.WriteLine(multi);
            }
            else if (operatorInput == "/")
            {
                double div = number1 / number2;
                Console.WriteLine(div);
            }
            else
            {
                Console.WriteLine("Invalid operator ");
            }
        }
    }
}
