namespace CADelegate02
{
    internal partial class Program
    {
        static void Main(string[] args)
        { 
            
             #region Multiy Cast
            //int num1 = 10;
            //int num2 = 2;
            //CalculateDelegate dlg = Add;
            //CalculateWithDelegate(num1, num2, dlg);

            //dlg += Subtract;    // dlg = dlg + Subtract
            //CalculateWithDelegate(num1, num2, dlg);

            //dlg += Multiply;    // dlg = dlg + Multiply
            //CalculateWithDelegate(num1, num2, dlg);

            //dlg += Divide;      // dlg = dlg + Divide
            //CalculateWithDelegate(num1, num2, dlg);
            #endregion

            #region LampdaExpression
            //CalculateWithDelegate(num1, num2, Add);
            //CalculateWithDelegate(num1, num2, Subtract);
            //CalculateWithDelegate(num1, num2, delegate (int x, int y) { return x * y; } );
            //CalculateWithDelegate(num1, num2, (x, y) => x / y ); //Lampda Expression
            //CalculateWithDelegate(num1, num2, (x, y) => x % y); //Lampda Expression
            #endregion

            List<Employee> employees = new();
            for (int i = 0; i < 101; i++) 
            {
                employees.Add(new Employee
                {
                    Name = $"Employee {i}",
                    BasicSalary = Random.Shared.Next(1000, 5001),
                    Deductions = Random.Shared.Next(0, 501),
                    Bouns = Random.Shared.Next(0,1001),
                });
            }

            CalculateSalaries(employees, e => e.BasicSalary <= 2000);  

            Console.ReadKey();
        }
        delegate bool SalaryDelegate (Employee SalaryCondation);
        private static void CalculateSalaries(List<Employee> employees, SalaryDelegate predicate)
        {
            foreach (var employee in employees)
            {
                if (predicate(employee))
                {
                    var salary = employee.BasicSalary + employee.Bouns - employee.Deductions;
                    Console.WriteLine($"Salary For {employee.Name} = {salary}");
                    Console.WriteLine($"Basic Salary For {employee.Name} = {employee.BasicSalary}\n-----------------------");
                }          
            }
        }

        #region Some Method
        //delegate int CalculateDelegate (int num1, int num2);    

        //static void CalculateWithDelegate(int num1, int num2, CalculateDelegate calcDelegate )
        //{
        //    int result = calcDelegate(num1, num2);

        //    Console.WriteLine($"Result: {result}\n -------------");

        //}

        //static int Add(int num1, int num2) 
        //{
        //    Console.WriteLine("Add");
        //    return num1 + num2;
        //}

        //static int Subtract(int num1, int num2)
        //{
        //    Console.WriteLine("Subtract");
        //    return num1 - num2;
        //}

        //static int Multiply(int num1, int num2)
        //{
        //    Console.WriteLine("Multiply");
        //    return num1 * num2;
        //}

        //static int Divide(int num1, int num2)
        //{
        //    Console.WriteLine("Divide");
        //    return num1 / num2;
        //}
        #endregion
    }
}
