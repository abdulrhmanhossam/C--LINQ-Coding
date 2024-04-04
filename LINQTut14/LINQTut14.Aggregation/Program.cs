using Shared;

namespace LINQTut14.Aggregation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RunMethod01();
            //RunMethod02();
            RunMethod03();

            Console.ReadKey();
        }

        private static void RunMethod01()
        {
            var names = new[] { "Ali", "Salem", "Abeer", "Reem", "Jalal" };
            //var output = "";
            //foreach (var item in names)
            //    output += $"{item},";
            //Console.WriteLine(output.TrimEnd(','));

            //var output = string.Join(",", names);
            //Console.WriteLine(output);

            var commaSeparatedName = names.Aggregate((a, b) =>
            {
                // a Collect Element and b take new Element To Add to a
                Console.WriteLine($"a = {a} , b = {b}");
                return $"{a},{b}";
                
            });
            Console.WriteLine(commaSeparatedName);
        }
        private static void RunMethod02()
        {
            var numbers = new[] { 1, 2, 3, 4, 5 };
            /*
            start from 0
            first take Element 1 from array of number  0 + 1
            now a = 1 , b = 2 => take next Element From Array
            agin take Elememt 2 from b and add to a 1 + 2
            now a = 3 , b = 3 take next Element From Array
            */
            var total = numbers.Aggregate(0, (a, b) => a + b);
            Console.WriteLine($"Total: {total}");
        }
        private static void RunMethod03()
        {
            var quiz = QuestionBank.All;
            /*
            start from longestQuestionTitle
            first Compare longestQuestionTitle and Next Question and return Bigest
            now save return Element on longest and compare with next element and return Bigest
            */

            var longestQuestionTitle = quiz[0];

            longestQuestionTitle = quiz.Aggregate(longestQuestionTitle, (longest, next)
                => longest.Title!.Length < next.Title!.Length ? next : longest, x => x);
            Console.WriteLine($"{longestQuestionTitle}");
        }
    }
}
