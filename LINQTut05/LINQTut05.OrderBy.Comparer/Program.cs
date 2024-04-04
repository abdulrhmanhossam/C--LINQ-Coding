

using LINQTut05.Shared;
using System.Linq;

namespace LINQTut05.OrderBy.Comparer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Employee> employees = Repository.LoadEmployees();

            //IOrderedEnumerable<Employee> sortedEmployees01 = 
            //    employees.OrderBy(e => e.EmployeeNo);

            IOrderedEnumerable<Employee> sortedEmployees02 =
                employees.OrderBy(e => e, new EmployeeComparer());

            sortedEmployees02.Print("Sorted Employees");

            Console.ReadKey();
        }
    }
}
