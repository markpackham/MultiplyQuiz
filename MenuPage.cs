using MultiplyQuiz.operators;

namespace MultiplyQuiz
{
    public class MenuPage
    {
        public static void mainMenu()
        {
            Console.WriteLine("Choose *, +, -, /, square, squareR, power or to quit 'exit'. The default is *");
            string choice = Console.ReadLine().ToString();

            if (choice.Equals("exit"))
            {
                Environment.Exit(0);
            }
            else if (choice.Equals("+"))
            {

                Console.WriteLine("Supply a max value between 10 and 300, the default is 100");
                try
                {
                    int maxValue = Convert.ToInt32(Console.ReadLine());
                    AddOper.addIt(maxValue);
                }
                catch
                {
                    int maxValue = 100;
                    AddOper.addIt(maxValue);
                }

            }
            else if (choice.Equals("-"))
            {
                Console.WriteLine("Supply a max value between 10 and 300, the default is 100");
                try
                {
                    int maxValue = Convert.ToInt32(Console.ReadLine());
                    SubOper.subIt(maxValue);
                }
                catch
                {
                    int maxValue = 100;
                    SubOper.subIt(maxValue);
                }
            }
            else if (choice.Equals("/"))
            {
                DivideOper.divideIt();
            }
            else if (choice.Equals("power"))
            {
                Console.WriteLine("Supply a power value that is an Int32, 3 is the default");
                try
                {
                    int pow = Convert.ToInt32(Console.ReadLine());
                    PowerOper.powerIt(pow);
                }
                catch
                {
                    int pow = 3;
                    PowerOper.powerIt(pow);
                }

            }
            else if (choice.Equals("square"))
            {
                SquareOper.squareIt();
            }
            else if (choice.Equals("squareR"))
            {
                SquareRootOper.squareRootIt();
            }
            else
            {
                MultiplyOper.multiplyIt();
            }
        }
    }
}
