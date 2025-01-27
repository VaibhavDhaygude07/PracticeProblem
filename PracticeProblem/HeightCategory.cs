using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class HeightCategory
    {
        public static void Category()
        {
            //Program to take height as input and print .its category as
            //Dwarf, Average, and Tall.sample data:
            //Dwarf= below 150, Tall= above 160, avg= between 155 and 160

            Console.WriteLine("Enter the height: ");
            int height = Convert.ToInt32(Console.ReadLine());

            if (height <= 150)
            {
                Console.WriteLine("Dwarf");
            }
            else if (height > 160)
            {
                Console.WriteLine("Tall");
            }
            else if(height>=155 && height <= 160)
            {
                Console.WriteLine("Average");
            }
        }
    }
}
