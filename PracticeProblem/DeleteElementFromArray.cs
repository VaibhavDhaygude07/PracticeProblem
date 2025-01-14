using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PracticeProblem
{
    internal class DeleteElementFromArray
    {
        public static void DeleteElement()
        {
            Console.WriteLine("Enter the size of array");
            string sizeInput = Console.ReadLine();
            int size = Convert.ToInt32(sizeInput);

            int[] array = new int[size];
            Console.WriteLine("Enter the element of array: ");
            for (int i = 0; i < array.Length; i++)
            {
                string arr  =Console.ReadLine();
                array[i] = Convert.ToInt32(arr);
            }
            Console.WriteLine("Enter the position where to delete: ");
            string elementInput = Console.ReadLine();
            int element = Convert.ToInt32(elementInput); 

            for (int i = 0; i < array.Length; i++)
            {
                if(i != element)
                {
                    Console.WriteLine(array[i]+" ");
                }
            }
        }
       

    }
}
