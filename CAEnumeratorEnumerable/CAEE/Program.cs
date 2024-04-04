using System.Collections;

namespace CAEE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ints = new FiveIntegers( 1, 2, 3, 4, 5 );
            foreach (var i in ints)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
    class FiveIntegers : IEnumerable
    {
        private int[] _values;
        public FiveIntegers(int n1, int n2, int n3, int n4, int n5)
        {
            _values = new[] { n1, n2, n3, n4, n5 };
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var item in _values)
            {
                yield return item;
            }
        }
    }
}
