using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class ArrayAverage
    {
        public static void Average()
        {
            float[] arr = new float[5];
            float average = 0;
            float sum = 0;

            Console.WriteLine("Enter array element: ");
            for (int i = 0; i < arr.Length; i++)
            {
                string array = Console.ReadLine();
                arr[i] = Convert.ToSingle(array);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            average = sum / arr.Length;
            Console.WriteLine(average);
        }
    }
}
