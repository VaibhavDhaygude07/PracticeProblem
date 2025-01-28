using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class CheckOperator
    {
        public static void Operator()
        {
            //Write a program using a switch statement that takes one character value 
            //from the user and checks whether the entered value is an 
            //arithmetic operator, logical operator, conditional operator, 
            // relational operator or something else.
            //Sample data:
            // arithmetic = +,-,*Logical = " &&, ||  " Relational = "==, <, >"

            Console.WriteLine("Enter the character");
            string charecter = Convert.ToString(Console.ReadLine());

            switch (charecter)
            {
                case "+":
                case "-":
                case "*":
                    Console.WriteLine("Arithmetic Operator");
                    break;
                case "&&":
                case "||":
                    Console.WriteLine("Logical Operator");
                    break;
                case "==":
                case "<":
                case ">":
                    Console.WriteLine("Relational Operator");
                    break;
                default:
                    Console.WriteLine("Unkown operator");
                    break;
            }
        }
    }
}
