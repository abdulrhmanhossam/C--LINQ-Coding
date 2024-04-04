namespace CARaceCondition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var wallet = new Wallet("Abdulrhman", 50);
            var thread01 = new Thread(() => wallet.Debit(40));
            var thread02 = new Thread(() => wallet.Debit(30));

            thread01.Start();
            thread02.Start();
            
            thread01.Join();
            thread02.Join();

            Console.WriteLine(wallet);

            Console.ReadKey();
            
        }
    }

    class Wallet
    {
        public Wallet(string? name, int bitcoins)
        {
            Name = name;
            Bitcoins = bitcoins;
        }

        public string? Name { get; private set; }
        public int Bitcoins { get; private set; }

        public void Debit(int amount)
        {
            lock (this) 
            {
                if (Bitcoins >= amount)
                {
                    Thread.Sleep(1000);
                    Bitcoins -= amount;
                }
            }
            
        }
        public void Credit(int amount)
        {
            Thread.Sleep(1000);
            Bitcoins += amount;
        }

        public override string ToString()
        {
            return $"[{Name} -> {Bitcoins} Bitcoins]";
        }
    }
}
