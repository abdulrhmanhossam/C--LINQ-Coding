using Shared;

namespace LINQTut11.Last
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var questions = QuestionBank.All;

            var lastQuestion = questions.Last();
            //Console.WriteLine(lastQuestion);

            //var someQuestions = questions.Last(x => x.Title!.Length == 0);//InvalidOperationException
            //Console.WriteLine(someQuestions);

            var someOtherQuestions = questions.LastOrDefault(x => x.Title!.Length == 0);//return null
            if (someOtherQuestions != null)
                Console.WriteLine(someOtherQuestions);
            else
                Console.WriteLine("InvalidOperationException");

            Console.ReadKey();
        }
    }
}
