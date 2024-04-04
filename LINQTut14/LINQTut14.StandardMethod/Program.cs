
using Shared;

namespace LINQTut14.StandardMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunCount();
            Console.ReadKey();
        }

        private static void RunCount()
        {
            var quiz = QuestionBank.GetQuestionRange(Enumerable.Range(1, 200));
            Console.WriteLine($"Total Questions: {quiz.Count}");
            Console.WriteLine($"Total Questions With one Mark: " +
                $"{quiz.Count(x => x.Marks == 1)}");

        }
    }
}
