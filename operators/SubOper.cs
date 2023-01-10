using MultiplyQuiz.helpers;

namespace MultiplyQuiz.operators
{
    public class SubOper
    {
        public static void subIt(int maxVal)
        {
            Random rnd = new Random();

            int num1 = rnd.Next(1, maxVal);
            int num2 = rnd.Next(1, maxVal);
            int answer = num1 - num2;

            while (answer == 0)
            {
                num1 = rnd.Next(1, maxVal);
                num2 = rnd.Next(1, maxVal);
                answer = num1 - num2;
            }

            Console.WriteLine($"{num1} - {num2} = what? Press 0 for Main Menu.");

            try
            {
                CheckUserInput.checkUserInput(answer);
            }
            catch
            {
                Console.WriteLine($"Int32 values only, answer was {answer}");
                subIt(maxVal);
            }

            subIt(maxVal);
        }
    }
}
