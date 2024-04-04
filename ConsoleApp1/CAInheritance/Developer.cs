

public class Developer : Employee
{
    private const decimal _commission = 0.03m;
    protected bool TaskCompleted { get; set; }
    public Developer(int id, string? name, decimal loggedHours, decimal wage,
      bool taskCompleted) : base(id, name, loggedHours, wage)
    {
        this.TaskCompleted = taskCompleted;
    }
    protected override decimal Calculate()
    {
        return base.Calculate() + CalculateBouns();
    }

    private decimal CalculateBouns()
    {
        if (TaskCompleted)
        {
            return base.Calculate() * _commission;
        }
        else { return 0; }
    }

    public override string ToString()
    {
        return base.ToString() +
               $"\nTask Completed: {(TaskCompleted ? "Yes":"No")}" +
               $"\nBouns: {Math.Round(CalculateBouns(), 2):N0}" +
               $"\nNet Salary: {Math.Round(this.Calculate(), 2):N0}";
    }
}
