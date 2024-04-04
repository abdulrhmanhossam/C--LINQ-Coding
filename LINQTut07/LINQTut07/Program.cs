
using LINQTut07.Shared;

namespace LINQTut07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RunAnyDemo();
            //RunAllDemo();
            //RunAnyQuerySyntax();
            //RunAllQuerySyntax();
            RunContain();

            Console.ReadKey();
        }

        private static void RunAnyDemo()
        {
            Console.WriteLine();
            Console.WriteLine("+++++++++++++++++");
            Console.WriteLine("Run Any");
            Console.WriteLine("+++++++++++++++++");
            Console.WriteLine();

            var employees = Repository.LoadEmployees();

            var resutl01 = employees.Any(x => x.Name!.StartsWith("jac",
                StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(resutl01);

            var result02 = employees.Any(x => x.Salary < 10000);
            Console.WriteLine(result02);

            var result03 = employees.Any(x => x.Skills.Count() == 1);
            Console.WriteLine(result03);
        }
        private static void RunAllDemo()
        {
            Console.WriteLine();
            Console.WriteLine("+++++++++++++++++");
            Console.WriteLine("Run All");
            Console.WriteLine("+++++++++++++++++");
            Console.WriteLine();

            var employees = Repository.LoadEmployees();

            //Check if all employees have value for email
            var result01 = employees.All(x => !string.IsNullOrWhiteSpace(x.Email));
            Console.WriteLine($"Check if all employees have value for email: {result01}");

            //Check if all employees have value for C# Skill
            var result02 = employees.All(x => x.Skills.Any(s => s == "C#"));
            Console.WriteLine($"Check if all employees have value for C# Skill: {result02}");
        }
        public static void RunAnyQuerySyntax()
        {
            Console.WriteLine();
            Console.WriteLine("+++++++++++++++++");
            Console.WriteLine("Run Any");
            Console.WriteLine("+++++++++++++++++");
            Console.WriteLine();

            var employees = Repository.LoadEmployees();

            var query01 = from employee in employees
                          where employee.Skills.Any(s => s == "C++")
                          select employee;

            query01.Print("Employee with C++ Skill");
        }
        public static void RunAllQuerySyntax()
        {
            Console.WriteLine();
            Console.WriteLine("+++++++++++++++++");
            Console.WriteLine("Run All");
            Console.WriteLine("+++++++++++++++++");
            Console.WriteLine();

            var employees = Repository.LoadEmployees();

            var query02 = from employee in employees
                          where employee.Skills.All(s => s.Length >= 3)
                          select employee;

            query02.Print("Employee with Skills have 3 char and more");
        }

        private static void RunContain()
        {
            Console.WriteLine();
            Console.WriteLine("+++++++++++++++++");
            Console.WriteLine("Run Contain");
            Console.WriteLine("+++++++++++++++++");
            Console.WriteLine();

            var employees = Repository.LoadEmployees();

            //var result01 = employees.Any(x => x.Name!.Contains("ee"));
            //Console.WriteLine($"Check if any employee has 'ee' in there name: {result01}");

            var e = new Employee { Email = "Cole.Cochran01@example.com" };
            var result02 = employees.Contains(e);
            Console.WriteLine(result02);
        }

    }
}
