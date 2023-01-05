using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyQuiz
{
    internal class SubIt
    {
        static void subIt()
        {
            Random rnd = new Random();

            int num1 = rnd.Next(1, 100);
            int num2 = rnd.Next(1, 100);
            int answer = num1 - num2;
            Console.WriteLine($"{num1} - {num2} = what? Press 0 to quit.");

            try
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
            catch
            {
                Console.WriteLine($"Int32 values only, answer was {answer}");
                subIt();
            }

            subIt();
        }
    }
}
