using Shared;

namespace LINQTut10.Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var range = Enumerable.Range(1, 10);

            //foreach (var item in range)
            //{
            //    Console.WriteLine(item);
            //}


            // get some data at range of numbers
            var questions = QuestionBank.GetQuestionRange(range);

            questions.ToQuiz();

            Console.ReadKey();
        }
    }
}
