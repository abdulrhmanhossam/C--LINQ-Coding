

var amount = 1000;
var member = 2;

member = Reduce(member ,2);

var share = Distribute(amount, member);


static int Reduce(int member, int value)
{
    return member -= value;
}

static int Distribute(int amount, int member)
{
    try 
    {
        return amount / member;
    } 
    catch(Exception e)
    {
        Console.WriteLine($"UnExcepted Error: {e.Message}");
    }

    return 0;

    
}