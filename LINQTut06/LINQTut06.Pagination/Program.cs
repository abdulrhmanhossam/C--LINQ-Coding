using LINQTut06.Shared;

namespace LINQTut06.Pagination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var page = 1;
            var size = 10;

            Console.WriteLine("Result Per Page:");
            if (int.TryParse(Console.ReadLine(), out int resultPerPage)) 
            {
                size = resultPerPage;
            }
            Console.WriteLine("Page No:");
            if (int.TryParse(Console.ReadLine(), out int pageNo))
            {
                page = pageNo;
            }

            var employees = Repository.LoadEmployees();

            var result = employees.Paginate(page, size);

            var resultCount = result.Count();

            var startRecord = ((page - 1) * size) + 1;

            var endRecord = resultCount < size ? startRecord - 1
                : size * (page - 1) + size;

            result.Print($"showing employees {startRecord} - {endRecord}");

            Console.ReadKey();
        }
    }
}
