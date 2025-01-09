using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class MoveZeroArray
    {
        public static void MoveZero()
        {
            int[] array = new int[] { 1, 0, 9, 8, 0, 9, 8, 0, 9 };
            int count = 0;

            Console.WriteLine("Original array: ");
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();

            // Move non-zero elements to the front
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0)
                {
                    array[count++] = array[i];
                }
            }

            // Fill remaining positions with zero
            while (count < array.Length)
            {
                array[count++] = 0;
            }

            // Print the modified array
            Console.WriteLine("After moving zero:");
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
        }
    }
}
