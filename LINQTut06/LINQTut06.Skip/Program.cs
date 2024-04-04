using LINQTut06.Shared;

namespace LINQTut06.Skip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = Repository.LoadEmployees();

            var q1 = employees.Skip(10);
            q1.Print("Skip First 10 Employee");

            //var q2 = employees.SkipWhile( e => e.Salary != 214400);
            //q2.Print("Skip Whole Salary != 214400");

            var q3 = employees.SkipLast(10);
            q3.Print("Skip last 10 elements");

            Console.ReadKey();
        }
    }
}
