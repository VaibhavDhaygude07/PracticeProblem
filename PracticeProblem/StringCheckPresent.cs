using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class StringCheckPresent
    {
        public static void StringCheck()
        {
            Console.WriteLine("Enter a string: ");
            string str = Console.ReadLine();

            if (str.Contains('a') && str.Contains('e') && str.Contains('p'))
            {
                Console.WriteLine("All Present");
            }
            else if (str.Contains('a') && str.Contains('e'))
            {
                Console.WriteLine("One or more present ");
            }
            else if (str.Contains('a') || str.Contains('e') || str.Contains('p'))
            {
                Console.WriteLine("One peresent");
            }
            else
            {
                Console.WriteLine("None Present");
            } 
            
        }
    }
}
