using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class CityName
    {
        public static void UppercaseLowercase()
        {
            Console.WriteLine("Enter place name where you would like to visit most: ");
            string city = Console.ReadLine();

            Console.WriteLine("Uppercase: " + city.ToUpper() + " Lowercase: " + city.ToLower());
        }
    }
}
