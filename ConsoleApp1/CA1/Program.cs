
M2(M1);

static void M1()
{
    Console.WriteLine("M1");
}
static void M2(Action action)
{
    action();
    Console.WriteLine("M2");
}

