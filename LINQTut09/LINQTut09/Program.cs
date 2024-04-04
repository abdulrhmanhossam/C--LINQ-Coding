using LINQTut09.Shared;

namespace LINQTut09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RunJoin();
            //RunJoinQuerySyntax();
            //RunGroupJoin();
            RunGroupJoinQuerySyntax();


            Console.ReadKey();
        }

        private static void RunJoin()
        {
            var employees = Repository.LoadEmployees();
            var departments = Repository.LoadDepartment();

            var result = employees.Join(departments,
                emp => emp.DepartmentId, dept => dept.Id,
                (emp, dept) => new EmployeeDto
                {
                    FullName = emp.FullName,
                    Department = dept.Name
                });

            foreach (var item in result)
            {
                Console.WriteLine($"{item.FullName} [{item.Department}]");
            }
        }
        private static void RunJoinQuerySyntax()
        {
            var employees = Repository.LoadEmployees();
            var departments = Repository.LoadDepartment();

            var result = from emp in employees
                         join dept in departments on emp.DepartmentId equals dept.Id
                         select new EmployeeDto 
                         { 
                             FullName = emp.FullName,
                             Department = dept.Name 
                         };

            foreach (var item in result)
            {
                Console.WriteLine($"{item.FullName} [{item.Department}]");
            }
        }
        private static void RunGroupJoin()
        {
            var employees = Repository.LoadEmployees();
            var departments = Repository.LoadDepartment();

            var result = departments.GroupJoin(employees, dept => dept.Id,
                emp => emp.DepartmentId, (dept, emp) => new Group
                {
                    Department = dept.Name,
                    Employees = emp.Select(e => e.FullName).ToList()
                });


            foreach (var g in result)
            {
                Console.WriteLine($"+++++ {g.Department} +++++");
                foreach (var name in g.Employees!)
                {
                    Console.WriteLine($"\t{name}");
                }
            }
        }
        private static void RunGroupJoinQuerySyntax()
        {
            var employees = Repository.LoadEmployees();
            var departments = Repository.LoadDepartment();

            var result = from dept in departments join emp in employees 
                         on dept.Id equals emp.DepartmentId into empGroup
                         select empGroup;


            foreach (var g in result)
            {
                Console.WriteLine($"+++++ Group +++++");
                foreach (var item in g)
                {
                    Console.WriteLine($"\t{item.FullName}");
                }
            }
        }
    }
}
