using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class TemperatureConversion
    {
        public static void FindTemp()
        {
            Console.WriteLine("Enter temperature: ");
            string temperatureInput = Console.ReadLine();
            int temprature = Convert.ToInt32(temperatureInput);

            Console.WriteLine("For Fahrenheit to Celsius enter 0  and for Celsius to Fahrenheit enter 1: ");
            string tempType = Console.ReadLine();
            int temp = Convert.ToInt32(temprature);

            if (temp == 0)
            {
                temprature = (temprature - 32) * (5 / 9);
                Console.WriteLine("Teamprature is " + temprature  + " celsius");
            }
            else
            {
                temprature = (temprature * (9 / 5) + 32);
                Console.WriteLine("Teamprature is: " + temprature+ " Fahrenheit");
            }               
            

            Console.WriteLine();
        }
    }
}
