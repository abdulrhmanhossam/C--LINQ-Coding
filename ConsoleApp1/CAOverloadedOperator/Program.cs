

Money m1 = new Money(10);
Money m2 = new Money(20);

var m3 = m1 - m2;
var m4 =m1 + m2;
var m5 =m1 > m3;

Console.WriteLine($"Money m3 : {m3.Amount} , Money m4 : {m4.Amount} , Money m4 : {m5}");



class Money
{
    private decimal _amount;
    public decimal Amount
    {
        get { return _amount; }
    }

    public Money(decimal value)
    {
        this._amount = Math.Round(value, 2);
    }

    // Make Class Type Can do + , -
    public static Money operator + (Money m1, Money m2)
    {
        return new Money(m1.Amount + m2.Amount);

    }
    public static Money operator -(Money m1, Money m2)
    {
        return new Money(m1.Amount - m2.Amount);
    }

    // Make Class Type Can do < , >
    public static bool operator > (Money m1, Money m2)
    {
        return m1.Amount > m2.Amount;
    }
    public static bool operator < (Money m1, Money m2)
    {
        return m1.Amount > m2.Amount;
    }

    // Make Class Type Can do <= , >=
    public static bool operator >=(Money m1, Money m2)
    {
        return m1.Amount > m2.Amount;
    }
    public static bool operator <=(Money m1, Money m2)
    {
        return m1.Amount > m2.Amount;
    }

    // Make Class Type Can do == , !=
    public static bool operator == (Money m1, Money m2)
    {
        return m1.Amount == m2.Amount;
    }
    public static bool operator != (Money m1, Money m2)
    {
        return m1.Amount > m2.Amount;
    }

}
