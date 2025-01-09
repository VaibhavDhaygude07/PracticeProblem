using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class NumberToString
    {
        public static void FindFactor()
        {
            Console.WriteLine("Enter a number: ");
            string numberInput = Console.ReadLine();
            int number = Convert.ToInt32(numberInput);

            bool factorial3 = number % 3 == 0;
            bool factorial5 = number % 5 == 0;
            bool factorial7 = number % 7 == 0;



                    if (factorial3 && factorial5 && factorial7)
                    {
                        Console.WriteLine("PlingPlangplong");
                            }
                    else if (factorial3 && factorial5)
                    {
                        Console.WriteLine("PlingPlang");
                            }
                    else if (factorial3 && factorial7)
                    {
                        Console.WriteLine("PlingPlong");
                            }
                    else if (factorial5 && factorial7)
                    {
                        Console.WriteLine("PlangPlong");
                    }
                    else if (factorial3)
                    {
                        Console.WriteLine("Pling");
                    }
                    else if (factorial5)
                    {
                        Console.WriteLine("Plang");
                    }
                    else if (factorial7)
                    {
                        Console.WriteLine("Plong");
                    }
                   
                    else
                    {
                        Console.WriteLine(number);
                    }
                    
                
           
        }
    }
}
