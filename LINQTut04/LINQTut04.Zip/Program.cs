using LINQTut04.Shared;
using System.Linq;
namespace LINQTut04.Zip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunExample01();
            RunExample02();
            Console.ReadKey();
        }

        private static void RunExample01()
        {
            string[] colorName = { "Red", "Green", "Blue" };
            string[] colorHEX = { "FF0000", "00FF00", "0000FF" };


            var colors = colorName.Zip(colorHEX, (name, hex) => $"{name} ({hex})");
            foreach (var item in colors)
            {
                Console.WriteLine(item);
            }
        }
        private static void RunExample02()
        {
            var employees = Repository.LoadEmployees().ToArray();
            var firstThreeEmps = employees[..3];
            var lastThreeEmps = employees[^3..];
             // عمليه دمج ما بين 2 Array
            var teams = firstThreeEmps.Zip(lastThreeEmps, 
                (first, last) => $"{first.FullName} with {last.FullName}");

            foreach (var team in teams)
            {
                Console.WriteLine(team);
            }
        }
    }
}
