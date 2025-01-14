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

            Console.WriteLine("Original ArrayList elements:");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            
            HashSet<object> uniqueSet = new HashSet<object>();
            foreach (var item in array)
            {
                uniqueSet.Add(item);
            }

           
            ArrayList uniqueList = new ArrayList();
            foreach (var item in uniqueSet)
            {
                uniqueList.Add(item);
            }

            Console.WriteLine("After removing duplicate elements from the ArrayList:");
            foreach (var item in uniqueList)
            {
                Console.WriteLine(item);
            }

        }
    }
}
