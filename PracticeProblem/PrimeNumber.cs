using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class PrimeNumber
    {//Write a C# program to find prime numbers from 1 to 100.
        public static void FindPrimeNumber()
        {
            bool isPrime = true;
            for(int i=1; i<=100; i++)
            {
                for(int j=2; j<=50; j++)
                {
                    if (i!=j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine(i+" ");
                }
                isPrime = true;
            }
            Console.ReadLine();
        }
    }
}
