namespace CAEnumerables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee();
            employee.AddPayItem("Basic Salary", 1000);
            employee.AddPayItem("Housing", 500);
            employee.AddPayItem("Transportation", 200);
            employee.AddPayItem("Tnssurance", -300);

            foreach(var payItem in employee)
                Console.WriteLine($"{payItem.Name} = {payItem.Value}");

            Console.ReadKey();
        }
    }
}
