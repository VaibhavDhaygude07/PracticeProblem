using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class AQI
    {
        public static void FindAQI()
        {
            Console.WriteLine("Enter the concentration of pollutants: ");
            string Input = Console.ReadLine();
            int concentration = Convert.ToInt32(Input);

            if (concentration > 0 && concentration <= 50)
            {
                Console.WriteLine("Good");
            }
            else if (concentration > 50 && concentration <= 100)
            {
                Console.WriteLine("Moderate");
            }
            else if (concentration > 100 && concentration <= 150)
            {
                Console.WriteLine("Unhealthy");
            }
            else if (concentration > 150 && concentration <= 200)
            {
                Console.WriteLine("Very Unhealthy ");
            }
            else if (concentration > 200 && concentration <= 500)
            {
                Console.WriteLine("Hazardous");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
