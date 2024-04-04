using Shared;

namespace LINQTut11.ElementAt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var questions = QuestionBank.All;

            var questionsAtLocation10 = questions.ElementAtOrDefault(10);
            Console.WriteLine(questionsAtLocation10);

            // var questionsAtLocation10 = questions.ElementAt(300); ArgumentOutOfRangeException
            var questionsAtLocation300 = questions.ElementAtOrDefault(300);
            Console.WriteLine(questionsAtLocation300); 


            Console.ReadKey();
        }
    }
}
