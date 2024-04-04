namespace CAInterface01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cashier c = new Cashier(new Cash());
            c.Checkout(99999.99m);

            Cashier c02 = new Cashier(new Debit());
            c02.Checkout(99999.99m);

            Console.ReadKey();
        }
    }

    class Cashier
    {
        private IPaymentWay _payment;
        public Cashier(IPaymentWay payment) 
        {
            _payment = payment;
        }

        public void Checkout(decimal amount)
        {
            _payment.Pay(amount);
        }
    }

    interface IPaymentWay
    {
        public void Pay(decimal amount);
    }

    class Cash : IPaymentWay
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Cash Payment: ${Math.Round(amount, 2):N0}");
        }
    }
    class Debit : IPaymentWay
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Debit Payment: ${Math.Round(amount, 2):N0}");
        }
    }

}


