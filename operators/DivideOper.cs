using MultiplyQuiz.helpers;

namespace MultiplyQuiz.operators
{
    public class DivideOper
    {
        public static void divideIt()
        {
            Random rnd = new Random();

            int num1 = rnd.Next(1, 100);
            int num2 = rnd.Next(1, 100);
            int answer = num2 / num1;

            while (answer < 0 || num2 % num1 != 0)
            {
                num1 = rnd.Next(1, 10);
                num2 = rnd.Next(1, 100);
                answer = num2 / num1;
            }

            Console.WriteLine($"{num2} / {num1} = what? Press 0 for Main Menu.");

            try
            {
                CheckUserInput.checkUserInput(answer);
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
