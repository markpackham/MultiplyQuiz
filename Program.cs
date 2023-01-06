using MultiplyQuiz.operators;
using static System.Net.Mime.MediaTypeNames;

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
                AddIt.addIt();
            }
            else if (choice.Equals("-"))
            {
                SubIt.subIt();
            }
            else if (choice.Equals("/"))
            {
                DivideIt.divideIt();
            }
            else if (choice.Equals("square"))
            {
                SquareIt.squareIt();
            }
            else if (choice.Equals("squareR"))
            {
                SquareRootIt.squareRootIt();
            }
            else
            {
                MultiplyIt.multiplyIt();
            }
        
        }
    }
}