using Shared;

namespace LINQTut.Repeat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var q = QuestionBank.PickOne();

            var question01 = new List<Question>();
            for (int i = 0; i < 10; i++)
                question01.Add(new Question());
            Console.WriteLine(ReferenceEquals(question01[0], question01[1]));// DEF REF Type 
            // This Will Return False


            var question02 = Enumerable.Repeat(q, 10).ToList();
            //question02.ToQuiz();
            Console.WriteLine(ReferenceEquals(question02[0], question02[1]));// Same REF Type 
            // This Will Return True

            Console.ReadKey();
        }
    }
}
