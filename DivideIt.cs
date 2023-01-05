using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyQuiz
{
    public class DivideIt
    {
        public static void divideIt()
        {
            Random rnd = new Random();

            int num1 = rnd.Next(1, 100);
            int num2 = rnd.Next(1, 100);
            int answer = num2 / num1;

            while(answer < 0 || num2%num1 != 0)
            {
                num1 = rnd.Next(1, 10);
                num2 = rnd.Next(1, 100);
                answer = num2 / num1;
            }

            Console.WriteLine($"{num2} / {num1} = what? Press 0 to quit.");

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
                divideIt();
            }

            divideIt();
        }
    }
}
