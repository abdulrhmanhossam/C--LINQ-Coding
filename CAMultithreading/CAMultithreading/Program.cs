namespace CAMultithreading
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var cancellationToken = new CancellationTokenSource();
            ProcessBatch01(cancellationToken.Token);
            ProcessBatch02(cancellationToken.Token);
            Console.WriteLine("Please enter your name");
            var name = Console.ReadLine();
            Console.WriteLine($"Welcome, {name}");
            Console.ReadKey();
        }
        private static object _lock = new();
        static async Task ProcessBatch01(CancellationToken cancellationToken)
        {
            for (int i = 1; i < 2000; i++)
            {  
                if (cancellationToken.IsCancellationRequested)
                    return;
                await Task.Delay(500);
                lock (_lock)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(i);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            return;
        }

        static async Task ProcessBatch02(CancellationToken cancellationToken)
        {
            for (int i = 2001; i < 4000; i++)
            {
                if (cancellationToken.IsCancellationRequested)
                    return;
                await Task.Delay(500);
                lock (_lock) 
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(i);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            return;
        }
    }
}
