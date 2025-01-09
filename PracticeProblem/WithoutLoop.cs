using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class WithoutLoop
    {
        public static int Number(int n)
        {
            if (n > 100)
            {
                return 1;
                
            }
            else
            {
                Console.Write(n + " ");
                return Number(n + 1);
            }
        }
    }
}
