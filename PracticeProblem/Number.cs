﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class Number
    {
        public static void PrintNumber()
        {
            for (int i = 2000; i <= 3200; i++)
            {
                if (i % 7 == 0 && i % 5 != 0)
                {
                    Console.Write(i + ", ");
                }
            }
        }
    }
}
