using MultiplyQuiz.operators;

namespace MultiplyQuiz
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Choose *, +, -, square, squareR or /. The default is *");
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