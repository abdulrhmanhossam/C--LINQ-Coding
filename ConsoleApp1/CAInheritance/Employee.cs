

public class Employee
{
    private const int _minimumLoggedHours = 176;
    private const decimal _overTimeRate = 1.25m;

    protected Employee(int id, string? name, decimal loggedHours, decimal wage)
    {
        Id = id;
        Name = name;
        LoggedHours = loggedHours;
        Wage = wage;
    }

    protected int Id { get; set; }
    protected string? Name { get; set; }
    protected decimal LoggedHours { get; set; }
    protected decimal Wage { get; set; }

    protected virtual decimal Calculate()
    {
        return CalculateBaseSalary() + CalculateOverTime();
    }

    public decimal CalculateBaseSalary()
    {
        return LoggedHours * Wage;
    }

    public decimal CalculateOverTime()
    {
        var additionalHours = ((LoggedHours - _minimumLoggedHours) > 0 ? LoggedHours - _minimumLoggedHours : 0);
        return additionalHours * Wage * _overTimeRate;
    }

    public override string ToString()
    {
        var type = GetType();
        return $"{type}"+
               $"\nId: {Id}" +
               $"\nName: {Name}" +
               $"\nLogged Hours: {LoggedHours}" +
               $"\nWage: {Wage}" +
               $"\nBase Salary: {Math.Round(CalculateBaseSalary(), 2):N0}" +
               $"\nOvertime: {Math.Round(CalculateOverTime(), 2):N0}";
    }
}
