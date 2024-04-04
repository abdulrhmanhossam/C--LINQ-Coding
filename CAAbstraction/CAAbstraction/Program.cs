

BankAccount bankAccount = new SavingAccount();

bankAccount.AccountNumber = "1111";
bankAccount.Balance = 6000;


bankAccount.Deposit(100);
Console.WriteLine(bankAccount.Balance);
bankAccount.Withdraw(1000);
Console.WriteLine(bankAccount.Balance);
Console.ReadKey();

public abstract class BankAccount
{
    public string? AccountNumber { get; set; }
    public decimal Balance { get; set; }

    public abstract void Deposit(decimal amount);
    public abstract void Withdraw(decimal amount);
}

public class CheckingAccount : BankAccount
{
    private const decimal _dailyWithDrawalLimt = 5000;
    public override void Deposit(decimal amount)
    {
        if (amount < 0)
            throw new InvalidOperationException();

        Balance += amount;
    }

    public override void Withdraw(decimal amount)
    {
        if (amount > _dailyWithDrawalLimt)
            throw new InvalidOperationException();

        if (amount < 0)
            throw new InvalidOperationException();

        Balance -= amount;
    }
}

public class SavingAccount : BankAccount
{
    private const decimal _dailyWithDrawalLimt = 2000;
    public override void Deposit(decimal amount)
    {
        if (amount < 0)
            throw new InvalidOperationException();

        Balance += amount;
    }

    public override void Withdraw(decimal amount)
    {
        if (amount > _dailyWithDrawalLimt)
            throw new InvalidOperationException();

        if (amount < 0)
            throw new InvalidOperationException();

        Balance -= amount;
    }

}

