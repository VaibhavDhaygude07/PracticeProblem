﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class NextDay
    {
        public static void Day() { 
        
            Console.WriteLine("Enter a year: ");
            string yearInput = Console.ReadLine();
            int year = Convert.ToInt32(yearInput);

            Console.WriteLine("Enter a month[1-12]: ");
            string monthInput = Console.ReadLine();
            int month = Convert.ToInt32(monthInput);

             if(month<=0 || month > 12)
             {
                Console.WriteLine("Enter valid month");
                return;
             }

            Console.WriteLine("Enter a day[1-31]: ");
            string dateInput = Console.ReadLine();
            int date = Convert.ToInt32(dateInput);

            if(date<=0 || date > 31){
                Console.WriteLine("Enter valid date");
                return;
            }
            date++;
            Console.WriteLine(year + "-" + month + "-" + date);
        }
    }
}
