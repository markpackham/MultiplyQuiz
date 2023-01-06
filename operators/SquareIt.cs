using MultiplyQuiz.helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiplyQuiz.helpers;

namespace MultiplyQuiz.operators
{
    public class SquareIt
    {
        public static void squareIt()
        {
            Random rnd = new Random();

            int num1 = rnd.Next(1, 100);
            int answer = (int)Math.Pow(num1, 2);
            Console.WriteLine($"{num1} squared = what? Press 0 to quit.");

            try
            {
                CheckUserInput.checkUserInput(answer);
            }
            catch
            {
                Console.WriteLine($"Int32 values only, answer was {answer}");
                squareIt();
            }

            squareIt();
        }
    }
}
