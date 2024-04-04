namespace CADeadLock
{
    class Wallet
    {
        public string? Name { get; private set; }
        public int Bitcoins { get; private set; }
        
        public Wallet(string? name, int bitcoins)
        {
            Name = name;
            Bitcoins = bitcoins;
        }

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
