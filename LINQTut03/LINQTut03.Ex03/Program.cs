using LINQTut03.Shared;

namespace LINQTut03.Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> number = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var evenNumbersUsingExtensionWhere = 
                number.Where(x => x % 2 == 0);

            var evenNumbersUsingEnumerableWhereMethod =
                Enumerable.Where(number, x => x % 2 == 0);

            var evenNumbersUsingQuerySyntax =
                from n in number
                where n % 2 == 0
                select n;

            evenNumbersUsingExtensionWhere.Print("evenNumbersUsingExtensionWhere");
            evenNumbersUsingEnumerableWhereMethod.Print("evenNumbersUsingEnumerableWhereMethod");
            evenNumbersUsingQuerySyntax.Print("evenNumbersUsingQuerySyntax");

            Console.ReadKey();
        }
    }
}
