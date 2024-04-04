namespace CAGenericDelegate02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> list1 = new int[] { 2, 5, 6, 7, 9, 1, 3, 4, 8 };

           
            PrintNumber(list1, n => n < 6, () => Console.WriteLine("Number Less Than Six"));

            PrintNumber(list1, n => n < 7, () => Console.WriteLine("Number Less Than Seven"));

            PrintNumber(list1, n => n % 2 == 0, () => Console.WriteLine("Even Number"));

            IEnumerable<decimal> list2 = new decimal[]
            { 2.5m, 5.3m, 6.33m, 7.1m, 6.44m, 1.75m, 3.4m, 4.3m };

            PrintNumber(list2, n => n >= 6.33m, () => 
            Console.WriteLine("Number Greater than equal 6.33"));

            Console.ReadKey();
        }
        static void PrintNumber<T>(IEnumerable<T> number, Predicate<T> filtter, Action action)
        {
            action();
            foreach (var n in number)
            {
                if (filtter(n))
                {
                    Console.WriteLine(n);
                }
            }
        }
    }
}
