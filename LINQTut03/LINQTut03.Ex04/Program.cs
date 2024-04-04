using LINQTut03.Shared;

namespace LINQTut03.Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = Repository.LoadEmployees();

            var empMale = 
                employees.Where(x => x.Gender == "male");
            empMale.Print("Male Employee");

            var empSalaryOver300K = 
                employees.Where(x => x.Salary >= 300000);
            empSalaryOver300K.Print("Employee With Salary <= 300K");

            var empMaleInHRDepartment = 
                empMale.Where(x => x.Department!.ToLowerInvariant() == "hr");
            empMaleInHRDepartment.Print("Male Employee In HR Department");

            Console.ReadKey();
        }
    }
}
