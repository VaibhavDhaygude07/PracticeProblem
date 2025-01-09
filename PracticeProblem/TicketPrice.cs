using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class TicketPrice
    {
        //Write a C# program that calculates the price of a movie ticket based on the age of the customer and the time of the movie.
        public static void MovieTicketPrice()
        {
            Console.WriteLine("Enter customer age: ");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);

            Console.WriteLine("Enter the time of the movie: ");
            string timeInput= Console.ReadLine();
            double time = Convert.ToDouble(timeInput);

            if(age>=18 && time==7.00)
            {
                Console.WriteLine("Price of a movie ticket is: 300");
            }
            else if(age<18 && time == 12.30)
            {
                Console.WriteLine("Price of a movie ticet is: 199");
            }
        }
    }
}
