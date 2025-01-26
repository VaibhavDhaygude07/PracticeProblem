using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class TemperatureConversion2
    {

        //Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit. 
        public static void Conversion()
        {
            try
            {
                Console.Write("Enter the amount of Celsius: ");
                string input = Console.ReadLine();

                double celsius = Convert.ToDouble(input);

                double kelvin = celsius + 273.15;
                double fahrenheit = (celsius * 9 / 5) + 32;

                Console.WriteLine("Kelvin" + kelvin);
                Console.WriteLine("Fahrenheit" + fahrenheit);
            }
            catch (FormatException)
            {

                Console.WriteLine("Please enter a valid number for Celsius.");
            }
        }
    }
}
