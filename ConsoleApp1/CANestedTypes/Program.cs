
Employee e1 = new Employee(1, "Amazon");
Console.WriteLine(e1.EmployeeInsurance!.PolicyId);
Console.WriteLine(e1.EmployeeInsurance!.CompanyName);




class Employee
{
    private int Id { get; set; }
    private string? Name { get; set; }

    public Insurance? EmployeeInsurance { get; set; }
    public Employee(int id , string name)
    {
        EmployeeInsurance = new Insurance();
        EmployeeInsurance.PolicyId = id;
        EmployeeInsurance.CompanyName = name;
    }

    public class Insurance
    {
        public int PolicyId { get; set; }
        public string? CompanyName { get; set; }
    }
}

class Department
{
    public int Id { get; set; }
    public string? Name { get; set; }
}



/*
class A
{
    private int x;


    class B
    {
        public void Method()
        {
            A a = new A();
            a.x = 1; // can access anything private at Container Class
        }
    }
}
*/


