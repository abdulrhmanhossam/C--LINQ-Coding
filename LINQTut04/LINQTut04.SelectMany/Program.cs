using LINQTut04.Shared;

namespace LINQTut04.SelectMany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RunExample01();
            RunExample02();
            Console.ReadKey();
        }

        public static void RunExample01()
        {
            string[] sentences =
            {
                "I love asp.net core",
                "I like sql server also",
                "in general i love programming"
            };

            var words = sentences.SelectMany(x => x.Split(' '));
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
            
        }
        public static void RunExample02()
        {
            var employees = Repository.LoadEmployees();
            var skills = employees.SelectMany(x => x.Skills).Distinct();

            var result01 = (from employee in employees
                           from skill in skills
                           select skill).Distinct();

            foreach (var skill in skills)
            {
                Console.WriteLine(skill);
            }
        }
    }
}
