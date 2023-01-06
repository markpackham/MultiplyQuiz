﻿using MultiplyQuiz.helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyQuiz.operators
{
    public class SquareRootIt
    {
        public static void squareRootIt()
        {
            Random rnd = new Random();

            int num1 = rnd.Next(1, 50);

            int answer = (int)Math.Sqrt(num1);

            // Do not square numbers that leave behind remainder
            // use %1 != 0 as a check
            while (answer < 0 || Math.Sqrt(num1)%1 != 0)
            {
                num1 = rnd.Next(1, 50);

                answer = (int)Math.Sqrt(num1);
            }

            Console.WriteLine($"{num1} square root = what? Press 0 to quit.");

            try
            {
                CheckUserInput.checkUserInput(answer);
            }
            catch
            {
                Console.WriteLine($"Int32 values only, answer was {answer}");
                squareRootIt();
            }

            squareRootIt();
        }
    }
}
