using Shared;

namespace LINQTut11.Single
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var questions = QuestionBank.All;

            //// Singel Element Can not Repet 
            //var question01 = questions.
            //    Single(x => x.Title!.Contains("#245"));//InvalidOperationException
            //var question02 = questions.
            //    SingleOrDefault(x => x.Title!.Contains("#245"));//InvalidOperationException
            //Console.WriteLine(question02);

            ////Singel Element Can not Be Null 
            //var question03 = questions.
            //    Single(x => x.Title!.Length == 0);//InvalidOperationException
            var question04 = questions.
                SingleOrDefault(x => x.Title!.Length == 0);
            if (question04 is null)
                Console.WriteLine("Invaild Operation Question04 is null");

            Console.ReadKey();
        }
    }
}
