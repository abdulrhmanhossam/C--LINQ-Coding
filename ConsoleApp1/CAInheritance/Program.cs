
Manager m = new Manager(1000, "Ali A.", 180, 10);

Maintanence ms = new Maintanence(1000, "Salim M.", 182, 8);

Sales s = new Sales(1002, "Sally N.", 176, 9, 0.05m, 10000m);

Developer d = new Developer(1003, "Abdulrhman H.", 186, 15, true);

Employee[] employees = {m};
foreach (var employee in employees)
{
    Console.WriteLine("\n---------------------");
    Console.WriteLine(employee);
}

Console.ReadKey();
