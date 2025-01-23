using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    internal class RockPaperScissor
    {
        public static void Game()
        {
            Console.WriteLine("Enter first person choice(rock, paper, scissor): ");
            string input1 = Console.ReadLine();

            Console.WriteLine("Enter second person choice(rock, paper, scissor): ");
            string input2 = Console.ReadLine();

            if (input1 == "rock" && input2 == "scissor")
            {
                Console.WriteLine("First person win");
            }
            else if (input1 == "scissor" && input2 == "paper")
            {
                Console.WriteLine("First person win");
            }
            else if (input1 == "paper" && input2 == "rock")
            {
                Console.WriteLine("First person win");
            }
            else if (input1 == "rock" && input2 == "paper")
            {
                Console.WriteLine("Second person win");
            }
            else if (input1 == "paper" && input2 == "scissor")
            {
                Console.WriteLine("Second person win");
            }
            else if (input1 == "scissor" && input2 == "rock")
            {
                Console.WriteLine("Second person win");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
