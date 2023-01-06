using MultiplyQuiz.operators;
using static System.Net.Mime.MediaTypeNames;

namespace MultiplyQuiz
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Choose *, +, - or /. The default is *");
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
            else
            {
                MultiplyIt.multiplyIt();
            }
        
        }
    }
}