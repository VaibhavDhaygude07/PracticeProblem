using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class Circle
    {
        public static void FindParameterArea()
        {
            Console.WriteLine("Enter diameter of circle: ");
            string diameterInput = Console.ReadLine();
            int diameter = Convert.ToInt32(diameterInput);

            double perimeter = Math.PI * diameter;
            Console.WriteLine("Perimeter of a circle is: " + perimeter);

            double area = Math.PI * (Math.Pow(diameter, 2)) / 2;
            Console.WriteLine("Area of circle is: " + area);
        }
    }
}
