namespace CaMultithreading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "Main Thread";
            Console.WriteLine(Thread.CurrentThread.Name);
            //Console.WriteLine($"Background Thread: {Thread.CurrentThread.IsBackground}");
            var wallet = new Wallet("Abdulrhman", 80);

            Thread thread01 = new Thread(wallet.RunRandomTransaction);
            thread01.Name = "Thread 01";
            //Console.WriteLine(thread01.Name);
            //Console.WriteLine($"Background Thread: {thread01.IsBackground}");
            //Console.WriteLine($"Before Start {thread01.Name} State is: {thread01.ThreadState}");
            
            thread01.Start();
            Console.WriteLine($"After Start {thread01.Name} State is: {thread01.ThreadState}");
            thread01.Join();
            //Console.WriteLine($"After Start {thread01.Name} State is: {thread01.ThreadState}");
            
            var thread02 = new Thread(new ThreadStart(wallet.RunRandomTransaction));
            thread02.Name = "Thread 02";
            thread02.Start();
            //Console.WriteLine($"After Start {thread02.Name} State is: {thread02.ThreadState}");

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
            Thread.Sleep(1000);
            Bitcoins -= amount;
            Console.WriteLine($"[Thread: {Thread.CurrentThread.ManagedThreadId}-" +
                $"{Thread.CurrentThread.Name}," +
                $", Processor Id: {Thread.GetCurrentProcessorId()}] -{amount}");
        }
        public void Credit(int amount)
        {
            Thread.Sleep(1000);
            Bitcoins += amount;
            Console.WriteLine($"[Thread: {Thread.CurrentThread.ManagedThreadId}-" +
                $"{Thread.CurrentThread.Name}," +
                $"Processor Id: {Thread.GetCurrentProcessorId()}] +{amount}");
        }
        public void RunRandomTransaction()
        {
            int[] amounts = { 10, 20, 30, -20, 10, -10, 30, -10, 40, -20 };

            foreach (var amount in amounts)
            {
                var absValue = Math.Abs(amount);
                if (amount < 0)
                    Debit(absValue);
                else
                    Credit(absValue);
                
            }
        }

        public override string ToString()
        {
            return $"[{Name} -> {Bitcoins} Bitcoins]";
        }
    }
}

