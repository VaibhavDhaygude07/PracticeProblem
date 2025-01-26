using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class IntegerLoop
    {
        public static void Loop()
        {
           
            Console.Write("Enter the number of iterations: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) 
            {
                for (int j = 1; j <= i; j++) 
                {
                    Console.Write(i);
                }
            }

        }
    }
}
