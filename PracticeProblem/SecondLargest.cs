using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace PracticeProblem
{
    internal class SecondLargest
    {
        public static void SecondLargestElement()
        {
            //Write a program in C# Sharp to find the second largest element in an array. 
            //Test Data :
            //Input the size of array: 5
            //Input 5 elements in the array :
            //element - 0 : 2
            //element - 1 : 9
            //element - 2 : 1
            //element - 3 : 4
            //element - 4 : 6
            //Expected Output :
            //The Second largest element in the array is: 6
            
            Console.WriteLine("Enter the size of array");
            string sizeInput = Console.ReadLine();
            int size = Convert.ToInt32(sizeInput);

            int[] array = new int[size];
            Console.WriteLine("Enter the element of array: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("element - " + i+" ");
                string arr = Console.ReadLine();
                array[i] = Convert.ToInt32(arr);
            }

            int max = array[0];
            int secMax = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    secMax = max;
                    max= array[i];
                }
            }
            Console.WriteLine("Second largest element: " + secMax);


        }
    }
}
