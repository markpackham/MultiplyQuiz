using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyQuiz.helpers
{
    public class CheckUserInput
    {
        public static void checkUserInput(int answer)
        {
            int guess = Convert.ToInt32(Console.ReadLine());
            if (guess == 0)
            {
                Environment.Exit(0);
            }
            else if (guess == answer)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine($"Wrong answer was {answer}");
            }
        }
    }
}
