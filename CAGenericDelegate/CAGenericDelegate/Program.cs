

IEnumerable<int> list1 = new int[] {  2, 5, 6, 7, 9, 1, 3, 4, 8 };

Console.WriteLine("Number Less Than Six");
PrintNumber(list1, n => n < 6);
Console.WriteLine("Number Less Than Seven");
PrintNumber(list1, n => n < 7);
Console.WriteLine("Even Number");
PrintNumber(list1, n => n % 2 == 0);

IEnumerable<decimal> list2 = new decimal[] { 2.5m, 5.3m, 6.33m, 7.1m, 6.44m, 1.75m, 3.4m, 4.3m };
Console.WriteLine("Number Greater than equal 6.33");
PrintNumber(list2, n => n >= 6.33m);

Console.ReadKey();


static void PrintNumber<T>(IEnumerable<T> number, Predicate<T> filtter)
{
    foreach (var n in number)
    {
        if(filtter(n))
        {
            Console.WriteLine(n);
        }
    }
}



/* .NET Delegate
Action<string> action = Print;
action("Abdulrhman");
Func<int, int, int> func = Add;
Console.WriteLine(func(2,6));
Predicate<int> predicate = IsEven;
Console.WriteLine(predicate(3));

Console.ReadKey();

static void Print (string name) => Console.WriteLine (name);
static int Add(int n1, int n2) => n1 + n2;
static bool IsEven(int n) => n % 2 == 0;
*/

/* Simple Generic Delegate impelmation
IEnumerable<int> list1 = new int[] {  2, 5, 6, 7, 9, 1, 3, 4, 8 };

Console.WriteLine("Number Less Than Six");
PrintNumber(list1, n => n < 6);
Console.WriteLine("Number Less Than Seven");
PrintNumber(list1, n => n < 7);
Console.WriteLine("Even Number");
PrintNumber(list1, n => n % 2 == 0); 

Console.ReadKey();


static void PrintNumber<T>(IEnumerable<T> number, Filtter<T> filtter)
{
    foreach (var n in number)
    {
        if(filtter(n))
        {
            Console.WriteLine(n);
        }
    }
}

public delegate bool Filtter<in T>(T n);
*/