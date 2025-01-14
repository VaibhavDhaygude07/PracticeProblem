using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class RepeatedElementInArray
    {
        public static void ReapeatedElement()
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter the array elements: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.WriteLine("Reapeated element in array is "+arr[i]);
                        return;
                    }
                }
            }
            
        }
    }
}
