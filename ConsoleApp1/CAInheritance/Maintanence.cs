

public class Maintanence: Employee
{

    private const decimal _hardShip = 100m;

    public Maintanence(int id, string? name, decimal loggedHours, decimal wage): base(id, name, loggedHours, wage) 
    {
        
    }
    protected override decimal Calculate()
    {
        return base.Calculate() + _hardShip;
    }


    public override string ToString()
    {
        return base.ToString() +
               $"\nHardship: {Math.Round(_hardShip, 2):N0}" +
               $"\nNet Salary: {Math.Round(this.Calculate(), 2):N0}";
    }
}