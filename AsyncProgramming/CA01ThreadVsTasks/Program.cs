
namespace CA01ThreadVsTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var thread01 = new Thread(() => 
            { Display("Abdulrhman Using Thread !!!"); });
            thread01.Start();


            Task.Run(() => { Display("Abdulrhman Using Task !!!"); });
            Console.ReadKey();
        }

        static void Display(string message)
        {
            ShowThreadInfo(Thread.CurrentThread);
            Console.WriteLine(message);
        }

        private static void ShowThreadInfo(Thread currentThread)
        {
            Console.WriteLine($"TID:{currentThread.ManagedThreadId}, " +
                $"Pooled: {currentThread.IsThreadPoolThread}, " +
                $"Background: {currentThread.IsBackground}");
        }
    }
}
