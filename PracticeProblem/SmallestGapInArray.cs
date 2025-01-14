using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class SmallestGapInArray
    {
        public static void FindSmallestGap()
        {
            int count = 0,p=0,q=0;
            int smallestGap = int.MaxValue;
            Console.WriteLine("Enter the size of array:");
            string input = Console.ReadLine();
            int size = Convert.ToInt32(input);

            int[] array = new int[size];
            Console.WriteLine("Enter the element of array: ");
            for(int i=0; i<array.Length; i++)
            {
                string arrayInput = Console.ReadLine();
                array[i] = Convert.ToInt32(arrayInput);
            }
            
            for(int i=0; i<array.Length-1; i++)
            {
                for(int j=i+1; j<i+2; j++)
                {
                    count = Math.Abs(array[i] - array[j]);
                    if (count < smallestGap)
                    {
                        p = i;
                        q = j;
                        smallestGap = count;
                    }
                }

            }
            Console.WriteLine("Smallest gap in array is: " + smallestGap + (" (diff bew " + array[p] + ", " + array[q]+")"));
        }
    }
}
