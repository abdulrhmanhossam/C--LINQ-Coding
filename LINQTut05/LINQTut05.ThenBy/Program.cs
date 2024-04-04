

using LINQTut05.Shared;

namespace LINQTut05.ThenBy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = Repository.LoadEmployees();

            var sortedEmployees01 = employees.OrderBy(e => e.Name).ThenBy(e => e.Salary);
            sortedEmployees01.Print("sortedEmployees01");

            var sortedEmployees02 = employees.OrderBy(e => e.Name).ThenByDescending(e => e.Salary);
            sortedEmployees02.Print("sortedEmployees02");

            Console.ReadKey();
        }
    }
}
