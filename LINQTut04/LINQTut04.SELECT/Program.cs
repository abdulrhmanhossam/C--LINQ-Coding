using LINQTut04.Shared;
using System.Linq;

namespace LINQTut04.SELECT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunExample01();
            RunExample02();
            RunExample03();
            Console.ReadKey();
        }
        public static void RunExample01()
        {
            List<string> words = new() { "i", "love", "asp.net", "core" };

            var result01 = words.Select(x => x.ToUpper());

            //var result02 = from word in words
            //               select word.ToUpper();

            foreach (var word in result01) 
            {
                Console.WriteLine(word);
            }
        }
        public static void RunExample02()
        {
            List<int> numbers = new() { 2, 3, 5, 7 };

            var result01 = numbers.Select(x => x * x);

            //var result02 = from n in numbers
            //               select n * n;

            foreach (var n in result01)
            {
                Console.WriteLine(n);
            }
        }
        public static void RunExample03()
        {
            var employees = Repository.LoadEmployees(); 

            var result = employees.Select(x =>
            {
                return new EmployeeDto
                {
                    Name = $"{x.FullName} {x.LastName}",
                    TotalSkills = x.Skills.Count(),
                };
            });

            foreach (var employee in result)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
