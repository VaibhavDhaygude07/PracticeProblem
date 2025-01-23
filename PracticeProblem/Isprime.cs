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
            
            for (int i = 0; i < length; i++)
            {
                try
                {
                    string arrayInput = Console.ReadLine();
                    arr[i] = Convert.ToInt32(arrayInput);

                   
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    //throw e;
                }
               
            }
            Console.WriteLine("Prime number: ");
            for(int i=0; i<arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }
           
        }
    }
}
