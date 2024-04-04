
namespace CARef_Out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestRef();
            TestOut();

            Console.ReadKey();
        }

        private static void TestRef()
        {
            bool isSuccessful = true;
            var result = Divide(10, 0, ref isSuccessful);
            Console.WriteLine(result);
            Console.WriteLine(isSuccessful);
        }

        private static void TestOut()
        {
            bool isSuccessful;
            var result = DivideOut(10, 0, out isSuccessful);
            Console.WriteLine(result);
            Console.WriteLine(isSuccessful);
        }

        static double Divide(double number, double divisor, ref bool isSuccessful)
        {
            if (divisor == 0) 
            {
                Console.WriteLine("Can Not Divide on Zero");
               // isSuccessful = false;
                return 0;
            }

            isSuccessful = true;
            return number / divisor;
        }
        static double DivideOut(double number, double divisor, out bool isSuccessful)
        {
            if (divisor == 0)
            {
                Console.WriteLine("Can Not Divide on Zero");
                isSuccessful = false;
                return 0;
            }

            isSuccessful = true;
            return number / divisor;
        }
    }
}
