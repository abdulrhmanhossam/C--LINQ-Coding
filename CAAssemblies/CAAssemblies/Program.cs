namespace CAAssemblies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var type = typeof(Employee);
            var assembly = type.Assembly;
            Console.WriteLine(assembly.FullName);
            Console.ReadKey();
        }
    }

    class Employee
    {

    }
}
