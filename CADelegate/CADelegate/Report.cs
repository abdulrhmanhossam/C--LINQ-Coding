using System;

namespace ConsoleApp1
{
    public class Report
    {

        public delegate bool IllegibleSales(Employee e);

        public void ProcessEmployee(Employee[] employees, string title , IllegibleSales isIllegible)
        {
            Console.WriteLine(title);
            Console.WriteLine("----------------------------");

            foreach (var e in employees)
            {
                if (isIllegible(e))
                {
                    Console.WriteLine($"ID:{e.Id} | Name:{e.Name} | Gender:{e.Gender}");
                }
            }
            Console.WriteLine("\n\n");
        }
    }
}
