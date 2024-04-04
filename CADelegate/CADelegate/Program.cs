

using ConsoleApp1;

var emps = new Employee[]
{
    new Employee{Id = 1, Name = "Abdulrhman H", Gender = "M", TotalSales = 65000m}, 
    new Employee{Id = 2, Name = "Reem S", Gender = "F", TotalSales = 50000m},
    new Employee{Id = 3, Name = "Suzan B", Gender = "F", TotalSales = 65000m},
    new Employee{Id = 4, Name = "Sara A", Gender = "F", TotalSales = 40000m},
    new Employee{Id = 5, Name = "Salah C", Gender = "M", TotalSales = 42000m},
    new Employee{Id = 6, Name = "Rateb A", Gender = "M", TotalSales = 30000m},
    new Employee{Id = 7, Name = "Abeer C", Gender = "F", TotalSales = 16000m},
    new Employee{Id = 8, Name = "Marwan M", Gender = "M", TotalSales = 15000m},
    new Employee{Id = 9, Name = "Ahmad R", Gender = "M", TotalSales = -10000m},
};


Report report = new Report();
//report.ProcessEmployee(emps, "Sales < 60000", e => e.TotalSales >= 60000); //2
report.ProcessEmployee(emps, "Sales >= 30,000 && <= 60,000", e => e.TotalSales >= 30000 && e.TotalSales < 60000m);
//report.ProcessEmployee(emps, "Sales < 15,000 ", e => e.TotalSales < 30000m && e.TotalSales >= 0);





// Multi Cast Delegate
//var r1 = new RectangleHelper();
//RectHelper rect = r1.GetArea;
//rect += r1.GetPerimter;
//rect(10, 10);

//Console.ReadKey();

//public delegate void RectHelper(decimal w, decimal h);

//public class RectangleHelper
//{
//    public void GetArea(decimal w, decimal h)
//    {
//        var result = w * h;
//        Console.WriteLine(result);
//    }
//    public void GetPerimter(decimal w, decimal h)
//    {
//        var result = 2 * (w + h);
//        Console.WriteLine(result);
//    }
//}
