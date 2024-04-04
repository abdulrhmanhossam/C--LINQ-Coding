namespace CADeadLock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var wallet01 = new Wallet("Abdulrhman", 100);
            var wallet02 = new Wallet("Reem", 50);

            Console.WriteLine("\n Before Transaction");
            Console.WriteLine("\n-------------------");
            Console.Write(wallet01 + ",  ");
            Console.Write(wallet02);

            Console.WriteLine("\n After Transaction");
            Console.WriteLine("\n-------------------");
            var transferManager01 = new TransferManager(wallet01, wallet02, 50);
            var transferManager02 = new TransferManager(wallet02, wallet01, 30);

            var thread01 = new Thread(transferManager01.Transfer);
            thread01.Name = "Thread 01";
            var thread02 = new Thread(transferManager02.Transfer);
            thread02.Name = "Thread 02";

            thread01.Start();
            thread02.Start();

            thread01.Join();
            thread02.Join();

            
            Console.Write(wallet01 + ",  ");
            Console.Write(wallet02);

            Console.ReadKey();
        }
    }
}
