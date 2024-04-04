
namespace LINQTut03.Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            IEnumerable<int> evenNumber = numbers.Where(x => x % 2 == 0); //Lazy
            evenNumber = evenNumber.Where(x => x > 4); // Lazy

            numbers.Add(10);
            numbers.Add(12);
            numbers.Remove(4);

            foreach (var number in evenNumber)
            {
                Console.Write(number);
            }
            Console.ReadKey();
        }
    }
}

