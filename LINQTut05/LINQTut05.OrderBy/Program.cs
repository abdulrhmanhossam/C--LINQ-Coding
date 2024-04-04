using LINQTut05.Shared;
using System.Linq;

namespace LINQTut05.OrderBy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "apricot", "orange", "banana", 
                "mango", "apple", "grape", "strawberry" };

            // Method Syntax
            var orderdFruits = fruits.OrderBy(f => f); // ASC
            orderdFruits.Print("Fruites ASC (Method Syntax)");

            //Query Syntax
            var orderdFruitsQ = from fru in fruits
                                orderby fru
                                select fru;
            orderdFruitsQ.Print("Fruites ASC (Query Syntax)");

            // Method Syntax Descending => from small to big
            var orderdFruitDesc = fruits.OrderByDescending(f => f);
            orderdFruitDesc.Print("Fruites Desc (Method Syntax Descending)");

            // Query Syntax Descending => from small to big
            var orderdFruitDescQ = from fru in fruits
                                   orderby fru descending
                                   select fru;
            orderdFruitDescQ.Print("Fruites Desc (Query Syntax Descending)");

            // Method Syntax ASC Length
            var orderdFruitAscLength = fruits.OrderBy(f => f.Length);
            orderdFruitAscLength.Print("Fruites orderdFruit Asc Length " +
                "(Method Syntax orderdFruitAscLength)");

            // Query Syntax Length Descending
            var orderdFruitDescLengthQ = from fru in fruits
                                   orderby fru.Length descending
                                   select fru;
            orderdFruitDescLengthQ.Print("Fruites orderdFruit DESC Length " +
                "(Query Syntax orderdFruitDESCLength)");

            Console.ReadKey();
        }
    }
}
