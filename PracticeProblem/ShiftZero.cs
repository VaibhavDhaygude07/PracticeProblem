using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class ShiftZero
    {
        public void MoveZero()
        {
            int[] array = new int[5];
            int[] temp = new int[5];

            Console.WriteLine("Enter elements: ");

            for (int i = 0; i < array.Length; i++)
            {
                string arrayInput = Console.ReadLine();
                array[i] = Convert.ToInt32(arrayInput);
            }

            
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0)
                {
                    temp[j++] = array[i];
                }
            }

            
            while (j < array.Length)
            {
                temp[j++] = 0;
            }

            
            for (int i = 0; i < array.Length; i++) 
            {
                array[i] = temp[i];
            }


            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

        }
    }
}
