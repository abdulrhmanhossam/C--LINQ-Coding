using LINQTut06.Shared;

namespace LINQTut06.Take
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = Repository.LoadEmployees();

            var q1 = employees.Take(10);
            q1.Print("Take First 10 Employee");

            var q2 = employees.TakeWhile(e => e.Salary != 214400);
            q2.Print("Take Whole Salary != 214400");

            var q3 = employees.TakeLast(10);
            q3.Print("Take last 10 elements");

            Console.ReadKey();
        }
    }
}
