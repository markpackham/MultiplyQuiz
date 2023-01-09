using MultiplyQuiz.helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyQuiz.operators
{
    public class PowerOper
    {
        public static void powerIt(int pow)
        {
            Random rnd = new Random();

            int num1 = rnd.Next(1, 10);
            int answer = (int)Math.Pow(num1, pow);
            Console.WriteLine($"{num1} to the power of {pow} = what? Press 0 to quit.");

            try
            {
                CheckUserInput.checkUserInput(answer);
            }
            catch
            {
                Console.WriteLine($"Int32 values only, answer was {answer}");
                powerIt(pow);
            }

            powerIt(pow);
        }
    }
}
