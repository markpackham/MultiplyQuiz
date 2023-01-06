﻿using MultiplyQuiz.helpers;

namespace MultiplyQuiz.operators
{
    public class SubOper
    {
        public static void subIt()
        {
            Random rnd = new Random();

            int num1 = rnd.Next(1, 100);
            int num2 = rnd.Next(1, 100);
            int answer = num1 - num2;
            Console.WriteLine($"{num1} - {num2} = what? Press 0 to quit.");

            try
            {
                CheckUserInput.checkUserInput(answer);
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