using Shared;

namespace LINQTut10.DefaultIfEmpty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var questions01 = Enumerable.Empty<Question>();

            // Get Default Value For Object
            var questions02 = questions01.DefaultIfEmpty();

            //if questions01 == null return Default Value For this Object
            var questions03 = questions01.DefaultIfEmpty(Question.Default);
            questions03.ToQuiz();

            Console.ReadKey();
        }
    }
}
