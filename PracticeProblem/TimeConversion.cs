using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class TimeConversion
    {
        public static void Conversion()
        {
            //Write a C# program that converts hours into minutes and  seconds.
            //sample data:
            //input: 1 hr
            //output: 3600 sec
            Console.WriteLine("Enter hours: ");
            int hours = int.Parse(Console.ReadLine());
            int minute, second;
            minute = hours * 60;
            second = minute * 60;

            Console.WriteLine(hours +"Hr: "+ minute+" min and "+second+" sec");
        }
    }
}
