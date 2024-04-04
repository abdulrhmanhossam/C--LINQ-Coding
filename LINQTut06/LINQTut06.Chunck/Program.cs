using LINQTut06.Shared;

namespace LINQTut06.Chunck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = Repository.LoadEmployees();
            // مجموعات كل مجموعه من 10
            var chuncks = employees.Chunk(10).ToList();
            for (int i = 0; i < chuncks.Count; i++)
            {
                chuncks[i].Print($"Chunk #{i + 1}");
            }
            Console.ReadKey();
        }
    }
}
