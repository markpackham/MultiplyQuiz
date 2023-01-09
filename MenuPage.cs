using MultiplyQuiz.operators;

namespace MultiplyQuiz
{
    public class MenuPage
    {
        public static void mainMenu()
        {
            Console.WriteLine("Choose *, +, -, /, square, squareR or power. The default is *");
            string choice = Console.ReadLine().ToString();

            if (choice.Equals("+"))
            {
                AddOper.addIt();
            }
            else if (choice.Equals("-"))
            {
                SubOper.subIt();
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
