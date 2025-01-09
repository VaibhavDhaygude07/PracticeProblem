using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class StudentGrade
    {
        public static void FindGrade()
        {
            Console.WriteLine("Enter student score: ");
            string scoreInput = Console.ReadLine();
            int score = Convert.ToInt32(scoreInput);

            if (score >= 90 && score <= 100)
            {
                Console.WriteLine("Student grade: A");
            }

            else if (score >= 80 && score <= 89)
            {
                Console.WriteLine("Student grade: B");
            }
            else if (score >= 70 && score <= 79)
            {
                Console.WriteLine("Student grade: C");
            }
            else if (score >= 60 && score <= 69)
            {
                Console.WriteLine("Student grade: D");
            }
            else if (score >= 0 && score <= 59)
            {

                Console.WriteLine("Student grade: F");
            }
        }
    }
}
