using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class RemoveDuplicates
    {
        public static void RemoveFromArray()
        {
                    // Write a C# Sharp program to remove all duplicate elements from a given array and returns a new array.
                    //Test Data:
                    // Original array elements:
                    // 25
                    //Anna
                    //False
                    //25
                    //4 / 15 / 2021 12:10:51 PM
                    //112.22
                    //Anna
                    //False

                    //After removing duplicate elements from the said array:
                    //25
                    //Anna
                    //False
                    //4 / 15 / 2021 12:10:51 PM
                    //112.22
            ArrayList array = new ArrayList();
            int x=25;
            string str = "Anna";
            bool  value= false;
            int y = 25;
            DateTime d = DateTime.Now;
            double z = 112.22;
            string str1 = "Anna";
            bool value1 = false;
            array.Add(x);
            array.Add(str);
            array.Add(value);
            array.Add(y);
            array.Add(d);
            array.Add(z);
            array.Add(str1);
            array.Add(value1);

           // int[] distinct = array.Distinct().ToArray();

            foreach (object i in array)
            {

                Console.WriteLine(i + " ");
            }

        }
    }
}
