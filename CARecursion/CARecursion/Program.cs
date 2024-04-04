
Console.WriteLine(CalculateFactorial(5));
Console.WriteLine(5 * 4 * 3 * 2 * 1);
Console.ReadKey();

static int CalculateFactorial(int number)
{
    if (number <= 1)
        return number;
    return number * CalculateFactorial(number - 1);
}