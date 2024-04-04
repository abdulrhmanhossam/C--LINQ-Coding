using Shared;

namespace LINQTut10.Empty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var questions01 = new List<Question>(); 

            foreach (var q in questions01)
            {
                Console.WriteLine(q);
            }

            var questions02 = Enumerable.Empty<Question>(); // empty list

            //when i will make operation questions02 will get data 
            foreach (var q in questions01)
            {
                Console.WriteLine(q);
            }

            Console.ReadKey();
        }
    }
}
