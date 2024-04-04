

Stock s1 = new Stock("Amazon");
s1.Price = 100;
s1.OnPriceChange += S1_OnPriceChange;

s1.ChangeStockPriceBy(0.05m);
s1.ChangeStockPriceBy(-0.02m);
s1.ChangeStockPriceBy(0.00m);


static void S1_OnPriceChange(Stock stock, decimal oldPrice)
{
    if (stock.Price > oldPrice)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{stock.Name}: {stock.Price}");
    }
    else if (stock.Price < oldPrice) 
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{stock.Name}: {stock.Price}");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine($"{stock.Name}: {stock.Price}");
    }
}

public delegate void StockPriceChangeHandler(Stock stock, decimal oldPrice);

public class Stock
{
    private string? _name;
    private decimal _price;

    public event StockPriceChangeHandler? OnPriceChange;

    public string Name => _name!;

    public decimal Price
    {
        get
        {
            return _price;
        }
        set
        {
            _price = value;
        }
    }

    public Stock(string stockName)
    {
        this._name = stockName;
    }

    public void ChangeStockPriceBy(decimal percent)
    {
        decimal oldPrice = this._price;
        this._price += Math.Round(this._price * percent, 2);
        if (OnPriceChange != null) 
        {
            OnPriceChange(this, oldPrice);
        }
    }
}
