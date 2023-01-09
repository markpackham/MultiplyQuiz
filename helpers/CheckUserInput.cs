namespace MultiplyQuiz.helpers
{
    public class CheckUserInput
    {
        public static void checkUserInput(int answer)
        {
            int guess = Convert.ToInt32(Console.ReadLine());
            if (guess == 0)
            {
                MenuPage.mainMenu();
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
