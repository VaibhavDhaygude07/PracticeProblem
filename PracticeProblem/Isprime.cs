using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class Isprime
    {
        public static void PrimeNumber()
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter the element of array: ");
            int length = arr.Length;
            int count = 0;
            for (int i = 0; i < length - 1; i++)
            {
                string arrayInput = Console.ReadLine();
                arr[i] = Convert.ToInt32(arrayInput);
            }
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 2; j < arr[i] / 2; j++)
                {
                    if (arr[i] % j == 0)
                    {
                        count = 1;
                    }


                }
                if (count == 0)
                {
                    Console.WriteLine(arr[i]);
                }
                else
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}
