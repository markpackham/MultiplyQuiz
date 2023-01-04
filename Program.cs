namespace MultiplyQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Random rnd = new Random();

            int num1 = rnd.Next(1, 9);
            int num2 = rnd.Next(1, 9);
            int answer = num1 * num2;
            Console.WriteLine($"{num1} * {num2} = what?");

            try
            {
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess == answer)
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
                Console.WriteLine("Int32 values only");
            }
        }
    }
}