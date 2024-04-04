using System.Diagnostics;

namespace CAProcessAndThread
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine($"Process Id: {Process.GetCurrentProcess().Id}");
            Console.WriteLine($"Thread Id: {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine($"Processor Id: {Thread.GetCurrentProcessorId()}");

            Console.ReadKey();
        }
    }
}
