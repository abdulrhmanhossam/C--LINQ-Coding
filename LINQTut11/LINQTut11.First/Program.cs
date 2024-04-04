using Shared;

namespace LINQTut11.First
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var questions = QuestionBank.All;

            var firstQuestion = questions.First();
            //Console.WriteLine(firstQuestion);

            //var someQuestions = questions.First(x => x.Title!.Length == 0);//InvalidOperationException
            //Console.WriteLine(someQuestions);

            var someOtherQuestions = questions.FirstOrDefault(x => x.Title!.Length == 0);//return null
            if (someOtherQuestions != null)
                Console.WriteLine(someOtherQuestions);
            else
                Console.WriteLine("InvalidOperationException");

            Console.ReadKey();
        }
    }
}
