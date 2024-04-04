
using LINQTut08.Shared;

namespace LINQTut08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RunGroubBy();
            //RunGroubByQuerysyntax();
            RunToLookUp();

            Console.ReadKey();
        }

        private static void RunGroubBy()
        {
            Console.WriteLine("Groub By Examble deferred (مؤجل)");

            var employees = Repository.LoadEmployees();

            var groubs01 = employees.GroupBy(e => e.Department);
            foreach (var groub in groubs01)
            {
                groub.Print($"Employees in '{groub.Key}' Department");
            }
        }
        private static void RunGroubByQuerysyntax()
        {
            Console.WriteLine("Groub By Examble");

            var employees = Repository.LoadEmployees();

            var groubs01 = from employee in employees
                           group employee by employee.Department;

            foreach (var groub in groubs01)
            {
                groub.Print($"Employees in '{groub.Key}' Department");
            }
        }

        private static void RunToLookUp()
        {
            Console.WriteLine("To Look Up Examble immediately (في الحال)");

            var employees = Repository.LoadEmployees();

            var groubs01 = employees.ToLookup(e => e.Department);

            foreach (var groub in groubs01)
            {
                groub.Print($"Employees in '{groub.Key}' Department");
            }
        }
    }
}
