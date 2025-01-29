using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class InheritanceDemo
    {
        
        public static void Inheritance()
        {
            //Write a C# program to demonstarte working of inheritance.
            //sample data: take a class an define varibles, In other class
            //perform sum of those two variables using inheritance.

            Console.WriteLine("Enter first number:");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int number2 = int.Parse(Console.ReadLine());
            Child child = new Child();
            int result = child.sum(number1, number2);
            Console.WriteLine("Sum of two numbers: "+result);
        }
        
    }
    class Child : InheritanceDemo
    {
        public int sum(int num1, int num2)
        {
            return num1 + num2;
        }
        
    }
}
