
MakeSomeGarabge();
Console.WriteLine($"Memory Used Before Collection {GC.GetTotalMemory(false):N0}"); // 9,999,999
GC.Collect(); // Explicit Cleaning
Console.WriteLine($"Memory Used After Collection {GC.GetTotalMemory(true):N0}");
Console.ReadKey();

static void MakeSomeGarabge()
{
    Version v;
    for (int i = 0; i < 1000; i++)
    {
        v = new Version();
    }
}
